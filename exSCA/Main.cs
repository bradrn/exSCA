using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;
using FastColoredTextBoxNS;

namespace exSCA
{
    public partial class Main : Form
    {
        Style BoldStyle = new TextStyle(Brushes.Black, Brushes.White, FontStyle.Bold);
        Style BeigeStyle = new TextStyle(Brushes.Black, Brushes.Beige, FontStyle.Regular);
        Style GreenStyle = new TextStyle(Brushes.Green, Brushes.White, FontStyle.Italic);
        Style BlueStyle = new TextStyle(Brushes.Blue, Brushes.White, FontStyle.Regular);
        Style UnderscoreStyle = new TextStyle(Brushes.Black, Brushes.White, FontStyle.Underline);

        Dictionary<char, string> cats = new Dictionary<char, string>();

        PythonEditor PyEditor = new PythonEditor();
        Affixer Affixer;
        AboutBox AboutBox = new AboutBox();

        public Main()
        {
            InitializeComponent();
            Affixer = new Affixer(this);
        }

        private void Categories_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle();
            MatchCollection mc = Regex.Matches(Categories.Text, "^(.)=(.+)$", RegexOptions.Multiline);
            foreach (Match m in mc)
            {
                cats[m.Groups[1].Value[0]] = "";
                foreach (char c in m.Groups[2].Value)
                {
                    if (cats.ContainsKey(c)) cats[m.Groups[1].Value[0]] += cats[c];
                    else cats[m.Groups[1].Value[0]] += c;
                }
            }
            foreach (Range cat in Categories.GetRanges(@"^.(?==)", RegexOptions.Multiline))
            {
                e.ChangedRange.SetStyle(BeigeStyle, cat.Text);
            }
            SoundChanges.OnTextChanged();
            SyllabificationBox.OnTextChanged();
        }

        private void SyllabificationBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle();
            foreach (Range cat in Categories.GetRanges(@"^.(?==)", RegexOptions.Multiline))
            {
                e.ChangedRange.SetStyle(BeigeStyle, cat.Text);
            }
        }

        private void SoundChanges_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle();
            e.ChangedRange.SetStyle(BoldStyle, "/");
            e.ChangedRange.SetStyle(GreenStyle, @"\*.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(BlueStyle, @"\#|\(|\)|\[|\]|>|\\");
            e.ChangedRange.SetStyle(BlueStyle, "_");
            foreach (Range cat in Categories.GetRanges(@"^.(?==)", RegexOptions.Multiline))
            {
                e.ChangedRange.SetStyle(BeigeStyle, cat.Text);
            }
        }

        private void SimpleRewrite_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle();
            e.ChangedRange.SetStyle(BoldStyle, @"\|");
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            string[] curText;
            curText = Input.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            List<string> rulesUsed = new List<string>();

            #region Python Engine Setup
            ScriptEngine pyengine = Python.CreateEngine();
            ScriptScope pyscope = pyengine.CreateScope();
            try
            {
                pyscope.ImportModule("clr");

                pyengine.Execute("import clr", pyscope);
                pyengine.Execute("from System import *");
                pyengine.Execute(PyEditor.PythonText, pyscope);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            #endregion


            for (int i = 0; i < curText.Length; i++)
            {
                string originalWord = curText[i];
                string changedWord = originalWord;
                foreach (string _change in SoundChanges.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
                {
                    if (_change == "") continue;
                    string change = _change;
                    string options = "";
                    string[] split_change = _change.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (split_change.Length > 1 && !split_change[1].Contains("*"))
                    {
                        options = split_change[1];
                        change = split_change[0];
                    }
                    string _rulesUsed;
                    if (options.Contains("x") && SyllabificationBox.Text != "")
                    {
                        changedWord = Syllabify(changedWord, SyllabificationBox.Text);
                    }

                    if (change[0] != '-')
                    {
                        changedWord = SoundChange(DoRewrite(change), DoRewrite(changedWord), out _rulesUsed);
                    }
                    else
                    {
                        string methodName = string.Concat(change.Skip(1));
                        try
                        {
                            var soundChangeMethod = pyscope.GetVariable(methodName);
                            string[] words = changedWord.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                            foreach (string word in words)
                            {
                                changedWord = ((object)soundChangeMethod(DoRewrite(word), cats)).ToString();
                            }
                        }
                        catch (MissingMemberException)
                        {
                            DialogResult result =
                                MessageBox.Show($"There is no Python method with the name '{methodName}'. Do you want to open the Python editor?", "", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                PyEditor.Show();
                            }
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
                        _rulesUsed = methodName;
                    }
                    if (_rulesUsed != "") rulesUsed.Add(_rulesUsed);
                    changedWord = changedWord.Replace(".", "");
                }
                if (RewriteOnOutput.Checked) changedWord = DoRewrite(changedWord, true);
                bool changedFlag = curText[i] != changedWord && ShowChanges.Checked;
                if (PlainOutput.Checked) curText[i] = changedWord;
                else if (ArrowedOutput.Checked) curText[i] = $"{originalWord} \u2192 {changedWord}";
                else if (BracketedOutput.Checked) curText[i] = $"{changedWord} [{originalWord}]";
                if (changedFlag) curText[i] += " (changed)";
            }
            Output.Text = string.Join(Environment.NewLine, curText);

            if (ReportRules.Checked)
            {
                Notepad.NotepadHelper.ShowMessage(string.Join(Environment.NewLine, rulesUsed));
            }
            //sw.Stop(); Debug.WriteLine(sw.ElapsedMilliseconds);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    if (Path.GetExtension(saveFileDialog1.FileName) == ".esc")
                    {
                        sw.WriteLine(Categories.Text);
                        sw.WriteLine();
                        sw.WriteLine(SoundChanges.Text);
                        sw.WriteLine();
                        sw.WriteLine(Rewrite.Text);
                    }
                    else if (Path.GetExtension(saveFileDialog1.FileName) == ".lex")
                    {
                        sw.WriteLine(Input.Text);
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog1.FileNames)
                {
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        if (Path.GetExtension(fileName) == ".esc")
                        {
                            string state = "cats";
                            string nextLine = "";
                            Categories.Text = "";
                            SoundChanges.Text = "";
                            do
                            {
                                nextLine = sr.ReadLine();
                                if (nextLine != "")
                                {
                                    switch (state)
                                    {
                                        case "cats":
                                            Categories.Text += nextLine;
                                            Categories.Text += Environment.NewLine;
                                            break;
                                        case "changes":
                                            SoundChanges.Text += nextLine;
                                            SoundChanges.Text += Environment.NewLine;
                                            break;
                                        case "rewrite":
                                            Rewrite.Text += nextLine;
                                            Rewrite.Text += Environment.NewLine;
                                            break;
                                    }
                                }
                                else
                                {
                                    state = (state == "cats") ? "changes" : "rewrite";
                                }
                            } while (!sr.EndOfStream);
                            Categories.Text = Categories.Text.Trim();
                            SoundChanges.Text = SoundChanges.Text.Trim();
                            Rewrite.Text = Rewrite.Text.Trim();
                        }
                        else if (Path.GetExtension(fileName) == ".lex")
                        {
                            Input.Text = sr.ReadToEnd().Trim(Environment.NewLine.ToCharArray());
                        }
                    }
                }
            }
        }

        private void pythonEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PyEditor.Show();
        }

        private void declinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affixer.Show();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.X)
            {
                if (Categories.Focused)
                {
                    SoundChanges.Focus();
                }
                else
                {
                    Categories.Focus();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox.Show();
        }
    }
}

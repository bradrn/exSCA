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
using Microsoft.Scripting.Hosting;
using FastColoredTextBoxNS;

namespace exSCA
{
    public partial class PythonEditor : Form
    {
        Style BoldStyle = new TextStyle(Brushes.Black, Brushes.White, FontStyle.Bold);
        Style GreenStyle = new TextStyle(Brushes.Green, Brushes.White, FontStyle.Regular);
        Style BlueStyle = new TextStyle(Brushes.Blue, Brushes.White, FontStyle.Regular);

        public string PythonText
        {
            get
            {
                return PythonTextbox.Text;
            }
            set
            {
                PythonTextbox.Text = value;
            }
        }

        public PythonEditor()
        {
            InitializeComponent();
        }

        private void PythonTextbox_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            Range range = (sender as FastColoredTextBox).Range;
            range?.ClearStyle(BoldStyle, GreenStyle, BlueStyle);
            range?.SetStyle(GreenStyle, @"\#.*$", RegexOptions.Multiline);
            range?.SetStyle(BlueStyle, @"(\s|^)(False|None|True|and|as|assert|break|class|continue|def|del|elif|else|except|finally|for|from|global|if|import|in|is|lambda|nonlocal|not|or|pass|raise|return|try|while|with|yield)(\s|$)",
                RegexOptions.Multiline);
            range.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            range.SetStyle(GreenStyle, "(\"\"\".*\"\"\")|(\"\"\".*)", RegexOptions.Singleline);
            range.SetStyle(GreenStyle, "(\"\"\".*\"\"\")|(.*\"\"\")", RegexOptions.Singleline | RegexOptions.RightToLeft);

        }

        private void PythonTextbox_AutoIndentNeeded(object sender, AutoIndentEventArgs e)
        {
            if (Regex.IsMatch(e.LineText, ":$"))
            {
                e.ShiftNextLines = PythonTextbox.TabLength;
            }
            if (Regex.IsMatch(e.LineText, "return .*$"))
            {
                e.ShiftNextLines = -PythonTextbox.TabLength;
            }
        }

        private void PythonEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(PythonTextbox.Text);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    PythonTextbox.Text = sr.ReadToEnd();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exSCA
{
    public partial class Affixer : Form
    {
        public Affixer()
        {
            InitializeComponent();
        }

        public Affixer(Main host)
            : this()
        {
            Host = host;
        }

        public Main Host { get; set; }

        private void Affixer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            Notepad.NotepadHelper.ShowMessage(string.Join(Environment.NewLine, GetWords().ToArray()));
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Host.Input.Text += string.Join(Environment.NewLine, GetWords().ToArray());
            this.Close();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<string> GetWords()
        {
            List<string> words = new List<string>();
            List<string> stems = Stems.Text.Split(new string[] { }, StringSplitOptions.RemoveEmptyEntries).ToList();
            IEnumerable<List<string>> preslots = GetSlotAffixes(Prefixes.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList());
            IEnumerable<List<string>> sufslots = GetSlotAffixes(Suffixes.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList());
            foreach (string stem in stems)
            {
                IEnumerable<IEnumerable<string>> prefixcombs = CartesianProduct(preslots);
                IEnumerable<IEnumerable<string>> suffixcombs = CartesianProduct(sufslots);
                foreach (IEnumerable<string> prefixcomb in prefixcombs)
                {
                    foreach (IEnumerable<string> suffixcomb in suffixcombs)
                    {
                        words.Add(string.Concat(prefixcomb) + stem + string.Concat(suffixcomb));
                    }
                }
            }

            return words;
        }

        private IEnumerable<List<string>> GetSlotAffixes(List<string> slots)
        {
            foreach (string slot in slots)
            {
                List<string> affixes = new List<string>();
                foreach (string affix in slot.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (affix == "*") affixes.Add("");
                    else affixes.Add(affix);
                }
                yield return affixes;
            }
        }

        static IEnumerable<IEnumerable<T>> CartesianProduct<T>(IEnumerable<IEnumerable<T>> sequences)
        {
            IEnumerable<IEnumerable<T>> emptyProduct = new[] { Enumerable.Empty<T>() };
            return sequences.Aggregate(emptyProduct,
                (accumulator, sequence) =>
                from accseq in accumulator
                from item in sequence
                select accseq.Concat(new[] { item }));
        }
    }
}

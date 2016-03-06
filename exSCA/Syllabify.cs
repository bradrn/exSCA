using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace exSCA
{
    public partial class Main : Form
    {
        public string Syllabify(string word, string regex)
        {
            // AS MANY CONSONANTS AS POSSIBLE SHOULD BELONG TO THE NEXT SYLLABLE/BEGINNING OF THIS SYLLABLE!!!
            List<string> syllables = new List<string>();
            string _word = word;
            string _regex = "";
            foreach (char c in regex)
            {
                if (cats.ContainsKey(c))
                {
                    _regex += "[" + cats[c].Trim() + "]";
                }
                else
                {
                    _regex += c;
                }
            }
            while (true)
            {
                try
                {
                    MatchCollection syllableCollection = Regex.Matches(_word, _regex);
                    Match syllable = syllableCollection[0];
                    syllables.Add(syllable.Value);
                    _word = _word.Remove(syllable.Index, syllable.Length);
                    if (_word == "") break;
                }
                catch (Exception)
                {
                    syllables.Add(_word); break;
                }
            }
            return string.Concat(string.Join(".", syllables));
        }
    }
}
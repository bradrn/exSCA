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
        public string DoRewrite(string text, bool reversed = false)
        {
            if (Rewrite.Text == "") return text;
            string newText = text;
            foreach (string l in Rewrite.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (!reversed) newText = newText.Replace(l.Split('|')[0], l.Split('|')[1]);
                else newText = newText.Replace(l.Split('|')[1], l.Split('|')[0]);
            }
            return newText;
        }
    }
}
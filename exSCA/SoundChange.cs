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
        public string SoundChange(string soundChange, string text, out string rules)
        {
            rules = "";
            soundChange = Regex.Replace(soundChange, @"\s*\*.*$", "");
            string[] words = text.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                string word = words[wordIndex];
                for (int i = 0; i < word.Length; i++)
                {
                    int startIndex = 0;
                    int length = 0;
                    if (SatisfiesSoundChange(i, word, soundChange, out startIndex, out length))
                    {
                        rules += $"{soundChange} applies to '{word}' at {i}";
                        word = ReplaceSoundChange(word, soundChange, startIndex, length);
                        if (soundChange.Split('/')[0] == "" || soundChange.Split('/')[1].Contains('>'))
                        {
                            i++; // Otherwise it will degenerate into an endless sequence of AXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX...B
                        }
                    }
                }
                words[wordIndex] = word;
            }
            return string.Join(" ", words);
        }

        private bool SatisfiesSoundChange(int index, string word, string soundChange, out int startIndex, out int length)
        {
            string[] parts = soundChange.Split('/');
            int wordIndex = index;
            string state = "chars";
            string underscoreState = "chars";
            string _state = "";
            Stack<string> opt_stateStack = new Stack<string>();
            bool result = true;
            int _length = 0;
            int optDepth = 0;

            startIndex = -1;
            length = -1;

            try
            {
                foreach (char c in parts[2])
                {
                    if (_state == "add" && c == '#')        // See fourth line after "case '_':"
                    {
                        _state = ""; wordIndex++; startIndex++;
                    }
                    switch (state)
                    {
                        case "chars":
                            switch (c)
                            {
                                case '#':
                                    result &= ((wordIndex == 0) || (wordIndex == word.Length));
                                    break;
                                case '(':
                                    state = "optional";
                                    optDepth++;
                                    break;
                                case '[':
                                    state = "inlineGroup";
                                    break;
                                case '>':
                                    if (wordIndex == 0)
                                    {
                                        result = false;
                                    }
                                    else
                                    {
                                        result &= (word[wordIndex] == word[wordIndex - 1]);
                                    }
                                    wordIndex++;
                                    break;
                                case '_':
                                    startIndex = wordIndex;
                                    if (parts[0] == "")
                                    {
                                        length = 0;
                                        _state = "add";
                                        continue;
                                    }
                                    foreach (char r in parts[0])
                                    {
                                        switch (underscoreState)
                                        {
                                            case "chars":
                                                if (r == '[')
                                                {
                                                    _state = "";
                                                    underscoreState = "inlineGroup";
                                                }
                                                else if (cats.ContainsKey(r))
                                                {
                                                    bool _result = false;
                                                    foreach (char value in cats[r])
                                                    {
                                                        _result |= (word[wordIndex] == value);
                                                    }
                                                    result &= _result;
                                                    _length++;
                                                    wordIndex++;
                                                }
                                                else
                                                {
                                                    result &= (r == word[wordIndex]);
                                                    _length++;
                                                    wordIndex++;
                                                }
                                                break;
                                            case "inlineGroup":
                                                switch (r)
                                                {
                                                    case ']':
                                                        bool _result = false;
                                                        foreach (char p in _state) // p for possibility, since c is already taken
                                                        {
                                                            try
                                                            {
                                                                if (cats.ContainsKey(p))
                                                                {
                                                                    bool __result = false;
                                                                    foreach (char value in cats[p])
                                                                    {
                                                                        __result |= (word[wordIndex] == value);
                                                                    }
                                                                    _result |= __result;
                                                                }
                                                                else
                                                                {
                                                                    _result |= (word[wordIndex] == p);
                                                                }
                                                            }
                                                            catch (IndexOutOfRangeException) { }
                                                        }
                                                        result &= _result;
                                                        _length++;
                                                        wordIndex++;
                                                        underscoreState = "chars";
                                                        break;
                                                    default:
                                                        _state += r;
                                                        break;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                default:
                                    if (cats.ContainsKey(c))
                                    {
                                        bool _result = false;
                                        foreach (char value in cats[c])
                                        {
                                            _result |= (word[wordIndex] == value);
                                        }
                                        result &= _result;
                                    }
                                    else
                                    {
                                        result &= (c == word[wordIndex]);
                                    }
                                    wordIndex++;
                                    break;
                            }
                            break;
                        case "optional":
                            switch (c)
                            {
                                case '(':
                                    optDepth++;
                                    opt_stateStack.Push(_state);
                                    _state = "";
                                    break;
                                case ')':
                                    opt_stateStack.Push(_state);
                                    _state = "";
                                    if (wordIndex == word.Length)
                                    {
                                        continue;       // If the wordIndex is at the end of the word then the optional won't be satisfied anyway, so we can just move on.
                                                        // (The point of the optional is to move along as many characters as we need to, if we need to, and not to contribute
                                                        // to result)
                                    }
                                    int before_wordIndex = wordIndex;
                                    bool optionalIsSatisfied = true;
                                    foreach (char r in opt_stateStack.Peek())
                                    {
                                        if (cats.ContainsKey(r))
                                        {
                                            bool _result = false;
                                            foreach (char value in cats[r])
                                            {

                                                _result |= (word[wordIndex] == value);
                                            }
                                            optionalIsSatisfied &= _result;
                                        }
                                        else
                                        {
                                            optionalIsSatisfied &= (r == word[wordIndex]);
                                        }
                                        wordIndex++;
                                    }
                                    if (!optionalIsSatisfied)
                                    {
                                        wordIndex = before_wordIndex;
                                    }
                                    optDepth--;
                                    if (optDepth == 0)
                                    {
                                        state = "chars";
                                    }
                                    break;
                                default:
                                    _state += c;
                                    break;
                            }
                            break;
                        case "inlineGroup":
                            switch (c)
                            {
                                case ']':
                                    /*if (_state.Contains('#'))
                                    {
                                        _state = _state.Remove(_state.IndexOf('#'), 1) + '#';
                                    }*/
                                    bool _result = false;
                                    //bool first = true;
                                    foreach (char p in _state) // p for possibility, since c is already taken
                                    {
                                        try
                                        {
                                            if (cats.ContainsKey(p))
                                            {
                                                bool __result = false;
                                                foreach (char value in cats[p])
                                                {
                                                    __result |= (word[wordIndex] == value);
                                                }
                                                _result |= __result;
                                            }
                                            else if (p == '#')
                                            {
                                                _result |= ((wordIndex == 0) || (wordIndex == word.Length));
                                            }
                                            else
                                            {
                                                _result |= (word[wordIndex] == p);
                                            }
                                            /*if (_result && first && (p != '#'))
                                            {
                                                first = false;
                                                wordIndex++;
                                            }*/
                                        }
                                        catch (IndexOutOfRangeException) { }
                                    }
                                    result &= _result;
                                    state = "chars";
                                    _state = "";
                                    break;
                                default:
                                    _state += c;
                                    break;
                            }
                            break;
                    }
                    if (!result)
                    {
                        return false;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }

            try
            {
                if (parts.Length > 3)
                {
                    IEnumerable<string> exceptions = parts.Skip(3);
                    foreach (string part in exceptions)
                    {
                        int xtraWordIndex = (startIndex - part.Split('_')[0]
                                                              .Trim('#')
                                                              .Length);
                        if (xtraWordIndex < 0)
                        {
                            continue;
                        }
                        bool exceptionHolds = true;
                        foreach (char c in part)
                        {
                            switch (c)
                            {
                                case '#':
                                    exceptionHolds &= ((xtraWordIndex == 0) || (xtraWordIndex == word.Length));
                                    break;
                                case '_':
                                    xtraWordIndex += _length;
                                    break;
                                default:
                                    if (cats.ContainsKey(c))
                                    {
                                        bool _exceptionHolds = false;
                                        foreach (char value in cats[c])
                                        {
                                            _exceptionHolds |= (word[xtraWordIndex] == value);
                                        }
                                        exceptionHolds &= _exceptionHolds;
                                    }
                                    else
                                    {
                                        exceptionHolds &= (c == word[xtraWordIndex]);
                                    }
                                    xtraWordIndex++;
                                    break;
                            }
                        }
                        if (exceptionHolds)
                        {
                            return false;
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException) { }
            if (startIndex == -1)
            {
                return false;
            }
            length = _length;
            return result;
        }

        private string ReplaceSoundChange(string word, string soundChange, int index, int length)
        {
            string[] parts = soundChange.Split('/');
            string replacement = "";
            //string wordSubstr = "";
            int wordIndex = index;
            Queue<int> correspondences = new Queue<int>();
            bool log = true;
            foreach (char c in parts[0])
            {
                if (cats.ContainsKey(c) && log)
                {
                    correspondences.Enqueue(cats[c].IndexOf(word[wordIndex]));
                }
                else if (c == '[') log = false;
                else if (c == ']') log = true;
                //wordSubstr += word[wordIndex];
                if (log) wordIndex++;
            }
            if (parts[1] == @"\\")
            {
                return word.Remove(index, length).Insert(index, string.Concat(word.Substring(index, length).Reverse()));
            }
            foreach (char r in parts[1])
            {
                if (cats.ContainsKey(r) && correspondences.Count != 0)
                {
                    try
                    {
                        replacement += cats[r][correspondences.Dequeue()];
                    }
                    catch (Exception) { }
                }
                else if (r == '>')
                {
                    replacement += replacement[replacement.Length - 1];
                }
                else
                {
                    replacement += r;
                }
            }
            return word.Remove(index, length).Insert(index, replacement);
        }
    }
}

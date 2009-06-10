using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using WikiNotes.Interfaces;

namespace WikiNotes
{
    class Page : IPage
    {
        private const string DirName = "Pages";
        private const string home = "HomePage";
        private string _text;

        public Page()
        {
            this.Name = home; //Default
            Load();
        }

        public Page(string name)
        {
            this.Name = name;
            Load();
        }

        #region IPage Members

        public void Save()
        {
            // write to some file
            CreateSaveDirectory();
            File.WriteAllText(GetFilename(), this.Text);
        }

        public void Load()
        {
            try
            {
                this.Text = File.ReadAllText(GetFilename());
            }
            catch(FileNotFoundException)
            {
            }
            catch(DirectoryNotFoundException)
            {
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                CreateWikiWords(GetWikiWords());
                Save();
            }
        }

        public string Name { get; set; }

        private List<WikiWord> _wikiwords = new List<WikiWord>();

        public IEnumerable<WikiWord> WikiWords
        {
            get { return _wikiwords; }
        }

        private List<string> _backlinks = new List<string>();
        public IEnumerable<string> BackLinks
        {
            get
            {
                _backlinks.Clear();
                try
                {
                    foreach (string f in Directory.GetFiles(GetDirectory()))
                    {
                        //if (IsWikiWord(f.Name)) _backlinks.Add(f.Name);
                        _backlinks.Add(Path.GetFileName(f)); //TODO: filter this list to files that are actually wikiwords                                                
                    }
                }
                catch (DirectoryNotFoundException)
                { }

                return _backlinks;
            }
        }
        #endregion

        public WikiWord GetWikiWord(int location)
        {
            var word = (from WikiWord w in _wikiwords
                        where w.StartingPosition <= location &&
                              w.EndingPosition >= location
                        select w).FirstOrDefault();            

            return word;
        }

        private bool IsWikiWord(string word)
        {
            var ww = (from w in _wikiwords
                      where w.Word.Equals(word)
                      select w).FirstOrDefault();
            return !(ww == null);
        }

        private string GetFilename()
        {
            return Path.Combine(GetDirectory(), this.Name);
        }

        private string GetDirectory()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DirName);
        }

        private MatchCollection GetWikiWords()
        {
            Regex wordPattern = new Regex(@"\b[A-Z][a-z]+([A-Z][a-z]+)+\b", RegexOptions.Compiled | RegexOptions.Multiline);
            MatchCollection matches = wordPattern.Matches(this.Text);
            return matches;
        }

        private void CreateWikiWords(MatchCollection words)
        {
            _wikiwords.Clear();
            foreach (Match m in words)
            {
                int pos = m.Index; // GetFirstOccurence(m.Value);
                if (pos < 0) continue;

                WikiWord word = new WikiWord {StartingPosition = pos, Word = m.Value};
                _wikiwords.Add(word);
            }
        }

        private void CreateSaveDirectory()
        {
            string dir = GetDirectory();
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
        }
    }
}

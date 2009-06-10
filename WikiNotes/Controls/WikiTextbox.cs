using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WikiNotes.Controls
{
    class WikiTextbox : RichTextBox
    {
        public MatchCollection WikiWords()
        {
            Regex wordPattern = new Regex(@"\b[A-Z][a-z]+([A-Z][a-z]+)+\b", RegexOptions.Compiled);           
            MatchCollection matches = wordPattern.Matches(this.Text);
            return matches;
        }

        private void ProcessWikiWords(MatchCollection words)
        {
            ClearFormatting();
            foreach(Match m in words)
            {
                int pos = GetFirstOccurence(m.Value);
                FormatRange(pos, m.Value.Length);
            }
        }

        private int GetFirstOccurence(string word)
        {
            int pos = this.Text.IndexOf(word);
            return (pos > 0) ? pos - 1 : 0;
        }

        private void FormatRange(int startPos, int length)
        {
            int sel = this.SelectionStart;
            lock (this)
            {
                this.Select(startPos, (startPos + length));
                this.SelectionColor = Color.Blue;
            }
            this.SelectionStart = sel;
            this.SelectionLength = 0;
        }

        private void ClearFormatting()
        {
            string txt = this.Text;
            int sel = this.SelectionStart;
            this.Text = String.Empty;
            this.Text = txt;
            this.SelectionStart = sel;
        }

        private void SetCursor()
        {
             if (this.SelectionColor == Color.Blue)
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;           
        }

        protected override void OnTextChanged(EventArgs e)
        {
            ProcessWikiWords(this.WikiWords());
            base.OnTextChanged(e);         
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {            
            if(this.SelectionColor == Color.Blue)
            {
                MessageBox.Show("You clicked a wikiword");
            }
            base.OnMouseClick(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Control c = this.GetChildAtPoint(e.Location);
            base.OnMouseMove(e);
        }
    }
}

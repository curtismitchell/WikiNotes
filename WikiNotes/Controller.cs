using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WikiNotes.Interfaces;

namespace WikiNotes
{
    class Controller : IController
    {
        #region IController Members

        private IPage _model;
        public IPage Model
        {
            get { return _model; }
            set
            {
                _model = value;
                this.View.Content = _model.Text;                
                this.View.Title = _model.Name;
                this.View.BackLinks = this.Model.BackLinks;
                this.View.HighlightWikiWords(_model.WikiWords);
            }
        }

        public IWikiView View { get; set; }

        public void HandleContentChange(string content)
        {
            this.Model.Text = content;
            this.View.HighlightWikiWords(this.Model.WikiWords);
        }

        public void HandleWikiWordClick(int pos)
        {
            WikiWord word = this.Model.GetWikiWord(pos);
            if (word == null) return;

            this.Model = new Page(word.Word);
        }

        public void JumpToPage(string page)
        {
            //TODO: handle case where this page does not exist
            this.Model = new Page(page);
        }

        #endregion

        public void LinkClicked(string linkText)
        {
            if (Uri.IsWellFormedUriString(linkText, UriKind.Absolute))
                System.Diagnostics.Process.Start(linkText);
        }
    }
}

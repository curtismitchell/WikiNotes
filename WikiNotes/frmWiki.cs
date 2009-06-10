using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WikiNotes.Interfaces;

namespace WikiNotes
{
    partial class frmWiki : Form, IWikiView
    {
        private Controller controller;
        private bool isFormatting;
        private string prevPage;

        public frmWiki()
        {
            InitializeComponent();
            controller = new Controller();
            controller.View = this;
            controller.Model = new Page(); // Default page
        }

        public string Title
        {
            get { return this.Text; }
            set
            {
                if (!String.IsNullOrEmpty(this.Text))
                {
                    btnPreviousPage.Enabled = true;
                    prevPage = this.Text;
                }

                this.Text = value;
            }
        }

        public string Content
        {
            get { return rtbMain.Text; }
            set { rtbMain.Text = value; }
        }

        private IEnumerable<string> _backlinks;
        public IEnumerable<string> BackLinks
        {
            get
            {
                return _backlinks;
            }

            set
            {
                _backlinks = value;
            }
        }


        public void LoadPage(string name)
        {
            controller.Model = new Page(name);    
        }

        public void HighlightWikiWords(IEnumerable<WikiWord> words)
        {
            ClearFormatting();
            isFormatting = true;
            foreach (var w in words)
                FormatRange(w.StartingPosition, w.Length);
            isFormatting = false;
        }

        private void FormatRange(int startPos, int length)
        {            
            int sel = rtbMain.SelectionStart;
            int len = rtbMain.SelectionLength;

            rtbMain.Select(startPos, length);           
            rtbMain.SelectionColor = Color.Blue;
            
            rtbMain.Select(sel, len);
        }

        private void ClearFormatting()
        {
            string txt = rtbMain.Text;
            int sel = rtbMain.SelectionStart;
            rtbMain.Text = String.Empty;
            rtbMain.Text = txt;
            rtbMain.SelectionStart = sel;
        }

        private void rtbMain_TextChanged(object sender, EventArgs e)
        {
            if (isFormatting) return;
            controller.HandleContentChange(rtbMain.Text);
        }

        private void OnLinkClicked(object sender, LinkClickedEventArgs e)
        {
            controller.LinkClicked( e.LinkText );
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            if (rtbMain.SelectionColor == Color.Blue)
            {
                controller.HandleWikiWordClick(rtbMain.SelectionStart);
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            LoadPage(prevPage);
        }
    }
}

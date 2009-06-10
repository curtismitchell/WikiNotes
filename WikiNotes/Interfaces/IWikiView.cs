using System.Collections.Generic;

namespace WikiNotes.Interfaces
{
    interface IWikiView
    {
        string Content { get; set; }
        void HighlightWikiWords(IEnumerable<WikiWord> words);
        string Title { get; set; }
        IEnumerable<string> BackLinks { get; set; }
    }
}
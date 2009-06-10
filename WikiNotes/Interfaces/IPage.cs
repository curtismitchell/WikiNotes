using System.Collections.Generic;

namespace WikiNotes.Interfaces
{
    interface IPage
    {
        void Save();
        void Load();
        string Name { get; set; }
        string Text { get; set; }
        IEnumerable<WikiWord> WikiWords { get; }
        WikiWord GetWikiWord(int pos);
        IEnumerable<string> BackLinks { get; }
    }
}

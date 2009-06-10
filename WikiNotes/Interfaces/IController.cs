using System.Windows.Forms;

namespace WikiNotes.Interfaces
{
    interface IController
    {
        IPage Model { get; set; }
        IWikiView View { get; set; }

        void HandleContentChange(string content);
        void HandleWikiWordClick(int pos);
    }
}
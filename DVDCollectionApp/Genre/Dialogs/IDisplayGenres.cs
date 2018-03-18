using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gnr.Dialogs
{
    public interface IDisplayGenres
    {
        // properties
        DataGridView TheGrid { get; set; }
        string SelectedId { get; set; }
        string SelectedName { get; set; }


        // Events
        event EventHandler OnViewLoading;
        event EventHandler OnbtnAddGenreClick;
        event EventHandler OnbtnEditGenreClick;
        event EventHandler OnbtnCloseGenresClick;

        //methods
        void ShowView();
        void ShowAsDialog();
        void HideView();
        void CloseView();
        void ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i);

        // navigation
        AddGenre CreateAddGenreDlg();
        EditGenre CreateEditGenreDlg(int id, string name);
    }
}

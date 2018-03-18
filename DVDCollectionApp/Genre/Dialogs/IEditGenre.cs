using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gnr.Dialogs
{
    public interface IEditGenre
    {
        // properties
        string IdTextBox { get; set; }
        string NameTextBox { get; set; }

        // controls
        TextBox NameCtrl { get; }
        Control ActvCtrl { get; set; }

        // events
        event EventHandler OnViewLoading;
        event EventHandler OnEditbtnSaveClick;
        event EventHandler OnEditbtnDeleteClick;
        event EventHandler OnEditbtnClearClick;
        event EventHandler OnEditbtnCloseClick;

        //methods
        void ShowAsDialog();
        void HideView();
        void CloseView();
        DialogResult ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gnr.Dialogs
{
    public interface IAddGenre
    {
        // properties
        string NameTextBox { get; set; }

        // controls
        TextBox NameCtrl { get; }
        Control ActvCtrl { get; set; }

        // events
        event EventHandler OnViewLoading;
        event EventHandler OnAddbtnSaveClick;
        event EventHandler OnAddbtnClearClick;
        event EventHandler OnAddbtnCloseClick;

        //methods
        void ShowAsDialog();
        void HideView();
        void CloseView();
        void ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rt.Dialogs
{
    public interface IAddRating
    {
        // properties
        string MPAATextBox { get; set; }
        string DescripTextBox { get; set; }

        // controls
        TextBox MPAACtrl { get; }
        Control ActvCtrl { get; set; }

        // events
        event EventHandler OnViewLoading;
        event EventHandler OnAddbtnSaveClick;
        event EventHandler OnbtnClrMPAACodeClick;
        event EventHandler OnbtnClrDescripClick;
        event EventHandler OnAddbtnCloseClick;
        event EventHandler OntxtMPAACodeTextChanged;

        //methods
        void ShowAsDialog();
        void HideView();
        void CloseView();
        DialogResult ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i);
    }
}

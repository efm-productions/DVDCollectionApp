using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rt.Dialogs
{
    public interface IEditRating
    {
        // properties
        string IdTextBox { get; set; }
        string MPAATextBox { get; set; }
        string DescripTextBox { get; set; }

        // controls
        TextBox MPAACtrl { get; }
        Control ActvCtrl { get; set; }

        // events
        event EventHandler OnViewLoading;
        event EventHandler OnEditbtnSaveClick;
        event EventHandler OnEditbtnDeleteClick;
        event EventHandler OnbtnClrMPAACodeClick;
        event EventHandler OnbtnClrDescripClick;
        event EventHandler OnEditbtnCloseClick;
        event EventHandler OntxtMPAACodeTextChanged;

        //methods
        void ShowAsDialog();
        void HideView();
        void CloseView();
        DialogResult ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i);
    }
}

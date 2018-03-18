using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rt.Dialogs
{
    public interface IDisplayRatings
    {
        // properties
        DataGridView TheGrid { get; set; }
        string SelectedId { get; set; }
        string SelectedMPAA { get; set; }
        string SelectedDescrip { get; set; }


        // Events
        event EventHandler OnViewLoading;
        event EventHandler OnbtnAddRatingClick;
        event EventHandler OnbtnEditRatingClick;
        event EventHandler OnbtnCloseRatingsClick;

        //methods
        void ShowView();
        void ShowAsDialog();
        void HideView();
        void CloseView();
        DialogResult ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i);

        // navigation
        AddRating CreateAddRatingDlg();
        EditRating CreateEditRatingDlg(int id, string name, string descrip);
    }
}

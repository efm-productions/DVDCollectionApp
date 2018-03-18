using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using nspIcon.Dialogs;
using MyDVDs;

namespace nspIcon.Dialogs
{
    public interface IDisplayIcons
    {
        // properties
        string IdTextBox { get; set; }
        string IconsComboName { get; set; }
        Image IconspbxImage { get; set; }

        //controls
        ComboBox IconsCombo { get; }

        // events
        event EventHandler OnViewLoading;
        event EventHandler OnComboSelChg;
        event EventHandler OnAddBtnClicked;
        event EventHandler OnEditBtnClicked;
        event EventHandler OnDisplaybtnCloseClick;

        //methods
        void ShowView();
        void ShowAsDialog();
        void HideView();
        void CloseView();
        void ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i);

        // navigation
        AddIcon CreateAddView();
        EditIcon CreateEditView(int id, string name, Image img);
    }
}

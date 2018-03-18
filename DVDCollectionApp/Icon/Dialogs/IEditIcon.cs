using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nspIcon.Dialogs
{
    public interface IEditIcon
    {
        string IdTextBox { get; set; }
        string NameTextBox { get; set; }
        Image IconspbxImage { get; set; }
        PictureBox PicBox { get; }
        Button UndoPaste { get; }

        // events
        //event EventHandler OnEditViewLoading;
        event EventHandler OnEditbtnCancelClick;
        event EventHandler OnEditbtnPasteClick;
        event EventHandler OnEditbtnSaveClick;
        event EventHandler OnEditbtnClrClick;
        event EventHandler OnEditbtnUndoPasteClick;

        //methods
        void ShowAsDialog();
        void HideView();
        void CloseView();
        void ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i);

    }
}

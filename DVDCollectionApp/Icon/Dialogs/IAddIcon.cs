using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nspIcon.Dialogs
{
    public interface IAddIcon
    {
        string NameTextBox { get; set; }
        Image IconspbxImage { get; set; }
        PictureBox PicBox { get; }
        Button UndoPaste { get; }

        // events
        event EventHandler OnAddbtnCancelClick;
        event EventHandler OnAddbtnPasteClick;
        event EventHandler OnAddbtnSaveClick;
        event EventHandler OnAddbtnClrClick;
        event EventHandler OnAddbtnUndoPasteClick;

        //methods
        void ShowAsDialog();
        void HideView();
        void CloseView();
        void ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i);
    }
}

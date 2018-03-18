using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nspIcon.Dialogs
{
    public partial class AddIcon : Form, IAddIcon
    {
        // members

        // ctor
        public AddIcon()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnAddbtnCancelClick(this, EventArgs.Empty);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnAddbtnSaveClick(this, EventArgs.Empty);
        }

        private void btnPaste_Click_1(object sender, EventArgs e)
        {
            OnAddbtnPasteClick(this, EventArgs.Empty);
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            OnAddbtnClrClick(this, EventArgs.Empty);
        }

        private void btnUndoPaste_Click(object sender, EventArgs e)
        {
            OnAddbtnUndoPasteClick(this, EventArgs.Empty);
        }

        #region implement interface ======

        // properties
        public string NameTextBox
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public Image IconspbxImage
        {
            get { return pbxIcon.Image; }
            set { pbxIcon.Image = value; }
        }

        public PictureBox PicBox
        {
            get { return pbxIcon; }
        }

        public Button UndoPaste
        {
            get { return btnUndoPaste; }
        }

        // public events
        public event EventHandler OnAddbtnCancelClick;
        public event EventHandler OnAddbtnPasteClick;
        public event EventHandler OnAddbtnSaveClick;
        public event EventHandler OnAddbtnClrClick;
        public event EventHandler OnAddbtnUndoPasteClick;

        // methods
        public void ShowAsDialog()
        {
            ShowDialog();
        }

        public void HideView()
        {
            Hide();
        }

        public void CloseView()
        {
            Close();
        }

        public void ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i)
        {
            MessageBox.Show(message, title, b, i);
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyDVDs;

namespace nspIcon.Dialogs
{
    public partial class EditIcon : Form, IEditIcon
    {
        // members
        private int _id;
        private string _name;
        private Image _image;

        // ctor
        public EditIcon(int id, string name, Image image)
        {
            InitializeComponent();

            // set members
            _id = id;
            _name = name;
            _image = image;

            // set screen fields
            IdTextBox = _id.ToString();
            NameTextBox = _name;
            IconspbxImage = _image;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            OnEditbtnClrClick(this, EventArgs.Empty);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            OnEditbtnPasteClick(this, EventArgs.Empty);
        }

        private void btnUndoPaste_Click(object sender, EventArgs e)
        {
            OnEditbtnUndoPasteClick(this, EventArgs.Empty);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnEditbtnSaveClick(this, EventArgs.Empty);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnEditbtnCancelClick(this, EventArgs.Empty);

            //this.Close();
        }

        #region implement interface ======

        // properties
        public string IdTextBox
        {
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }

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
           get { return btnUndoPaste;  }
        }


        // public events
        //public event EventHandler OnViewLoading;
        public event EventHandler OnEditbtnCancelClick;
        public event EventHandler OnEditbtnPasteClick;
        public event EventHandler OnEditbtnSaveClick;
        public event EventHandler OnEditbtnClrClick;
        public event EventHandler OnEditbtnUndoPasteClick;

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

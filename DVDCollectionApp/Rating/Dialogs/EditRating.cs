using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rt.Dialogs
{
    public partial class EditRating : Form, IEditRating
    {
        // members
        private int _id;
        private string _MPAA;
        private string _Descrip;

        // ctor
        public EditRating(int id, string mpaa, string descrip)
        {
            InitializeComponent();

            // set members
            _id = id;
            _MPAA = mpaa;
            _Descrip = descrip;

            // set screen fields
            IdTextBox = _id.ToString();
            MPAATextBox = _MPAA;
            DescripTextBox = _Descrip;
        }

        #region events =====

        private void EditRating_Load(object sender, EventArgs e)
        {
            // raise event to presenter
            OnViewLoading(this, EventArgs.Empty);
        }

        private void btnClrMPAACode_Click(object sender, EventArgs e)
        {
            OnbtnClrMPAACodeClick(this, EventArgs.Empty);
        }

        private void btnClrDescription_Click(object sender, EventArgs e)
        {
            OnbtnClrDescripClick(this, EventArgs.Empty);
        }

        private void EditbtnSave_Click(object sender, EventArgs e)
        {
            OnEditbtnSaveClick(this, EventArgs.Empty);
        }

        private void EditbtnDelete_Click(object sender, EventArgs e)
        {
            OnEditbtnDeleteClick(this, EventArgs.Empty);
        }

        private void EditbtnClose_Click(object sender, EventArgs e)
        {
            OnEditbtnCloseClick(this, EventArgs.Empty);
        }

        private void txtMPAACode_TextChanged(object sender, EventArgs e)
        {
            if (OntxtMPAACodeTextChanged != null)
            {
                // handle MPAA txtbox keypresses
                OntxtMPAACodeTextChanged(this, EventArgs.Empty);
            }
        }

        #endregion

        #region implement interface

        // properties
        public string IdTextBox
        {
            get { return EdittxtId.Text; }
            set { EdittxtId.Text = value; }
        }

        public string MPAATextBox
        {
            get { return txtMPAACode.Text; }
            set { txtMPAACode.Text = value; }
        }

        public string DescripTextBox
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }

        // controls
        public TextBox MPAACtrl
        {
            get { return txtMPAACode; }
        }

        public Control ActvCtrl
        {
            get { return ActiveControl; }
            set { ActiveControl = value; }
        }

        // public public events
        public event EventHandler OnViewLoading;
        public event EventHandler OnEditbtnSaveClick;
        public event EventHandler OnEditbtnDeleteClick;
        public event EventHandler OnbtnClrMPAACodeClick;
        public event EventHandler OnbtnClrDescripClick;
        public event EventHandler OnEditbtnCloseClick;
        public event EventHandler OntxtMPAACodeTextChanged;

        //methods
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

        public DialogResult ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i)
        {
            DialogResult d = MessageBox.Show(message, title, b, i);

            return d;
        }


        #endregion
    }
}

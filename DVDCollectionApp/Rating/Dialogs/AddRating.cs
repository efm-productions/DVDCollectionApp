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
    public partial class AddRating : Form, IAddRating
    {
        public AddRating()
        {
            InitializeComponent();
        }

        #region events =====

        private void AddRating_Load(object sender, EventArgs e)
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

        private void AddbtnSave_Click(object sender, EventArgs e)
        {
            OnAddbtnSaveClick(this, EventArgs.Empty);
        }

        private void AddbtnClose_Click(object sender, EventArgs e)
        {
            OnAddbtnCloseClick(this, EventArgs.Empty);
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

        #region implement interface =====

        // properties
        public string MPAATextBox
        {
            get { return txtMPAACode.Text.ToUpper(); }
            set { txtMPAACode.Text = value.ToUpper(); }
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

        // events
        public event EventHandler OnViewLoading;
        public event EventHandler OnAddbtnSaveClick;
        public event EventHandler OnbtnClrMPAACodeClick;
        public event EventHandler OnbtnClrDescripClick;
        public event EventHandler OnAddbtnCloseClick;
        public event EventHandler OntxtMPAACodeTextChanged;

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

        public DialogResult ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i)
        {
            DialogResult d = MessageBox.Show(message, title, b, i);

            return d;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gnr.Dialogs
{
    public partial class AddGenre : Form, IAddGenre
    {
        public AddGenre()
        {
            InitializeComponent();
        }

        #region Events

        private void AddGenre_Load(object sender, EventArgs e)
        {
            OnViewLoading(this, EventArgs.Empty);
        }

        private void AddbtnSave_Click(object sender, EventArgs e)
        {
            OnAddbtnSaveClick(this, EventArgs.Empty);
        }

        private void AddbtnClose_Click(object sender, EventArgs e)
        {
            OnAddbtnCloseClick(this, EventArgs.Empty);
        }

        private void AddbtnClear_Click(object sender, EventArgs e)
        {
            OnAddbtnClearClick(this, EventArgs.Empty);
        }

        #endregion

        #region implement interface ======

        public string NameTextBox
        {
            get { return AddtxtName.Text; }
            set { AddtxtName.Text = value; }
        }

        public TextBox NameCtrl
        {
            get { return AddtxtName; }
        }

        public Control ActvCtrl
        {
            get { return ActiveControl; }
            set { ActiveControl = value; }
        }

        // events
        public event EventHandler OnViewLoading;
        public event EventHandler OnAddbtnSaveClick;
        public event EventHandler OnAddbtnCloseClick;
        public event EventHandler OnAddbtnClearClick;

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

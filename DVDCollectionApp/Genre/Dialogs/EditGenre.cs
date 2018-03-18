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
    public partial class EditGenre : Form, IEditGenre
    {
        // members
        private int _id;
        private string _name;

        // ctor
        public EditGenre(int id, string name)
        {
            InitializeComponent();

            // set members
            _id = id;
            _name = name;

            // set screen fields
            IdTextBox = _id.ToString();
            NameTextBox = _name;
        }
        #region events =====

        private void EditGenre_Load(object sender, EventArgs e)
        {
            OnViewLoading(this, EventArgs.Empty);
        }

        private void EditbtnSave_Click(object sender, EventArgs e)
        {
            OnEditbtnSaveClick(this, EventArgs.Empty);
        }

        private void EditbtnClose_Click(object sender, EventArgs e)
        {
            OnEditbtnCloseClick(this, EventArgs.Empty);
        }

        private void EditbtnClear_Click(object sender, EventArgs e)
        {
            OnEditbtnClearClick(this, EventArgs.Empty);
        }

        private void EditbtnDelete_Click(object sender, EventArgs e)
        {
            OnEditbtnDeleteClick(this, EventArgs.Empty);
        }

        #endregion

        #region implement interface =====

        // properties
        public string IdTextBox
        {
            get { return EdittxtId.Text; }
            set { EdittxtId.Text = value; }
        }

        public string NameTextBox
        {
            get { return EdittxtName.Text; }
            set { EdittxtName.Text = value; }
        }

        public TextBox NameCtrl
        {
            get { return EdittxtName; }
        }

        public Control ActvCtrl
        {
            get { return ActiveControl; }
            set { ActiveControl = value; }
        }

        // public events
        public event EventHandler OnViewLoading;
        public event EventHandler OnEditbtnSaveClick;
        public event EventHandler OnEditbtnDeleteClick;
        public event EventHandler OnEditbtnCloseClick;
        public event EventHandler OnEditbtnClearClick;

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

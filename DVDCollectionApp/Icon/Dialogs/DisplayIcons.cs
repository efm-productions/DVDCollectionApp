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
using nspIcon.Dialogs;
using nspIcon.Models;
using nspIcon.Presenters;

using AppM;

namespace nspIcon.Dialogs
{
    public partial class DisplayIcons : Form, IDisplayIcons
    {
        // members
        private DisplayIconsPresenter prs;

        // ctor
        public DisplayIcons()
        {
            InitializeComponent();

            // instantiate presenter
            prs = new DisplayIconsPresenter(this);
        }

        #region Events ===== 

        private void DisplayIcons_Load(object sender, EventArgs e)
        {
            // raise event for presenter
            OnViewLoading(this, EventArgs.Empty);
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // raise event for presenter
            OnComboSelChg(this, EventArgs.Empty);
        }

        private void cboName_KeyDown(object sender, KeyEventArgs e)
        {
            // make the comboBox readonly
            e.SuppressKeyPress = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //raise event for presenter
            OnAddBtnClicked(this, EventArgs.Empty);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //raise event for presenter
            ApplicationModel.TimesThru = 0;
            OnEditBtnClicked(this, EventArgs.Empty);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //raise event for presenter
            ApplicationModel.TimesThru = 0;
            OnDisplaybtnCloseClick(this, EventArgs.Empty);
        }

        #endregion

        #region implement interface ======

        // properties
        public string IdTextBox
        {
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }

        public string IconsComboName
        {
            get { return cboName.Text.Trim(); }
            set { cboName.Text = value; }
        }

        public Image IconspbxImage
        {
            get { return pbxIcon.Image; }
            set { pbxIcon.Image = value; }
        }

        //controls

        public ComboBox IconsCombo
        {
            get { return cboName; }
        }

        // public events
        public event EventHandler OnViewLoading;
        public event EventHandler OnComboSelChg;
        public event EventHandler OnAddBtnClicked;
        public event EventHandler OnEditBtnClicked;
        public event EventHandler OnDisplaybtnCloseClick;

        // methods
        public void ShowView()
        {
            Show();
        }

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

        // navigation
        public EditIcon CreateEditView(int id, string name, Image img)
        {
            return new EditIcon(id, name, img);
        }

        public AddIcon CreateAddView()
        {
            return new AddIcon();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DVDMC;
using MyDVDsMain.Presenters;
using nspIcon.Dialogs;
using Gnr.Dialogs;
using Rt.Dialogs;

namespace MyDVDsMain.Views
{
    public partial class DisplayMain : Form, IDisplayMainView
    {
        private int selectedBoxNumber = 1;
        private bool UserSelectionChange = true;

        // presenter member
        private DisplayMainPresenter prs;

        // ctor
        public DisplayMain()
        {
            InitializeComponent();

            // instantiate presenter
            prs = new DisplayMainPresenter(this);
        }

        #region Events & Methods =====================================

        private void DisplayMain_Load(object sender, EventArgs e)
        {
            // raise event for presenter
            OnViewLoad(this, EventArgs.Empty);
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            // raise event for presenter
            OnViewDetailesClicked(this, EventArgs.Empty);
        }

        private void grdAllContents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // raise event for presenter
            OnViewDetailesClicked(this, EventArgs.Empty);
        }

        private void btnSelectBoxNum_Click(object sender, EventArgs e)
        {
            OnSelectBoxViewEditClicked(this, EventArgs.Empty);
        }

        private void btnStartBox_Click(object sender, EventArgs e)
        {
            // raise event for presenter to handle
            OnStartNewBoxClicked(this, EventArgs.Empty);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // raise event for presenter to handle
            OnSearchTitleClicked(this, EventArgs.Empty);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // raise event for presenter to handle
            OnClearClicked(this, EventArgs.Empty);
        }

        private void btnIcons_Click(object sender, EventArgs e)
        {
            // raise event for presenter to handle
            OnbtnIconsClick(this, EventArgs.Empty);
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            // raise event for presenter to handle
            OnbtnGenresClick(this, EventArgs.Empty);
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            // raise event for presenter to handle
            OnbtnRatingsClick(this, EventArgs.Empty);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // menu events
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dVDIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // raise event for presenter to handle
            OnbtnIconsClick(this, EventArgs.Empty);
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // raise event for presenter to handle
            OnbtnGenresClick(this, EventArgs.Empty);
        }

        private void ratingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // raise event for presenter to handle
            OnbtnRatingsClick(this, EventArgs.Empty);
        }

        #endregion

        #region interface impelementation ============================

        // properties
        public string v_totalBoxes
        {
            get { return txtTotalBoxes.Text; }
            set { txtTotalBoxes.Text = value; }
        }

        public string v_totalCases
        {
            get { return txtTotalCases.Text; }
            set { txtTotalCases.Text = value; }
        }

        public string v_totalBoxsets
        {
            get { return txtTotalBoxsets.Text; }
            set { txtTotalBoxsets.Text = value; }
        }

        public string v_totalDiscs
        {
            get { return txtTotalDiscs.Text; }
            set { txtTotalDiscs.Text = value; }
        }

        public string v_totalContents
        {
            get { return txtTotalContents.Text; }
            set { txtTotalContents.Text = value; }
        }

        public DataGridView TheGrid
        {
            get { return grdAllContents; }
        }

        public string BoxNumbersComboText
        {
            get { return cboBoxNums.Text; }
            set { cboBoxNums.Text = value; }
        }

        public ComboBox BoxNumbersCombo
        {
            get { return cboBoxNums;  }
        }

        public Control ActvCtrl
        {
            get { return ActiveControl; }
            set { ActiveControl = value; }
        }

        public string SearchTextBox
        {
            get { return txtSearchTitle.Text; }
            set { txtSearchTitle.Text = value; }
        }

        // events
        public event EventHandler OnViewLoad;
        public event EventHandler OnViewDetailesClicked;
        public event EventHandler OnSelectBoxViewEditClicked;
        public event EventHandler OnStartNewBoxClicked;
        public event EventHandler OnSearchTitleClicked;
        public event EventHandler OnClearClicked;
        public event EventHandler OnbtnIconsClick;
        public event EventHandler OnbtnGenresClick;
        public event EventHandler OnbtnRatingsClick;

        public event EventHandler OnbtnCloseClick;

        // grid
        public DataGridView gridAllContents
        {
            get { return grdAllContents; }
            set { grdAllContents = value;  }
        }

        // methods
        public void ShowView()
        {
            Show();
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
        public DisplayIcons CreateDisplayIcons()
        {
            return new DisplayIcons();
        }

        public DisplayGenres CreateDisplayGenres()
        {
            return new DisplayGenres();
        }

        public DisplayRatings CreateDisplayRatings()
        {
            return new DisplayRatings();
        }

        #endregion
    }
}

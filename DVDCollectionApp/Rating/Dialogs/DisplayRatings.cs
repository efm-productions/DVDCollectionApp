using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rt.Presenter;

namespace Rt.Dialogs
{
    public partial class DisplayRatings : Form,IDisplayRatings
    {
        // members
        private DisplayRatingsPresenter prs;
        private string _selectedId;
        private string _selectedMPAA;
        private string _selectedDescrip;

        // ctor
        public DisplayRatings()
        {
            InitializeComponent();

            // instantiate presenter
            prs = new DisplayRatingsPresenter(this);
        }

        #region Events =====

        private void DisplayRatings_Load(object sender, EventArgs e)
        {
            // raise event to presenter
            OnViewLoading(this, EventArgs.Empty);
        }

        private void btnAddRating_Click(object sender, EventArgs e)
        {
            OnbtnAddRatingClick(this, EventArgs.Empty);
        }

        private void btnEditRating_Click(object sender, EventArgs e)
        {
            OnbtnEditRatingClick(this, EventArgs.Empty);
        }

        private void btnCloseRating_Click(object sender, EventArgs e)
        {
            OnbtnCloseRatingsClick(this, EventArgs.Empty);
        }

        private void grdAllRatings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OnbtnEditRatingClick(this, EventArgs.Empty);
        }

        #endregion

        #region implement interface =====

        // properties

        public DataGridView TheGrid
        {
            get { return grdAllRatings; }
            set { grdAllRatings = value; }
        }

        public string SelectedId
        {
            get { return _selectedId; }
            set { _selectedId = value; }
        }

        public string SelectedMPAA
        {
            get { return _selectedMPAA; }
            set { _selectedMPAA = value; }
        }

        public string SelectedDescrip
        {
            get { return _selectedDescrip; }
            set { _selectedDescrip = value; }
        }


        // Events
        public event EventHandler OnViewLoading;
        public event EventHandler OnbtnAddRatingClick;
        public event EventHandler OnbtnEditRatingClick;
        public event EventHandler OnbtnCloseRatingsClick;

        //methods
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

        public DialogResult ShowMessage(string message, string title, MessageBoxButtons b, MessageBoxIcon i)
        {
            DialogResult d = MessageBox.Show(message, title, b, i);

            return d;
        }

        // navigation
        public AddRating CreateAddRatingDlg()
        {
            return new AddRating();
        }

        public EditRating CreateEditRatingDlg(int id, string MPAA, string descrip)
        {
            return new EditRating(id, MPAA, descrip);
        }

        #endregion
    }
}

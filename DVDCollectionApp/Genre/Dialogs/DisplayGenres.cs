using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Gnr.Models;
using Gnr.Presenters;

namespace Gnr.Dialogs
{
    public partial class DisplayGenres : Form, IDisplayGenres
    {
        // members
        private DisplayGenresPresenter prs;
        private string _selectedId;
        private string _selectedName;

        // ctor
        public DisplayGenres()
        {
            InitializeComponent();

            // instantiate presenter
            prs = new DisplayGenresPresenter(this);
        }

        #region Events ===== 

        private void DisplayGenres_Load(object sender, EventArgs e)
        {
            // raise event for presenter
            OnViewLoading(this, EventArgs.Empty);
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            // raise event for presenter
            OnbtnAddGenreClick(this, EventArgs.Empty);
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            // raise event for presenter
            OnbtnEditGenreClick(this, EventArgs.Empty);
        }

        private void grdAllGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // raise event for presenter
            OnbtnEditGenreClick(this, EventArgs.Empty);
        }

        private void btnCloseGenres_Click(object sender, EventArgs e)
        {
            // raise event for presenter
            OnbtnCloseGenresClick(this, EventArgs.Empty);
        }

        #endregion

        #region implement interface ======

        // properties
        public string SelectedId
        {
            get { return _selectedId; }
            set { _selectedId = value; }
        }

        public string SelectedName
        {
            get { return _selectedName; }
            set { _selectedName = value; }
        }

        public DataGridView TheGrid
        {
            get { return grdAllGenres; }
            set { grdAllGenres = value; }
        }

        // events
        public event EventHandler OnViewLoading;
        public event EventHandler OnbtnAddGenreClick;
        public event EventHandler OnbtnEditGenreClick;
        public event EventHandler OnbtnCloseGenresClick;

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
        public AddGenre CreateAddGenreDlg()
        {
            return new AddGenre();
        }

        public EditGenre CreateEditGenreDlg(int id, string name)
        {
            return new EditGenre(id, name);
        }

        #endregion
    }
}

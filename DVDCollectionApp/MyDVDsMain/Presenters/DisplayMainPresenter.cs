using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDsMain.Views;
using MyDVDsMain.Models;

using nspIcon.Dialogs;
using Gnr.Dialogs;
using Rt.Dialogs;

using MyDVDs;

using System.Windows.Forms;

using nspIcon.Presenters;
using Gnr.Presenters;
using Rt.Presenter;

using AppM;

namespace MyDVDsMain.Presenters
{
    public class DisplayMainPresenter
    {
        private IDisplayMainView view;
        private IDisplayMainModel model;

        private string title = "";
        private string msg = "";
        private const string dblspc = "\n\n";

        private string dbq = ApplicationModel.DblQuot;

        // ctor
        public DisplayMainPresenter(IDisplayMainView v)
        {
            // set view & model objects
            this.view = v;
            this.model = new DisplayMainModel();

            // wireup view events
            WireUpViewEvents();
        }

        private void WireUpViewEvents()
        {
            view.OnViewLoad += HandleViewLoadEvent;
            view.OnViewDetailesClicked += HandleViewDetailsRequest;
            view.OnSelectBoxViewEditClicked += HandleViewEditBoxRequest;
            view.OnStartNewBoxClicked += HandleStartNewBoxRequest;
            view.OnSearchTitleClicked += HandleSearchTitleRequest;
            view.OnClearClicked += HandleClearSearchTitleTxtBoxRequest;
            view.OnbtnIconsClick += HandlebtnIconsClickRequest;
            view.OnbtnGenresClick += HandlebtnGenresClickRequest;
            view.OnbtnRatingsClick += HandlebtnRatingsClickRequest;
            view.OnbtnCloseClick += HandleOnbtnCloseClickRequest;
        }

        #region event handlers

        public void HandleViewLoadEvent(object sender, EventArgs e)
        {
            InitViewForDisplay();

            // set focus on combo box
            SetFocus();
        }

        private void HandleViewDetailsRequest(object sender, EventArgs e)
        {
            // is a row selected?
            if (view.TheGrid.SelectedRows.Count > 0)
            {
                ViewDetails();
                return;
            }

            // no - inform user to select a row
            title = "View Details";
            msg = "Select a row then click 'View Details' button!";
            view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void HandleViewEditBoxRequest(object sender, EventArgs e)
        {
            // get selected box #
            string bxn = view.BoxNumbersCombo.Text;

            // this is where we xfer control to EditBox

            title = "View/Edit Box";
            msg = "'Select a Box to View/Edit' was clicked for Box # " + bxn + "!";
            view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void HandleStartNewBoxRequest(object sender, EventArgs e)
        {
            // this is where we xfer control to AddBox

            title = "Start A New Box";
            msg = title + " was clicked!";
            view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void HandleClearSearchTitleTxtBoxRequest(object sender, EventArgs e)
        {
            view.SearchTextBox = "";
        }

        public void HandleSearchTitleRequest(object sender, EventArgs e)
        {
            msg = "";
            title = "Search for a Title";

            // is txtbox populated?
            if (string.IsNullOrWhiteSpace(view.SearchTextBox))
            {
                // no - inform user to enter a title
                msg = "Enter a title then click 'Search for a Title' button!";
                view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DoSearchTitle();
            }
        }

        private void HandlebtnIconsClickRequest(object sender, EventArgs e)
        {
            // xfer control to displayicons dialog
            ShowDisplayIconsDialog();

            // unhide this view
            ReShowThisView();
        }

        private void HandlebtnGenresClickRequest(object sender, EventArgs e)
        {
            // xfer control to displayicons dialog
            ShowDisplayGenresDialog();

            // unhide this view
            ReShowThisView();
        }

        private void HandlebtnRatingsClickRequest(object sender, EventArgs e)
        {
            // xfer control to displayicons dialog
            ShowDisplayRatingsDialog();

            // unhide this view
            ReShowThisView();
        }

        private void HandleOnbtnCloseClickRequest(object sender, EventArgs e)
        {
            view.CloseView();
        }

        #endregion

        #region methods =====

        public void InitViewForDisplay()
        {
            // load datagrid & set datasource
            LoadDataGrid();

            // customize grid cols & other properties
            CustomizeGrid();

            // populate the Statistics txtboxes
            SetStatistics();

            // populate cbo box
            PopulateBoxNumbersCbo();
        }

        public void LoadDataGrid()
        {
            // get data for the grid
            model.ChkContext();
            model.GetGridData();
            model.ClearContext();

            // set grid Datasource
            view.gridAllContents.DataSource = model.GridData;
        }

        public void CustomizeGrid()
        {
            view.gridAllContents.AutoGenerateColumns = false;

            // prevent 1st row default selection
            view.gridAllContents.Rows[0].Cells[0].Selected = false;

            // set col widths & hdings
            for (int i = 0; i < view.gridAllContents.ColumnCount; i++)
            {
                switch (i)
                {
                    case 0: // title
                        view.gridAllContents.Columns[i].Width = 573; break;
                    case 1: // year
                        view.gridAllContents.Columns[i].Width = 100; break;
                    case 5: // selection
                        {
                            view.gridAllContents.Columns[i].Width = 44;
                            // chg col hding
                            view.gridAllContents.Columns[i].HeaderText = "Sel";
                            break;
                        }
                    case 6: // id
                        {
                            view.gridAllContents.Columns[i].Width = 44;
                            // hide the content Id
                            view.gridAllContents.Columns[i].Visible = false;
                            break;
                        }
                    default: // box# case # disc #
                        view.gridAllContents.Columns[i].Width = 44; break;
                }
            }
        }

        public void SetStatistics()
        {
            // populate the statistics txtboxes
            model.ChkContext();
            model.GetStatistics();
            model.ClearContext();

            // copy stats from model to view
            CopyStatsToView();
        }

        public void CopyStatsToView()
        {
            view.v_totalBoxes = model.m_totalBoxes;
            view.v_totalCases = model.m_totalCases;
            view.v_totalBoxsets = model.m_totalBoxsets;
            view.v_totalDiscs = model.m_totalDiscs;
            view.v_totalContents = model.m_totalContents;
        }

        public void PopulateBoxNumbersCbo()
        {
            // get all box numbers fr model
            model.ChkContext();
            var boxesList = model.GetAllBoxNumbers();
            model.ClearContext();

            // set combo properties
            view.BoxNumbersCombo.ValueMember = "Id";
            view.BoxNumbersCombo.DisplayMember = "BoxNumber";
            view.BoxNumbersCombo.DataSource = boxesList;

            // set selection to 1st box #
            view.BoxNumbersCombo.Text = boxesList[0].ToString();

            // set focus on selection
            //view.BoxNumbersCombo.Focus();
        }

        private void ReShowThisView()
        {
            view.ShowView();

            // reset focus on combobox
            SetFocus();
        }

        private void SetFocus()
        {
            view.ActvCtrl = view.BoxNumbersCombo;
            view.BoxNumbersCombo.Focus();
        }

        private void ViewDetails()
        {
            string s = "";
            title = "View Selection Details";
            int rowindex = view.gridAllContents.CurrentRow.Index;

            int contentId = (int)view.gridAllContents.Rows[rowindex].Cells[6].Value;

            // make sure context is set
            model.ChkContext();

            var co = model.GetContentById(contentId);

            s += co.Title.Trim() + dblspc;
            s += "Year: " + co.Year.Trim() + dblspc;
            s += "Genre: " + co.Genre.Name.Trim() + dblspc;
            s += "Rating: " + co.Rating.MPAACode.Trim() + dblspc;
            s += "Cast: " + co.Cast.Trim() + dblspc;
            s += "Director: " + co.Director.Trim() + dblspc;
            s += "Notes: " + co.Notes.Trim() + dblspc;

            // dispose context
            model.ClearContext();

            view.ShowMessage(s, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DoSearchTitle()
        {
            title = "Search for a Title";

            string srchtitle = view.SearchTextBox;

            // do the search
            var coList = model.SearchForTitle(srchtitle);

            if (coList.Count() == 0)
            {
                string s = dbq + srchtitle + dbq + " not found!\n\n";
                view.ShowMessage(s, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DisplaySearchTitleResults(coList);
            }
        }

        private void DisplaySearchTitleResults(List<Content> coList)
        {
            title = "Search Results";
            msg = "";
            string boxnum;
            string casenum;
            string discnum;
            string srchtitle;

            foreach (var co in coList)
            {
                srchtitle = co.Title;
                discnum = co.Disc.DiscNumber.ToString();
                casenum = co.Disc.Case.CaseNumber.ToString();
                boxnum = co.Disc.Case.StorageBox.BoxNumber.ToString();

                msg += dbq + srchtitle + dbq + " is in Box " + boxnum + ": Case " + casenum + ": Disc " + discnum + dblspc;
            }

            msg += "\n";

            view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowDisplayIconsDialog()
        {
            // create dialog
            DisplayIcons nxtview = view.CreateDisplayIcons();

            // set dialog presenter
            DisplayIconsPresenter nxtprs = new DisplayIconsPresenter(nxtview);

            // set dialog positioning
            nxtview.StartPosition = FormStartPosition.CenterParent;

            // hide this view
            view.HideView();

            // child presenter starts dialog
            nxtprs.ShowAsDialog();
        }

        private void ShowDisplayGenresDialog()
        {
            // create dialog
            DisplayGenres nxtview = view.CreateDisplayGenres();

            // set dialog presenter
            DisplayGenresPresenter nxtprs = new DisplayGenresPresenter(nxtview);

            // set dialog positioning
            nxtview.StartPosition = FormStartPosition.CenterParent;

            // hide this view
            view.HideView();

            // child presenter starts dialog
            nxtprs.ShowAsDialog();
        }

        private void ShowDisplayRatingsDialog()
        {
            // create dialog
            DisplayRatings nxtview = view.CreateDisplayRatings();

            // set dialog presenter
            DisplayRatingsPresenter nxtprs = new DisplayRatingsPresenter(nxtview);

            // set dialog positioning
            nxtview.StartPosition = FormStartPosition.CenterParent;

            // hide this view
            view.HideView();

            // child presenter starts dialog
            nxtprs.ShowAsDialog();
        }

        #endregion
    }
}

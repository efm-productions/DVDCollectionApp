using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

using Gnr.Dialogs;
using Gnr.Models;
using MyDVDs;
using AppM;

namespace Gnr.Presenters
{
    public class DisplayGenresPresenter
    {
        // members
        private IDisplayGenres view;
        private IDisplayGenresModel model;

        private string title = "Display Genres";

        private string msg = "";
        private const string dblspc = "\n\n";

        private bool retriggered = false;
        private bool FromAdd = false;
        private bool FromEdit = false;
        private bool Initial = true;

        private static int selectedrow = 0;

        // ctor
        public DisplayGenresPresenter(IDisplayGenres v)
        {
            // set IView
            view = v;

            // instantiate IModel
            model = new DisplayGenresModel();

            // wireup view events
            SubscribeToViewEvents();
        }

        private void SubscribeToViewEvents()
        {
            view.OnViewLoading += HandleViewLoadingEvent;
            view.OnbtnAddGenreClick += HandlebtnAddGenreClickedEvent;
            view.OnbtnEditGenreClick += HandlebtnEditGenreClickedEvent;
            view.OnbtnCloseGenresClick += HandlebtnCloseGenresClickEvent;
        }

        #region event handlers =====

        public void HandleViewLoadingEvent(object sender, EventArgs e)
        {
            // initialization
            InitViewForDisplay();
        }

        private void HandlebtnAddGenreClickedEvent(object sender, EventArgs e)
        {
            if (ApplicationModel.TimesThru > 0)
            {
                ApplicationModel.TimesThru = 0;
                return;
            }

            ApplicationModel.TimesThru = 1;

            // xfer control to add dialog
            ApplicationModel.SaveOK = false;
            FromAdd = true;

            // start Add dialog
            ShowAddDialog();

            if (ApplicationModel.SaveOK)
            {
                // new record inserted - refresh view
                InitViewForDisplay();

                // select the row just added
                int searchValue = ApplicationModel.AddedId;
                selectedrow = -1;
                foreach (DataGridViewRow row in view.TheGrid.Rows)
                {
                    if (row.Cells[0].Value.Equals(searchValue))
                    {
                        selectedrow = row.Index;
                        break;
                    }
                }
                view.TheGrid.Rows[selectedrow].Cells[1].Selected = true;
            }
            else
            {
                FromAdd = false;

                // reset selected row focus
                view.TheGrid.Rows[selectedrow].Cells[1].Selected = true;
            }

            // unhide this view
            view.ShowView();
        }

        private void HandlebtnEditGenreClickedEvent(object sender, EventArgs e)
        {
            // is a row selected?
            if (view.TheGrid.SelectedRows.Count < 1)
            {
                // no - inform user to select a row
                msg = "Select a row to Edit!";
                view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // set selected index
            selectedrow = view.TheGrid.CurrentRow.Index;

            // assign selected row to member properties
            SetMemberValues();

            if (ApplicationModel.TimesThru > 0)
            {
                ApplicationModel.TimesThru = 0;
                return;
            }

            ApplicationModel.TimesThru = 1;

            // xfer control to edit dialog
            ApplicationModel.NoChanges = true;
            FromEdit = true;

            // start Edit dialog
            ShowEditDialog();

            if (!ApplicationModel.NoChanges)
            {
                // changes made
                if (ApplicationModel.DltOK)
                {
                    selectedrow--;
                    if (selectedrow < 0)
                    {
                        selectedrow = 0;
                    }
                }

                // refresh view
                InitViewForDisplay();
            }
            else
            {
                FromEdit = false;
            }

            // reset selected row focus
            view.TheGrid.Rows[selectedrow].Cells[1].Selected = true;

            // unhide this view
            view.ShowView();
        }

        private void HandlebtnCloseGenresClickEvent(object sender, EventArgs e)
        {
            view.CloseView();
        }

        #endregion

        #region private methods =====

        public void InitViewForDisplay()
        {
            // load datagrid & set datasource
            LoadDataGrid();

            // customize grid cols & other properties
            CustomizeGrid();
        }

        public void SetMemberValues()
        {
            int si = (int)view.TheGrid.Rows[selectedrow].Cells[0].Value;

            view.SelectedId = si.ToString();
            view.SelectedName = (string)view.TheGrid.Rows[selectedrow].Cells[1].Value;
        }

        public void LoadDataGrid()
        {
            // get data for the grid
            model.ChkContext();
            model.GetGridData();
            model.ClearContext();

            // set grid Datasource
            view.TheGrid.DataSource = model.GridData;
        }

        public void CustomizeGrid()
        {
            view.TheGrid.AutoGenerateColumns = false;

            // prevent 1st row default selection
            view.TheGrid.Rows[0].Cells[1].Selected = false;

            // set col widths & Hdings
            view.TheGrid.Columns[0].Width = 44;
            view.TheGrid.Columns[0].Visible = false;
            view.TheGrid.Columns[1].Width = 573;
            view.TheGrid.Columns[1].HeaderText = "Genres";

        }

        public void ShowView()
        {
            // children use this
            view.ShowView();
        }

        public void ShowAsDialog()
        {
            // parent uses this
            view.ShowAsDialog();
        }

        private void ShowAddDialog()
        {
            AddGenre nxtview = view.CreateAddGenreDlg();
            AddGenrePresenter nxtprs = new AddGenrePresenter(nxtview);
            nxtview.StartPosition = FormStartPosition.CenterParent;
            view.HideView();
            nxtprs.ShowAsDialog();
        }

        private void ShowEditDialog()
        {
            FromEdit = true;
            EditGenre nxtview = view.CreateEditGenreDlg(Int32.Parse(view.SelectedId), view.SelectedName);
            EditGenrePresenter nxtprs = new EditGenrePresenter(nxtview);
            nxtview.StartPosition = FormStartPosition.CenterParent;
            view.HideView();
            nxtprs.ShowAsDialog();
        }

        #endregion
    }
}

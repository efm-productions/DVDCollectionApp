using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

using Gnr.Dialogs;
using Gnr.Models;

using AppM;

namespace Gnr.Presenters
{
    public class EditGenrePresenter
    {
        private IEditGenre view;
        private IEditGenreModel model;

        private string title = "Edit a Genre";

        private string msg = "";
        private const string dblspc = "\n\n";

        private bool ChangesFound = false;

        private bool NameFailed = false;

        private string origId;
        private string origName;

        private string chgName;

        // ctor
        public EditGenrePresenter(IEditGenre v)
        {
            // set IView
            view = v;

            // instantiate IModel
            model = new EditGenreModel();

            // wireup view events
            SubscribeToViewEvents();

            // save original view values
            origId = view.IdTextBox;
            origName = view.NameTextBox;

            // set model to orig values
            model.M_GenreId = origId;
            model.M_GenreName = origName;

            ApplicationModel.NoChanges = true;
        }

        private void SubscribeToViewEvents()
        {
            view.OnViewLoading += HandleViewLoadingEvent;
            view.OnEditbtnSaveClick += HandlebtnSaveClickEvent;
            view.OnEditbtnDeleteClick += HandlebtnDeleteClickEvent;
            view.OnEditbtnClearClick += HandlebtnClearClickEvent;
            view.OnEditbtnCloseClick += HandlebtnCloseClickEvent;
        }

        #region event handlers =====

        private void HandleViewLoadingEvent(object sender, EventArgs e)
        {
            // set focus on text box
            view.ActvCtrl = view.NameCtrl;
            view.NameCtrl.Focus();
        }

        private void HandlebtnClearClickEvent(object sender, EventArgs e)
        {
            view.NameTextBox = "";
        }

        private void HandlebtnSaveClickEvent(object sender, EventArgs e)
        {
            ApplicationModel.SaveOK = false;

            GetScreenValues();

            ValidateScreenValues();
            if (NameFailed)
            {
                view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CheckForChanges();
            if (!ChangesFound)
            {
                view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateModel();
            msg = "Save Successful!";
            view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            ApplicationModel.SaveOK = true;

            // close this view on a good save
            view.CloseView();
        }

        private void HandlebtnDeleteClickEvent(object sender, EventArgs e)
        {
            msg = "Are You sure?";
            var result = view.ShowMessage(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var rc = DeleteModel();

                if(rc == 1)
                {
                    msg = "Delete Successful!";
                    view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ApplicationModel.DltOK = true;

                    // close this view on a good delete
                    view.CloseView();
                }
            }
            else
            {
                msg = "Delete Cancelled!";
                view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void HandlebtnCloseClickEvent(object sender, EventArgs e)
        {
            view.CloseView();
        }

        #endregion

        #region private methods =====

        private void GetScreenValues()
        {
            chgName = view.NameTextBox;
            chgName.TrimStart();
            chgName.TrimEnd();
        }

        private void ValidateScreenValues()
        {
            NameFailed = false;

            if (string.IsNullOrWhiteSpace(chgName))
            {
                // failed validation
                NameFailed = true;
                msg = "Please enter a Genre Name!\n\n";
            }
        }

        private void CheckForChanges()
        {
            ChangesFound = false;

            if (chgName != origName)
            {
                ChangesFound = true;
                model.M_GenreName = chgName;
            }
            else
            {
                msg = "Nothing was changed!\n\n";
            }
        }

        private void UpdateModel()
        {
            // set model properties
            model.M_GenreId = view.IdTextBox;
                
            // get orig Genre
            model.ChkContext();
            var origgnr = model.GetGenreById();

            // do the update
            var newgnr = model.SaveGenre();
            model.ClearContext();

            ApplicationModel.NoChanges = false;
        }

        private int DeleteModel()
        {
            // set model properties
            model.M_GenreId = view.IdTextBox;

            // do the delete
            var rc = model.DeleteGenre();
            model.ClearContext();

            ApplicationModel.NoChanges = false;

            return rc;
        }

        // parent presenter uses this
        public void ShowAsDialog()
        {
            view.ShowAsDialog();
        }
        #endregion
    }
}
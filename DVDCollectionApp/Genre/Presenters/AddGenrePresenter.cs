using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gnr.Models;
using Gnr.Dialogs;

using AppM;
using System.Windows.Forms;
using System.Drawing;

namespace Gnr.Presenters
{
    public class AddGenrePresenter
    {
        private IAddGenre view;
        private IAddGenreModel model;

        private string title = "Add a Genre";

        private string msg = "";
        private const string dblspc = "\n\n";

        private bool ChangesFound = false;

        private bool NameFailed = false;

        private string chgName;

        // ctor
        public AddGenrePresenter(IAddGenre v)
        {
            // set IView
            view = v;

            //instantiate IModel
            model = new AddGenreModel();

            // wireup view events
            SubscribeToViewEvents();

            // init model
            model.M_GenreId = "";
            model.M_GenreName = "";

            ApplicationModel.NoChanges = true;
        }

        private void SubscribeToViewEvents()
        {
            view.OnViewLoading += HandleViewLoadingEvent;
            view.OnAddbtnSaveClick += HandleAddbtnSaveClickEvent;
            view.OnAddbtnClearClick += HandlebtnClearClickEvent;
            view.OnAddbtnCloseClick += HandleAddbtnCloseClickEvent;
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

        private void HandleAddbtnSaveClickEvent(object sender, EventArgs e)
        {
            ApplicationModel.SaveOK = false;

            GetScreenValues();

            ValidateScreenValues();
            if (NameFailed)
            {
                view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddModel();
            msg = "Add Successful!";
            view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            ApplicationModel.SaveOK = true;

            // close this view on a good save
            view.CloseView();
        }

        private void HandleAddbtnCloseClickEvent(object sender, EventArgs e)
        {
            view.CloseView();
        }

        #endregion

        #region private methods =====

        private void GetScreenValues()
        {
            // set presenter variables
            chgName = view.NameTextBox;
            chgName.TrimStart();
            chgName.TrimEnd();
        }

        private void ValidateScreenValues()
        {
            NameFailed = false;
            msg = "";

            if (string.IsNullOrWhiteSpace(chgName))
            {
                // failed validation
                NameFailed = true;
                msg = "Please enter a Genre!\n\n";

                return;
            }

            if (model.IsGenreDuplicate(chgName))
            {
              NameFailed = true;
              msg = "This Genre already in database!\n\n";

                return;
            }

            // set model property
            model.M_GenreName = chgName;
        }

        private void AddModel()
        {
            // do the update
            model.ChkContext();
            var newgnr = model.AddGenre();
            model.ClearContext();

            ApplicationModel.AddedId = newgnr.Id;
            ApplicationModel.NoChanges = false;
        }

        // parent presenter uses this
        public void ShowAsDialog()
        {
            view.ShowAsDialog();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Rt.Models;
using Rt.Dialogs;

using AppM;
using System.Windows.Forms;
using System.Drawing;

namespace Rt.Presenter
{
    public class AddRatingPresenter
    {
        private IAddRating view;
        private IAddRatingModel model;

        private string title = "Add a Rating";

        private string msg = "";
        private const string dblspc = "\n\n";

        private bool ChangesFound = false;

        private bool MPAAFailed = false;
        private bool DescripFailed = false;

        private string chgMPAA;
        private string chgDescrip;

        // ctor
        public AddRatingPresenter(IAddRating v)
        {
            // set IView
            view = v;

            //instantiate IModel
            model = new AddRatingModel();

            // wireup view events
            SubscribeToViewEvents();

            // init model
            model.M_RatingId = "";
            model.M_RatingMPAA = "";
            model.M_RatingDescrip = "";

            ApplicationModel.NoChanges = true;
        }

        private void SubscribeToViewEvents()
        {
            view.OnViewLoading += HandleViewLoadingEvent;
            view.OnAddbtnSaveClick += HandleAddbtnSaveClickEvent;
            view.OnbtnClrMPAACodeClick += HandlebtnClrMPAACodeClickEvent;
            view.OnbtnClrDescripClick += HandlebtnClrDescripClickEvent;
            view.OnAddbtnCloseClick += HandleAddbtnCloseClickEvent;
            view.OntxtMPAACodeTextChanged += HandleOntxtMPAACodeTextChangedEvent;
        }

        #region event handlers =====


        private void HandleViewLoadingEvent(object sender, EventArgs e)
        {
            // set focus on text box
            view.ActvCtrl = view.MPAACtrl;
            view.MPAACtrl.Focus();
        }

        private void HandlebtnClrMPAACodeClickEvent(object sender, EventArgs e)
        {
            view.MPAATextBox = "";
        }


        private void HandlebtnClrDescripClickEvent(object sender, EventArgs e)
        {
            view.DescripTextBox = "";
        }

        private void HandleAddbtnSaveClickEvent(object sender, EventArgs e)
        {
            ApplicationModel.SaveOK = false;

            GetScreenValues();

            ValidateMPAA();
            if (MPAAFailed)
            {
                view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ValidateDescrip();
            if (DescripFailed)
            {
                view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // set model properties
            model.M_RatingMPAA = chgMPAA;
            model.M_RatingDescrip = chgDescrip;

            AddModel();
            msg = "Add Successful!";
            view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            ApplicationModel.SaveOK = true;

            // close this view on a good save
            view.CloseView();
        }

        private void HandleOntxtMPAACodeTextChangedEvent(object sender, EventArgs e)
        {
            // force MPAA to uppercase
            view.MPAATextBox = view.MPAATextBox.ToUpper();
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
            chgMPAA = view.MPAATextBox;
            chgMPAA.TrimStart();
            chgMPAA.TrimEnd();

            chgDescrip = view.DescripTextBox;
            chgDescrip.TrimStart();
            chgDescrip.TrimEnd();
        }

        private void ValidateMPAA()
        {
            MPAAFailed = false;
            msg = "";

            if (string.IsNullOrWhiteSpace(chgMPAA))
            {
                // failed validation
                MPAAFailed = true;
                msg = "MPAA Rating Code Required!\n\n";

                ValidateDescrip();

                return;
            }

            if (model.IsRatingDuplicate(chgMPAA))
            {
                MPAAFailed = true;
                msg = "This MPAA Rating Code is already in database!\n\n";
            }
        }

        private void ValidateDescrip()
        {
            DescripFailed = false;

            if (string.IsNullOrWhiteSpace(chgDescrip))
            {
                // failed validation
                DescripFailed = true;
                msg += "Description Required!\n\n";
            }
        }

        private void AddModel()
        {
            // do the update
            model.ChkContext();
            var newrtg = model.AddRating();
            model.ClearContext();

            ApplicationModel.AddedId = newrtg.Id;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

using Rt.Models;
using Rt.Dialogs;

using AppM;

namespace Rt.Presenter
{
    public class EditRatingPresenter
    {
        private IEditRating view;
        private IEditRatingModel model;

        private string title = "Edit a Rating";

        private string msg = "";
        private const string dblspc = "\n\n";

        private bool ChangesFound = false;

        private bool MPAAFailed = false;
        private bool DescripFailed = false;

        private string origId;
        private string origMPAA;
        private string origDescrip;

        private string chgMPAA;
        private string chgDescrip;

        // ctor
        public EditRatingPresenter(IEditRating v)
        {
            // set IView
            view = v;

            // instantiate IModel
            model = new EditRatingModel();

            // wireup view events
            SubscribeToViewEvents();

            // save original view values
            origId = view.IdTextBox;
            origMPAA = view.MPAATextBox;
            origDescrip = view.DescripTextBox;

            // set model to orig values
            model.M_RatingId = origId;
            model.M_RatingMPAA = origMPAA;

            ApplicationModel.NoChanges = true;
        }

        private void SubscribeToViewEvents()
        {
            view.OnViewLoading += HandleViewLoadingEvent;
            view.OnEditbtnSaveClick += HandlebtnSaveClickEvent;
            view.OnEditbtnDeleteClick += HandlebtnDeleteClickEvent;
            view.OnbtnClrMPAACodeClick += HandlebtnClrMPAACodeClickEvent;
            view.OnbtnClrDescripClick += HandlebtnClrDescripClickEvent;
            view.OnEditbtnCloseClick += HandlebtnCloseClickEvent;
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

        private void HandlebtnSaveClickEvent(object sender, EventArgs e)
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

                if (rc == 1)
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

        private void HandleOntxtMPAACodeTextChangedEvent(object sender, EventArgs e)
        {
            // force MPAA to uppercase
            view.MPAATextBox = view.MPAATextBox.ToUpper();
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

            if (string.IsNullOrWhiteSpace(chgMPAA))
            {
                // failed validation
                DescripFailed = true;
                msg += "Description Required!\n\n";
            }
        }

        private void UpdateModel()
        {
            // set model properties
            model.M_RatingMPAA = chgMPAA;
            model.M_RatingDescrip = chgDescrip;

            // get orig Rating
            model.ChkContext();
            var origrtg = model.GetRatingById();

            // do the update
            var newrtg = model.SaveRating();
            model.ClearContext();

            ApplicationModel.NoChanges = false;
        }

        private int DeleteModel()
        {
            // set model properties
            model.M_RatingId = view.IdTextBox;

            // do the delete
            var rc = model.DeleteRating();
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

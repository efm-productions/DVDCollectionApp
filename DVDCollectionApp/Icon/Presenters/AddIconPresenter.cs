using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nspIcon.Dialogs;
using nspIcon.Models;

using AppM;
using System.Windows.Forms;
using System.Drawing;

namespace nspIcon.Presenters
{
    class AddIconPresenter
    {
        private IAddIcon view;
        private IAddIconModel model;

        private string title = "Add an Icon";

        private string msg = "";
        private const string dblspc = "\n\n";

        private bool GotImageFromClipboard = false;
        private bool ChangesFound = false;

        private bool NameFailed = false;
        private bool ImageFailed = false;
        private bool ImagePasted = false;

        private string chgName;
        private Image chgImage;

        // ctor
        public AddIconPresenter(IAddIcon v)
        {
            // set IView
            view = v;

            //instantiate IModel
            model = new AddIconModel();

            // wireup view events
            SubscribeToViewEvents();

            // init model
            model.DvId = "";
            model.DvName = "";
            model.DvIcon = null;

            view.UndoPaste.Enabled = false;

            ApplicationModel.NoChanges = true;
        }

        private void SubscribeToViewEvents()
        {
            view.OnAddbtnPasteClick += HandlebtnPasteClick;
            view.OnAddbtnCancelClick += HandleAddbtnCancelClick;
            view.OnAddbtnSaveClick += HandleAddbtnSaveClick;
            view.OnAddbtnClrClick += HandlebtnClrClick;
            view.OnAddbtnUndoPasteClick += HandlebtnUndoPasteClick;
        }

        #region event handlers =====

        private void HandlebtnPasteClick(object sender, EventArgs e)
        {
            GotImageFromClipboard = GetImageFromClipboard();

            if (!GotImageFromClipboard)
            {
                msg = "Clipboard is empty! Please Copy Image to clipboard.";
                view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void HandlebtnClrClick(object sender, EventArgs e)
        {
            view.NameTextBox = "";
        }

        private void HandlebtnUndoPasteClick(object sender, EventArgs e)
        {
            view.IconspbxImage = null;
            view.UndoPaste.Enabled = false;
        }

        private void HandleAddbtnSaveClick(object sender, EventArgs e)
        {
            ApplicationModel.SaveOK = false;

            GetScreenValues();

            ValidateScreenValues();
            if (NameFailed || ImageFailed)
            {
                view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CheckForChanges();
            if (!ChangesFound)
            {
                msg = "Nothing entered!\n\n";
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

        private void HandleAddbtnCancelClick(object sender, EventArgs e)
        {
            view.CloseView();
        }

        #endregion

        #region private methods =====

        private bool GetImageFromClipboard()
        {
            if (Clipboard.ContainsImage())
            {
                ImagePasted = true;
                view.PicBox.SizeMode = PictureBoxSizeMode.AutoSize;
                view.IconspbxImage = Clipboard.GetImage();

                view.UndoPaste.Enabled = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GetScreenValues()
        {
            chgName = view.NameTextBox;
            chgName.TrimStart();
            chgName.TrimEnd();

            chgImage = view.IconspbxImage;
        }

        private void ValidateScreenValues()
        {
            NameFailed = false;
            ImageFailed = false;
            msg = "";

            if (string.IsNullOrWhiteSpace(chgName))
            {
                // failed validation
                NameFailed = true;
                msg = "Please enter an Icon Name!\n\n";
            }

            bool isNullOrEmpty = view.PicBox == null || chgImage == null;
            if (isNullOrEmpty)
            {
                // failed validation
                ImageFailed = true;
                msg += "Please paste an Image into the picture box!\n";
            }
        }

        private void CheckForChanges()
        {
            ChangesFound = false;
            msg = "";

            if (chgName != "" && chgImage != null)
            {
                ChangesFound = true;
                model.DvName = chgName;
                model.DvIcon = chgImage;
            }
            else
            {
                // failed validation
                msg += "Both fields are required!\n";
            }
        }

        private void AddModel()
        {

            // do the update
            model.ChkContext();
            var newdvi = model.AddDVDIcon();
            model.ClearContext();

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

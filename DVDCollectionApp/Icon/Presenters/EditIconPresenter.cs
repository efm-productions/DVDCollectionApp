using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using nspIcon.Dialogs;
using nspIcon.Models;

using AppM;

namespace nspIcon.Presenters
{
    public class EditIconPresenter
    {
        private IEditIcon view;
        private IEditIconModel model;

        private string title = "Edit an Icon";

        private string msg = "";
        private const string dblspc = "\n\n";

        private bool GotImageFromClipboard = false;
        private bool ChangesFound = false;

        private bool NameFailed = false;
        private bool ImageFailed = false;
        private bool ImagePasted = false;

        private bool samename = false;
        private bool sameimages = false;

        private string origId;
        private string origName;
        private Image origImage;

        private string chgName;
        private Image chgImage;

        private Image previmage;

        // ctor
        public EditIconPresenter(IEditIcon v)
        {
            // set IView
            view = v;

            // instantiate IModel
            model = new EditIconModel();

            // wireup view events
            SubscribeToViewEvents();

            // save original view values
            origId = view.IdTextBox;
            origName = view.NameTextBox;
            origImage = view.IconspbxImage;

            // set model to orig values
            model.DvId = origId;
            model.DvName = origName;
            model.DvIcon = origImage;

            view.UndoPaste.Enabled = false;

            ApplicationModel.NoChanges = true;
        }

        private void SubscribeToViewEvents()
        {
            view.OnEditbtnPasteClick += HandlebtnPasteClick;
            view.OnEditbtnCancelClick += HandlebtnCancelClick;
            view.OnEditbtnSaveClick += HandlebtnSaveClick;
            view.OnEditbtnClrClick += HandlebtnClrClick;
            view.OnEditbtnUndoPasteClick += HandlebtnUndoPasteClick;
        }

        #region event handlers =====


        private void HandlebtnClrClick(object sender, EventArgs e)
        {
            view.NameTextBox = "";
        }

        private void HandlebtnPasteClick(object sender, EventArgs e)
        {
            GotImageFromClipboard = GetImageFromClipboard();

            if(!GotImageFromClipboard)
            {
                if (msg == "")
                {
                    msg = "Clipboard is empty! Please Copy Image to clipboard.";
                }

                view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HandlebtnUndoPasteClick(object sender, EventArgs e)
        {
            // restore prev image
            view.IconspbxImage = previmage;

            if (previmage == null)
            {
                view.UndoPaste.Enabled = false;
            }
        }

        private void HandlebtnSaveClick(object sender, EventArgs e)
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
                msg = "Nothing was changed!\n\n";
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

        private void HandlebtnCancelClick(object sender, EventArgs e)
        {
            view.CloseView();
        }

        #endregion

        #region private methods =====

        private bool GetImageFromClipboard()
        {
            // only allow pasting of 16x16 icons!!!!
            if (Clipboard.ContainsImage())
            {
                var img = Clipboard.GetImage();

                //if (img.Height != 16 && img.Width != 16)
                //{
                //    // image too large!!
                //    msg = "Only 16x16 icons are allowed!\n\n";
                //    view.ShowMessage(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return false;
                //}

                ImagePasted = true;

                // save current image
                if (view.IconspbxImage != null)
                {
                    previmage = view.IconspbxImage;
                }
                view.IconspbxImage = img;
                //// new method
                //// Convert to bitmap
                //Bitmap bitmap = new Bitmap(Clipboard.GetImage());
                //// convert to icon
                //Icon ico = System.Drawing.Icon.FromHandle(bitmap.GetHicon());
                //// convert to byte[]
                //var bytes = IH.ImageHelpers.ConvertIconToByteArray(ico);
                //// convert to image to put into picturebox
                //SetViewPicBox(bytes);

                view.UndoPaste.Enabled = true;
                return true;
            }
            else
            {
                return false;
            }
        }

// this method nolonger needed==================================
        private void SetViewPicBox(byte[] dvdicon)
        {
            // convert byte[] to Image
            var img = IH.ImageHelpers.ConvertbyteArrayToImage(dvdicon);

            // enlarge Image 10 times
            if (img.Width < 257 && img.Height < 257)
            {
                img = IH.ImageHelpers.EnlargeImage(img, 10);
            }

            // put enlarged image in picturebox
            //view.PicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            view.IconspbxImage = img;
        }
//====================================================================
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

            if(string.IsNullOrWhiteSpace(chgName))
            {
                // failed validation
                NameFailed = true;
                msg = "Please enter an Icon Name!\n\n";
            }

            bool isNullOrEmpty = view.PicBox == null || chgImage == null;
            if(isNullOrEmpty)
            {
                // failed validation
                ImageFailed = true;
                msg += "Please paste an Image into the picture box!\n";
            }
        }

        private void CheckForChanges()
        {
            ChangesFound = false;

            if (chgName != origName)
            {
                ChangesFound = true;
                model.DvName = chgName;
            }
            else
            {
                samename = true;
            }

            sameimages = compareBMPs();
            if (!sameimages)
            {
                ChangesFound = true;
                model.DvIcon = chgImage;
            }
        }

        private bool compareBMPs()
        {
            bool flag = true;
            string origbmp_ref;
            string chgbmp_ref;

            // convert images to bitmaps for comparison
            Bitmap origbmp = new Bitmap(origImage);
            Bitmap chgbmp = new Bitmap(chgImage);

            if (origbmp.Width == chgbmp.Width && origbmp.Height == chgbmp.Height)
            {
                for (int i = 0; i < origbmp.Width; i++)
                {
                    for (int j = 0; j < origbmp.Height; j++)
                    {
                        origbmp_ref = origbmp.GetPixel(i, j).ToString();
                        chgbmp_ref = chgbmp.GetPixel(i, j).ToString();
                        if (origbmp_ref != chgbmp_ref)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        private void UpdateModel()
        {
            // get orig icon
            model.ChkContext();
            var origdvi = model.GetIconById();

            // save original icon in byte[] format
            model.OrigIcon = origdvi.Icon;

            // do the update
            var newdvi = model.SaveDVDIcon(sameimages);
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

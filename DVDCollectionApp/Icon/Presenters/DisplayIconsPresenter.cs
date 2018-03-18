using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nspIcon.Dialogs;
using nspIcon.Models;

using MyDVDs;
using AppM;

using System.Drawing;
using System.Windows.Forms;

using AppM;

namespace nspIcon.Presenters
{
    public class DisplayIconsPresenter
    {
        // members
        private IDisplayIcons view;
        private IDisplayIconsModel model;

        private string title = "";
        private string msg = "";
        private const string dblspc = "\n\n";

        private bool retriggered = false;
        private bool FromAdd = false;
        private bool FromEdit = false;
        private bool Initial = true;

        // icon values
        private const int isz = 16;
        private const int irez = 96;
        private const int nlrgsz = 6;
        private int currentsel = 0;

        private static int cancelcount = 0;

        // ctor
        public DisplayIconsPresenter(IDisplayIcons v)
        {
            // set IView
            view = v;

            // instantiate IModel
            model = new DisplayIconsModel();

            // wireup view events
            SubscribeToViewEvents();
        }

        private void SubscribeToViewEvents()
        {
            view.OnViewLoading += HandleViewLoadingEvent;
            view.OnComboSelChg += HandleComboSelChgEvent;
            view.OnAddBtnClicked += HandleAddBtnClicked;
            view.OnEditBtnClicked += HandleEditBtnClicked;
            view.OnDisplaybtnCloseClick += HandlebtnCloseClickRequest;
        }

        #region event handlers =====

        public void HandleViewLoadingEvent(object sender, EventArgs e)
        {
            // initialize combobox
            InitializeIconsCombo();
        }

        private void HandleComboSelChgEvent(object sender, EventArgs e)
        {
            DVDIcon dvi = new DVDIcon();

            if (retriggered)
            {
                // we got here by resetting combo name
                retriggered = false;
                return;
            }

            if (Initial)
            {
                // 1st time - set currentsel to 0
                currentsel = 0;
                Initial = false;
            }
            else if (FromAdd)
            {
                // set currentsel to the last item (just added)
                currentsel = view.IconsCombo.Items.Count - 1;
                FromAdd = false;
            }
            else if (FromEdit)
            {
                // leave the current selection as is
                FromEdit = false;
            }
            else
            {
                // reset current selected index to user's selection
                currentsel = view.IconsCombo.SelectedIndex;
            }

            // get selected DVDIcon data
            dvi = (DVDIcon)view.IconsCombo.Items[currentsel];

            // set view id txt box
            view.IdTextBox = dvi.Id.ToString();

            // set view picturebox - convert byte[] to image & enlarge
            SetViewPicBox(dvi.Icon);

            // set focus on combo
            SetComboFocus();

            if (view.IconsComboName != dvi.Name)
            {
                // reset combo icon name selected - retriggers this event
                retriggered = true;
                view.IconsComboName = dvi.Name;
            }
        }

        private void HandleAddBtnClicked(object sender, EventArgs e)
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
                InitializeIconsCombo();
            }
            else
            {
                FromAdd = false;
                SetComboFocus();
            }

            // unhide this view
            view.ShowView();
        }

        private void HandleEditBtnClicked(object sender, EventArgs e)
        {
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
                // changes made - refresh view
                InitializeIconsCombo();
            }
            else
            {
                FromEdit = false;
                SetComboFocus();
            }

            // unhide this view
            view.ShowView();
        }

        private void HandlebtnCloseClickRequest(object sender, EventArgs e)
        {
            view.CloseView();
        }

        #endregion

        #region private methods =====

        private void InitializeIconsCombo()
        {
            // get all the icons to populate the combo
            model.ChkContext();
            var iconsList = model.GetAllIcons();
            model.ClearContext();

            // set combo datasource properties
            view.IconsCombo.ValueMember = "Id";
            view.IconsCombo.DisplayMember = "Name";

            // set datasource - triggers comboselectchange
            view.IconsCombo.DataSource = iconsList;
        }

        private void SetViewPicBox(byte[] dvdicon)
        {
            var img = IH.ImageHelpers.ConvertbyteArrayToImage(dvdicon);
            // enlarge Image
            int newW = img.Width * nlrgsz;
            int newH = img.Height * nlrgsz;
            var reszimg = IH.ImageHelpers.ScaleImage(img, newW, newH);

            // put enlarged image in picturebox
            view.IconspbxImage = reszimg;
        }

        private void SetComboFocus()
        {
            view.IconsCombo.Focus();
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
            AddIcon nxtview = view.CreateAddView();
            AddIconPresenter nxtprs = new AddIconPresenter(nxtview);
            nxtview.StartPosition = FormStartPosition.CenterParent;
            view.HideView();
            nxtprs.ShowAsDialog();
        }

        private void ShowEditDialog()
        {
            FromEdit = true;
            EditIcon nxtview = view.CreateEditView(Int32.Parse(view.IdTextBox), view.IconsComboName, view.IconspbxImage);
            EditIconPresenter nxtprs = new EditIconPresenter(nxtview);
            nxtview.StartPosition = FormStartPosition.CenterParent;
            view.HideView();
            nxtprs.ShowAsDialog();
        }

        #endregion
    }
}

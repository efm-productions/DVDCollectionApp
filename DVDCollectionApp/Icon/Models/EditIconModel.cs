using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDs;
using MyDVDsBLL.BLLServices;

using AppM;

namespace nspIcon.Models
{
    public class EditIconModel : IEditIconModel
    {
        private BLLServices bll;

        private string _dvId;
        private string _dvName;
        private Image _dvIcon;
        private byte[] _origIcon;

        // icon values
        private const int isz = 16;
        private const int irez = 96;

        //ctor
        public EditIconModel()
        {
            bll = new BLLServices();
        }

        // methods
        public void ChkContext()
        {
            bll.ChkContext();
        }

        public void ClearContext()
        {
            bll.ClearContext();
        }

        #region Interface members
        public string DvId
        {
            get { return _dvId; }

            set { _dvId = value; }
        }

        public string DvName
        {
            get { return _dvName; }

            set { _dvName = value; }
        }

        public Image DvIcon
        {
            get { return _dvIcon; }

            set => _dvIcon = value;
        }

        public byte[] OrigIcon
        {
            get { return _origIcon; }

            set { _origIcon = value; }
        }

        public DVDIcon GetIconById()
        {
            var dvi = new DVDIcon();
            dvi.Id = Int32.Parse(DvId);
            dvi = bll.GetDVDIcon(dvi.Id);
            return dvi;
        }

        public DVDIcon SaveDVDIcon(bool sameimages)
        {
            var dvi = new DVDIcon();

            // copy fields values from model to DVDIcon
            dvi.Id = Int32.Parse(DvId);
            dvi.Name = DvName;

            if (sameimages)
            {
                // get original DVDIcon for this Id
                dvi.Icon = OrigIcon;
            }
            else
            {
                // store in dvdicon
                dvi.Icon = GetImageFromModel();
            }

            // update
            var newdvi = bll.UpdateDVDIcon(dvi);

            return newdvi;
        }

        private byte[] GetImageFromModel()
        {
            Image img = DvIcon;

            Icon tempIcon = IH.ImageHelpers.PngIconFromImage(img);
            //Icon tempIcon = IH.ImageHelpers.CreateIcon((Bitmap)img ,IH.IconSizeDimensions.IconSize16x16Pixels);

            var bytes =  IH.ImageHelpers.ConvertIconToByteArray(tempIcon);

            return bytes;
        }

        #endregion
    }
}

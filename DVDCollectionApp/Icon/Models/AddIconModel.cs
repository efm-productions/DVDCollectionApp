using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDs;
using MyDVDsBLL.BLLServices;

using AppM;
using System.Drawing;

namespace nspIcon.Models
{
    public class AddIconModel : IAddIconModel
    {
        private BLLServices bll;

        private string _dvId;
        private string _dvName;
        private Image _dvIcon;

        //ctor
        public AddIconModel()
        {
            bll = new BLLServices();
        }

        #region implement interface =====

        // members

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

        // methods
        public DVDIcon AddDVDIcon()
        {
            var dvi = new DVDIcon();
            Image img;

            dvi.Name = DvName;

            img = DvIcon;

            // we need to make the image 16 x 16
            int wfactor = Convert.ToInt32(img.Width / 16);
            int hfactor = Convert.ToInt32(img.Height / 16);

            if (wfactor == hfactor)
            {
                img = IH.ImageHelpers.ReduceImage(img, wfactor);
            }
            else
            {
                img = IH.ImageHelpers.ReduceImage(img, wfactor, hfactor);
            }

            // convert image to byte array
            var bytes = IH.ImageHelpers.ConvertImageToByteArray(img);

            // store in dvdicon
            dvi.Icon = bytes;

            // insert
            var newdvi = bll.AddDVDIcon(dvi);

            return newdvi;
        }

        public void ChkContext()
        {
            bll.ChkContext();
        }

        public void ClearContext()
        {
            bll.ClearContext();
        }

        #endregion
    }
}

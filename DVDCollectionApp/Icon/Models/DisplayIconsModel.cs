using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDs;
using MyDVDsBLL.BLLServices;

namespace nspIcon.Models
{
    public class DisplayIconsModel : IDisplayIconsModel
    {
        // members
        private string m_IdTextBox;
        private string m_IconsComboName;
        private Image m_IconspbxImage;

        // bll
        private BLLServices bll;

        //ctor
        public DisplayIconsModel()
        {
            bll = new BLLServices();
        }

        #region implement interface =====

        // properties
        public string _IdTextBox
        {
            get { return m_IdTextBox; }
            set { m_IdTextBox = value; }
        }

        public string _IconsComboName
        {
            get { return m_IconsComboName; }
            set { m_IconsComboName = value; }
        }

        public Image _IconspbxImage
        {
            get { return m_IconspbxImage; }
            set { m_IconspbxImage = value; }
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

        public List<DVDIcon> GetAllIcons()
        {
            var iconsList = bll.GetAllDVDIcons();
            return iconsList;
        }

        public DVDIcon GetIconByName(string iconname)
        {
            var dvi = bll.GetDVDIconByName(iconname);
            return dvi;
        }

        #endregion

        #region  private methods =====

        #endregion
    }
}

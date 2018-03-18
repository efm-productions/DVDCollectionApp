using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVDMC;
using MyDVDs;
using MyDVDsBLL.BLLServices;

namespace Rt.Models
{
    public class DisplayRatingsModel :IDisplayRatingsModel
    {
        private BLLServices bll;
        private List<AllRatingsForGrid> m_AllRatingsForGrid;

        // ctor
        public DisplayRatingsModel()
        {
            bll = new BLLServices();
        }

        #region interface implementation ===================

        // properties
        public List<AllRatingsForGrid> GridData
        {
            get { return m_AllRatingsForGrid; }
            set => m_AllRatingsForGrid = value;
        }

        // methods
        public void GetGridData()
        {
            GridData = bll.GetAllRatingsForGrid();
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

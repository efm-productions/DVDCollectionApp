using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVDMC;
using MyDVDs;
using MyDVDsBLL.BLLServices;

namespace Gnr.Models
{
    public class DisplayGenresModel : IDisplayGenresModel
    {
        private BLLServices bll;
        private List<AllGenresForGrid> m_AllGenresForGrid;

        // ctor
        public DisplayGenresModel()
        {
            bll = new BLLServices();
        }

        #region interface implementation ===================

        // properties
        public List<AllGenresForGrid> GridData
        {
            get { return m_AllGenresForGrid; }
            set => m_AllGenresForGrid = value;
        }

        // methods
        public void GetGridData()
        {
            GridData = bll.GetAllGenresForGrid();
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

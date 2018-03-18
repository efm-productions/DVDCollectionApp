using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVDMC;
using MyDVDs;
using MyDVDsBLL.BLLServices;

namespace MyDVDsMain.Models
{
    public class DisplayMainModel : IDisplayMainModel
    {
        private BLLServices bll;
        private List<AllContentForGrid> m_AllContentsForGrid;

        private string _totalBoxes;
        private string _totalCases;
        private string _totalBoxsets;
        private string _totalDiscs;
        private string _totalContents;
        private List<int> _boxNumbers;

        // ctor
        public DisplayMainModel()
        {
            bll = new BLLServices();
        }

        #region interface implementation ===================

        // properties
        public string m_totalBoxes
        {
            get { return _totalBoxes;  }
            set { _totalBoxes = value;  }
        }

        public string m_totalCases
        {
            get { return _totalCases; }
            set { _totalCases = value; }
        }

        public string m_totalBoxsets
        {
            get { return _totalBoxsets; }
            set { _totalBoxsets = value; }
        }

        public string m_totalDiscs
        {
            get { return _totalDiscs; }
            set { _totalDiscs = value; }
        }

        public string m_totalContents
        {
            get { return _totalContents; }
            set { _totalContents = value; }
        }

        public List<int> m_boxNumbers
        {
            get { return _boxNumbers; }
            set => _boxNumbers = value;
        }

        public List<AllContentForGrid> GridData
        {
            get { return m_AllContentsForGrid; }
            set => m_AllContentsForGrid = value;         }

        // methods
        public void ChkContext()
        {
            bll.ChkContext();
        }

        public void ClearContext()
        {
            bll.ClearContext();
        }

        public void GetGridData()
        {
            GridData = bll.GetAllContents();
        }

        public Content GetContentById(int id)
        {
            var co = bll.GetContentById(id);
            return co;
        }

        public void GetStatistics()
        {
            var i = bll.TotalBoxes();
            _totalBoxes = i.ToString();

            i = bll.TotalCases();
            _totalCases = i.ToString();

            i = bll.TotalBoxsets();
            _totalBoxsets = i.ToString();

            i = bll.TotalDiscs();
            _totalDiscs = i.ToString();

            i = bll.TotalContents();
            _totalContents = i.ToString();
        }

        public List<int> GetAllBoxNumbers()
        {
            return bll.GetAllBoxNumbers();
        }

        public List<Content> SearchForTitle(string title)
        {
            var coList = bll.SearchForTitle(title);

            return coList;
        }

        #endregion
    }
}

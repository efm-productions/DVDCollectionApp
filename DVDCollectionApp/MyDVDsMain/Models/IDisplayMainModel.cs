using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVDMC;
using MyDVDsBLL.BLLServices;
using MyDVDs;

namespace MyDVDsMain.Models
{
    public interface IDisplayMainModel
    {
        // grid
        List<AllContentForGrid> GridData { get; set; }

        // methods
        void GetGridData();
        Content GetContentById(int id);
        void GetStatistics();
        List<int> GetAllBoxNumbers();
        List<Content> SearchForTitle(string title);
        void ChkContext();
        void ClearContext();

        // properties
        string m_totalBoxes { get; set; }
        string m_totalCases { get; set; }
        string m_totalBoxsets { get; set; }
        string m_totalDiscs { get; set; }
        string m_totalContents { get; set; }
        List<int> m_boxNumbers { get; set; }

    }
}

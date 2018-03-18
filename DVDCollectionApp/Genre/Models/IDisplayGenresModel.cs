using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVDMC;

namespace Gnr.Models
{
    public interface IDisplayGenresModel
    {
        // properties

        // grid
        List<AllGenresForGrid> GridData { get; set; }

        // methods
        void GetGridData();
        void ChkContext();
        void ClearContext();
    }
}

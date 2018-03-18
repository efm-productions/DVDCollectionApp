using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVDMC;

namespace Rt.Models
{
    public interface IDisplayRatingsModel
    {
        // properties

        // grid
        List<AllRatingsForGrid> GridData { get; set; }

        // methods
        void GetGridData();
        void ChkContext();
        void ClearContext();
    }
}

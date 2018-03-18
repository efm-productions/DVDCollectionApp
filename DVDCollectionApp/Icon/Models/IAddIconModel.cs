using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDs;

namespace nspIcon.Models
{
    public interface IAddIconModel
    {
        // model properties analogous to the View properties
        string DvId { get; set; }
        string DvName { get; set; }
        Image DvIcon { get; set; }

        DVDIcon AddDVDIcon();
        void ChkContext();
        void ClearContext();
    }
}

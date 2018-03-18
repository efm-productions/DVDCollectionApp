using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDVDs;

namespace nspIcon.Models
{
    public interface IDisplayIconsModel
    {
        // properties
        string _IdTextBox { get; set; }
        string _IconsComboName { get; set; }
        Image _IconspbxImage { get; set; }

        // methods
        List<DVDIcon> GetAllIcons();
        DVDIcon GetIconByName(string iconname);
        void ChkContext();
        void ClearContext();
    }
}

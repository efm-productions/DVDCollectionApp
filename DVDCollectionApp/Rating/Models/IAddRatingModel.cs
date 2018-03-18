using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDs;

namespace Rt.Models
{
    public interface IAddRatingModel
    {
        // properties
        string M_RatingId { get; set; }
        string M_RatingMPAA { get; set; }
        string M_RatingDescrip { get; set; }

        // methods
        Rating AddRating();
        bool IsRatingDuplicate(string name);
        void ChkContext();
        void ClearContext();
    }
}

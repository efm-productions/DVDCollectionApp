using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDs;
using MyDVDsBLL.BLLServices;

namespace Rt.Models
{
    public class AddRatingModel :IAddRatingModel
    {
        private BLLServices bll;

        private string _rtId;
        private string _rtMPAA;
        private string _rtDescrip;

        //ctor
        public AddRatingModel()
        {
            bll = new BLLServices();
        }

        #region implement interface =====

        // properties
        public string M_RatingId
        {
            get { return _rtId; }
            set { _rtId = value; }
        }

        public string M_RatingMPAA
        {
            get { return _rtMPAA; }

            set { _rtMPAA = value; }
        }

        public string M_RatingDescrip
        {
            get { return _rtDescrip; }

            set { _rtDescrip = value; }
        }

        // methods
        public Rating AddRating()
        {
            var gnr = new Rating();
            gnr.MPAACode = M_RatingMPAA;
            gnr.Description = M_RatingDescrip;

            var newgnr = bll.AddRating(gnr);

            return newgnr;
        }

        public bool IsRatingDuplicate(string mpaacode)
        {
            return bll.IsRatingDuplicate(mpaacode);
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

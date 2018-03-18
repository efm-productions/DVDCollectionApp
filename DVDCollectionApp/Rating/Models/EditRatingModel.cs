using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDs;
using MyDVDsBLL.BLLServices;

using AppM;
using System.Drawing;

namespace Rt.Models
{
    public class EditRatingModel : IEditRatingModel
    {
        private BLLServices bll;

        private string _rtId;
        private string _rtMPAA;
        private string _rtDescrip;

        //ctor
        public EditRatingModel()
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

            set { _rtMPAA = value; }
        }

        // methods
        public Rating GetRatingById()
        {
            var gnr = new Rating();
            gnr.Id = Int32.Parse(M_RatingId);
            gnr = bll.GetRating(gnr.Id);
            return gnr;
        }

        public Rating SaveRating()
        {
            var gnr = new Rating();

            // copy fields values from model to Rating
            gnr.Id = Int32.Parse(M_RatingId);
            gnr.MPAACode = M_RatingMPAA;
            gnr.Description = M_RatingDescrip;

            // update
            var newgnr = bll.UpdateRating(gnr);

            return newgnr;
        }

        public bool IsRatingDuplicate(string mpaacode)
        {
            return bll.IsRatingDuplicate(mpaacode);
        }

        public int DeleteRating()
        {
            int id = Int32.Parse(M_RatingId);
            return bll.DeleteRating(id);
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


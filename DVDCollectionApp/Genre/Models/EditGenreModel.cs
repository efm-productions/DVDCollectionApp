using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDs;
using MyDVDsBLL.BLLServices;

using AppM;
using System.Drawing;

namespace Gnr.Models
{
    class EditGenreModel : IEditGenreModel
    {
        private BLLServices bll;

        private string _dvId;
        private string _dvName;

        //ctor
        public EditGenreModel()
        {
            bll = new BLLServices();
        }

        #region implement interface =====

        // properties
        public string M_GenreId
        {
            get { return _dvId; }
            set { _dvId = value; }
        }

        public string M_GenreName
        {
            get { return _dvName; }

            set { _dvName = value; }
        }

        // methods
        public Genre GetGenreById()
        {
            var gnr = new Genre();
            gnr.Id = Int32.Parse(M_GenreId);
            gnr = bll.GetGenre(gnr.Id);
            return gnr;
        }

        public Genre SaveGenre()
        {
            var gnr = new Genre();

            // copy fields values from model to Genre
            gnr.Id = Int32.Parse(M_GenreId);
            gnr.Name = M_GenreName;

            // update
            var newgnr = bll.UpdateGenre(gnr);

            return newgnr;
        }

        public int DeleteGenre()
        {
            int id = Int32.Parse(M_GenreId);
            return bll.DeleteGenre(id);
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

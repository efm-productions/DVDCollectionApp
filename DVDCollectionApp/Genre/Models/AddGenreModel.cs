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
    public class AddGenreModel :IAddGenreModel
    {
        private BLLServices bll;

        private string _dvId;
        private string _dvName;

        //ctor
        public AddGenreModel()
        {
            bll = new BLLServices();
        }

        #region implement interface =====

        // properties
        public string M_GenreId
        {
            get { return _dvId; }
            set { _dvName = value; }
        }

        public string M_GenreName
        {
            get { return _dvName; }

            set { _dvName = value; }
        }

        // methods
        public MyDVDs.Genre AddGenre()
        {
            var gnr = new MyDVDs.Genre();
            gnr.Name = M_GenreName;

            var newgnr = bll.AddGenre(gnr);

            return newgnr;
        }

        public bool IsGenreDuplicate(string name)
        {
            return bll.IsGenreDuplicate(name);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnr.Models
{
    public interface IEditGenreModel
    {
        // properties
        string M_GenreId { get; set; }
        string M_GenreName { get; set; }

        // methods
        MyDVDs.Genre GetGenreById();
        MyDVDs.Genre SaveGenre();
        int DeleteGenre();
        void ChkContext();
        void ClearContext();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDVDs;

namespace Gnr.Models
{
    public interface IAddGenreModel
    {
        // properties
        string M_GenreId { get; set; }
        string M_GenreName { get; set; }

        // methods
        MyDVDs.Genre AddGenre();
        bool IsGenreDuplicate(string name);
        void ChkContext();
        void ClearContext();

    }
}

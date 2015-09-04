using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieApp.Models.Abstract
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetMovies();
        bool AddMovie(string title);
    }
}

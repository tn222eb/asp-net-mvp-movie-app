using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieApp.Models.Abstract
{
    public interface IMovieRepository : IDisposable
    {
        void AddMovie(Movie movie);
        void EditMovie(Movie movie);
        void RemoveMovie(int id);
        IEnumerable<Movie> GetMovies();
        Movie GetMovieById(int id);

        Movie GetMovieByTitle(string title);

        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMovieApp.Models.Abstract
{
    public abstract class MovieRepositoryBase : IMovieRepository
    {
        protected abstract IQueryable<Movie> QueryMovies();

        public abstract void AddMovie(Movie movie);

        public abstract void EditMovie(Movie movie);

        public Movie GetMovieById(int id)
        {
            return QueryMovies().FirstOrDefault(m => m.MovieId == id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return QueryMovies().ToList();
        }

        public abstract void RemoveMovie(int id);

        public Movie GetMovieByTitle(string title)
        {
            return QueryMovies().FirstOrDefault(m => m.Title == title);
        }

        public abstract void Save();

        #region IDisposable

        protected virtual void Dispose(bool disposing)
        {

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
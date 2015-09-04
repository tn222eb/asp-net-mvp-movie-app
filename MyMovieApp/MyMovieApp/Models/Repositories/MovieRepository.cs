using MyMovieApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMovieApp.Models.Repositories
{
    public class MovieRepository : MovieRepositoryBase
    {
        private MovieEntities m_entities = new MovieEntities();
        public override void AddMovie(Movie movie)
        {
            m_entities.Movies.Add(movie);
        }

        public override void EditMovie(Movie movie)
        {
            m_entities.Entry(movie).State = EntityState.Modified;
        }

        public override void RemoveMovie(int id)
        {
            Movie movie = m_entities.Movies.Find(id);
            m_entities.Movies.Remove(movie);
        }

        public override void Save()
        {
            m_entities.SaveChanges();
        }

        protected override IQueryable<Movie> QueryMovies()
        {
            return m_entities.Movies.AsQueryable();
        }
    }
}
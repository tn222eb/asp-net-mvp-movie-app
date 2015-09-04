using MyMovieApp.Models.Abstract;
using MyMovieApp.Models.Repositories;
using MyMovieApp.Models.Webservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMovieApp.Models.Service
{
    public class MovieService : IMovieService
    {
        private IMovieRepository m_repository;
        private IMovieWebservice m_webService;

        public MovieService()
            :this(new MovieRepository(), new MovieWebservice())
        {

        }

        public MovieService(IMovieRepository repository, IMovieWebservice webService)
        {
            m_repository = repository;
            m_webService = webService;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return m_repository.GetMovies();
        }

        public bool AddMovie(string title)
        {
            Movie movie = m_repository.GetMovieByTitle(title);

            if (movie == null)
            {
                movie = m_webService.GetMovieInfo(title);

                if (movie != null)
                {
                    m_repository.AddMovie(movie);
                    m_repository.Save();

                    return true;
                }
            }

            return false; 
        }
    }
}
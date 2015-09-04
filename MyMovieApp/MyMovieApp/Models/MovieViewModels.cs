using MyMovieApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMovieApp.Models
{
    public class MovieViewModel
    {
        [DataType(DataType.Text)]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Title { get; set; }

        public IEnumerable<Movie> Movies { get; set; }

        public bool HasMovies
        {
            get
            {
                return Movies != null && Movies.Any();
            }
        }
    }
}
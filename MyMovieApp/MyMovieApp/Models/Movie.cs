using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyMovieApp.Models
{
    [MetadataType(typeof(Movie_Metadata))]
    public partial class Movie
    {

    }
    public class Movie_Metadata
    {
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Year")]
        public int Year { get; set; }

        [Display(Name = "Runtime")]
        public string Runtime { get; set; }

        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Display(Name = "Director")]
        public string Director { get; set; }

        [Display(Name = "Writer")]
        public string Writer { get; set; }

        [Display(Name = "Actors")]
        public string Actors { get; set; }
 
        [Display(Name = "Plot")]
        public string Plot { get; set; }

        [Display(Name = "Poster")]
        public string Poster { get; set; }

        [Display(Name = "Rating")]
        public decimal ImdbRating { get; set; }
    }
}
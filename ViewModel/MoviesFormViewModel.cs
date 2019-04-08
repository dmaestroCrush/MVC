using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class MoviesFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleasedDate { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 20, ErrorMessage = "Stocks should be between 1-20")]
        [Required]
        public short? NumberInStocks { get; set; }

        public MoviesFormViewModel()
        {
            Id = 0;
        }
        public MoviesFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleasedDate = movie.ReleasedDate;
            NumberInStocks = movie.NumberInStocks;
            GenreId = movie.GenreId;

        }
        public string Title
        {
            get
             {
                return (Id != 0)
                    ? "Edit Movie" : " New Movie";
             }
        }
    }
}
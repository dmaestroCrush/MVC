using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required,StringLength(255)]
        public string Name { get; set; }

        [Display(Name= "Release Date")]
        public DateTime ReleasedDate { get; set; }

        public DateTime DateAdded { get; set; }

 
        public Genre Genre { get; set; }

        [Display(Name="Genre")]
        [Required]
        public byte GenreId { get; set; }

        [Display(Name= "Number In Stock")]
        [Range(1,20,ErrorMessage = "Stocks should be between 1-20")]
        public short NumberInStocks { get; set; }

    }
}
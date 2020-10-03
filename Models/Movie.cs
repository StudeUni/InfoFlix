using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InfoFlix.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3), Required]
        public string Title { get; set; }
        [StringLength(300, MinimumLength = 10), Required]
        public string Synopsis { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date), Required]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string TrailerUrl { get; set; }
        public string ImageUrl { get; set; }

    }
}

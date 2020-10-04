using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InfoFlix.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3), Required, DisplayName("Title:")]
        public string Title { get; set; }
        [StringLength(300, MinimumLength = 10), Required, DisplayName("Synopsis:")]
        public string Synopsis { get; set; }

        [Display(Name = "Release Date:"), DataType(DataType.Date), Required, DisplayName("Relase Date:")]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 5), DisplayName("Rating:")]
        public int Rating { get; set; }

        [DisplayName("Trailer Url ")]
        public string TrailerUrl { get; set; }
        [DisplayName("Image Url ")]
        public string ImageUrl { get; set; }

    }
}

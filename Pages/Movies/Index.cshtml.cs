using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InfoFlix.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly IMovieRepository movieRepository;

        public IEnumerable<Movie> Movies { get; set; } //list of objects holding movies

        public IndexModel(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }
        public void OnGet()
        {
            Movies = movieRepository.GetAllMovies();
        }
    }
}

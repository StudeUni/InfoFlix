using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InfoFlix.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly IMovieRepository movieRepository;

        public DetailsModel(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public Movie Movie { get; private set; }
        public IActionResult OnGet(int id)
        {
            Movie = movieRepository.GetMovie(id);

            if(Movie == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
    }
}

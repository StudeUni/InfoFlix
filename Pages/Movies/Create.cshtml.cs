using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InfoFlix.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly IMovieRepository _movieRepository;
        public CreateModel(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public IActionResult OnPost(Movie movie)
        {
            Movie = _movieRepository.Add(movie);
            return RedirectToPage("Index");
        }

    }
}

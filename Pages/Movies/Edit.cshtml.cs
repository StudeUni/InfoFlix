using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InfoFlix.Pages.Movies
{
    public class EditModel : PageModel
    {
        private readonly IMovieRepository movieRepository;
        public EditModel(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        [BindProperty]
        public Movie Movie { get; set; }
        public IActionResult OnGet(int id)
        {
            Movie = movieRepository.GetMovie(id);

            if(Movie == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }

        public IActionResult OnPost(Movie movie)
        {
            Movie = movieRepository.Update(movie);
            return RedirectToPage("/Movies/Index");
        }
    }
}

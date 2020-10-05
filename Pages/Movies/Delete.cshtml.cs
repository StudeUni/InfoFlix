using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InfoFlix.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly IMovieRepository movieRepository;

        public DeleteModel(IMovieRepository movieRepository)
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
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Movie DeletedMovie = movieRepository.Delete(Movie.Id);

            if(DeletedMovie == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Movies/Index");
        }
    }
}

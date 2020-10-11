using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InfoFlix.Pages.Movies
{
    //We get our public employee property and use a bind property attribute
    //then we create the constuructor to bring in the interface through dependency injection
    //then we use the repo to get the movie method in the onget method 
    //we then have a form which has a post method attribute inside with a submit button
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

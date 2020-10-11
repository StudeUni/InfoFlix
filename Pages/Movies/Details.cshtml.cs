using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InfoFlix.Pages.Movies
{
    //in here we want call the getmovie method to do so we implement the interface by injecting it into the constructor
    //we then create a public property which will be assigned the injected instance calling the getmovie method passing in the id in its parameters
    //Thanks to model-binding the route parameter value is binded to the OnGet() method parameter 
    //To be able to access the route parameter we need to have a parameter in the onGet() method this then binded together thanks to Model-binding 
    // To handle the scenario where we have a route paramter which exceeds those in the list/database we should be taken to a page saying not found
    // To return results such as pages IActionResult is used because redirect to page implements IAction interface
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

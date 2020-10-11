using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InfoFlix.Pages.Movies
{
    //We inject the interface into this pagemodel class through the constuctor to be able to acess its methods which are implemented in the mock repository
    //We then create a public property which will be accessible in the cshtml page it will be an IEnumerable of employee type
    //After created we intialise the property in the OnGet Method.
    //The OnGet method is called when a get requsted is issued by cshtml page
    //When intialising we set it to the movierepository calling the get all movies method.
    //At run time when an instance of this class is created .NET core dependency injection system has to inject an instance of the concrete class that implements the interface which iS Mockrepository
    // This is done in Startup through adding services which can be singleton,trainsient or scoped singleton provides a single instance of the class
    // To be able to display the list of movies we then use a foreach loop 

    public class IndexModel : PageModel
    {
        private readonly IMovieRepository movieRepository;

        public IEnumerable<Movie> Movies { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public IndexModel(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }
        public void OnGet()
        {
            Movies = movieRepository.Search(SearchString);
        }
    }
}

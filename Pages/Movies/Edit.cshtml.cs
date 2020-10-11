using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InfoFlix.Pages.Movies
{
    //Again we inject the irepository interface using the constructor 
    //then we create our public property which will bind to our display template
    //Since the record being editeds ID is passed in the route parameter we will give the onGet method an id parameter then model biding will automatically bind those two id together
    //if the value is still null it means we havent find the record we are looking for
    //When found we want to refresh the page so that the details of the movie can be edited
    //in the design template we want to be able to update the data so we use a form with a post request
    //we dont want the user to be able to change the id but its need to be able to send it back once updated so we put in the form but hidden
    //we have a button type which then submits the updated record 
    
    //In the onpost method we then need to pass in the object 
    //Thanks to model binding the values being posted as automatically binded to the onpost methods paramter value
    //We then need to just call the repisotry update method which we will pass the movie object which we will assign to the public property
    //then we redirect to show the updated changes
    //Values in the form are automatically mapped to respecticve properties using model binding 

    //Validations steps
    //First Apply validation attributes on properties next  use modelstate is valid to check validation is successful use tag helper validation for to display validation messages
    //Having client side validation is good because as we start to type we get feedback straight away and it also reduces the load on the server because the form is only submitted upon passing client side validations

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
            if(ModelState.IsValid)
            {
                Movie = movieRepository.Update(movie);
                return RedirectToPage("/Movies/Index");

            }
            return Page();
        }
    }
}

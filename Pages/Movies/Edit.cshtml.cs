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
        public void OnGet()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoFlix.Models
{
    public interface IMovieRepository
    {
        //Interface abstraction which is this allows us to use dependency injection
        //This Follows inversion of control principle which allows us to develop loosely coupled systems
        //Watch dependecy injection tutorial


        Movie GetMovie(int Id);

        //Use Ienumerable because its generic and can still be applied to a list method depending on the injection
        IEnumerable<Movie> GetAllMovies();
        Movie Add(Movie movie);
        
        Movie Update(Movie MovieUpdates);
        Movie Delete(int id);
        IEnumerable<Movie> Search(string SearchString);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoFlix.Models
{
    public interface IMovieRepository
    {

        Movie GetMovie(int Id);
        IEnumerable<Movie> GetAllMovies();
        Movie Add(Movie movie);
        
        Movie Update(Movie MovieUpdates);
        Movie Delete(int id);
        IEnumerable<Movie> Search(string SearchString);
    }
}

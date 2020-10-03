using InfoFlix.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoFlix.Models
{
    public class SqlMovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;

        public SqlMovieRepository(MovieDbContext context)
        {
            _context = context;
        }

        public Movie Add(Movie movie)
        {
            _context.Movie.Add(movie); //Add record
            _context.SaveChanges(); //Save changes
            return movie; 
        }

        public Movie Delete(int Id)
        {
           Movie movie = _context.Movie.Find(Id);

            if(movie !=null)
            {
                _context.Remove(movie);
                _context.SaveChanges();
            }

            return movie;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _context.Movie;
        }

        public Movie GetMovie(int Id)
        {
           return  _context.Movie.Find(Id);
        }

        public Movie Update(Movie MovieUpdates)
        {
           var movie = _context.Movie.Attach(MovieUpdates);
            movie.State = Microsoft.EntityFrameworkCore.EntityState.Modified; // EF knows it has to update in repsect to object
            _context.SaveChanges();

            return MovieUpdates;
        }

        public IEnumerable<Movie> Search(string SearchString)
        {
            if (!string.IsNullOrEmpty(SearchString))
            {
               return _context.Movie.Where(s => s.Title.Contains(SearchString));
            }

            return _context.Movie;
        }
    }
}

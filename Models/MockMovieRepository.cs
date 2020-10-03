using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoFlix.Models
{
    public class MockMovieRepository : IMovieRepository
    {
        private List<Movie> MovieList;

        public MockMovieRepository()
        {
            MovieList = new List<Movie>()
            {
                new Movie() {Id=1, Title ="John Whick", Synopsis="John Whick is really great", ReleaseDate=DateTime.Parse("10/10/2019"), Rating=3, TrailerUrl="https://www.youtube.com/watch?v=2AUmvWm5ZDQ" ,ImageUrl="https://i.ebayimg.com/images/g/v7wAAOSwL0tdFgUp/s-l1600.jpg"}
            };
        }
        public Movie Add(Movie movie)
        {
            movie.Id = MovieList.Max(m => m.Id) + 1;
            MovieList.Add(movie);
            return movie;
        }

        public Movie Delete(int id)
        {
           Movie movie =  MovieList.FirstOrDefault(m => m.Id == id);
            if(movie != null)
            {
                MovieList.Remove(movie);
            }
            return movie; 
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return MovieList;
        }

        public Movie GetMovie(int Id)
        {
            return MovieList.FirstOrDefault(m => m.Id == Id);
        }

        public Movie Update(Movie MovieUpdates)
        {
            Movie movie = MovieList.FirstOrDefault(m => m.Id == MovieUpdates.Id);

            if (movie != null)
            {
                movie.Title = MovieUpdates.Title;
                movie.Synopsis = MovieUpdates.Synopsis;
                movie.ReleaseDate = MovieUpdates.ReleaseDate;
                movie.Rating = MovieUpdates.Rating;
                movie.ImageUrl=  MovieUpdates.ImageUrl;
            }

            return movie;
        }

        public IEnumerable<Movie> Search(string SearchString)
        {
            if (!string.IsNullOrEmpty(SearchString))
            {
                return MovieList.Where(m => m.Title.Contains(SearchString));
            }

            return MovieList;
        }
    }
}

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
				new Movie() {Id=1, Title ="John Whick", Synopsis="Legendary assassin John Wick (Keanu Reeves) retired from his violent career after marrying the love of his life. Her sudden death leaves John in deep mourning.", ReleaseDate=DateTime.Parse("10/04/2015"), Rating=5, TrailerUrl="https://www.youtube.com/watch?v=2AUmvWm5ZDQ" ,ImageUrl="https://media-cache.cinematerial.com/p/500x/dq0gglvi/john-wick-chapter-3-parabellum-advance-movie-poster.jpg?v=1547571738"},
				new Movie() {Id=2, Title ="Logan", Synopsis="In the near future, a weary Logan (Hugh Jackman) cares for an ailing Professor X (Patrick Stewart) at a remote outpost on the Mexican border.", ReleaseDate=DateTime.Parse("1/03/2017"), Rating=5, TrailerUrl="https://www.youtube.com/watch?v=Div0iP65aZo" ,ImageUrl="https://media-cache.cinematerial.com/p/500x/sjvehuzs/logan-theatrical-movie-poster.jpg?v=1487207987"},
				new Movie() {Id=3, Title ="The Kingsman", Synopsis="Gary Eggsy Unwin (Taron Egerton), whose late father secretly worked for a spy organization, lives in a South London housing estate and seems headed for a life behind bars.", ReleaseDate=DateTime.Parse("03/04/2021"), Rating=5, TrailerUrl="https://www.youtube.com/watch?v=5zdBG-iGfes",ImageUrl="https://media-cache.cinematerial.com/p/500x/iqo9ujpt/the-kings-man-movie-poster.jpg?v=1592763997"},
				new Movie() {Id=4, Title ="Aquaman", Synopsis="Once home to the most advanced civilization on Earth, the city of Atlantis is now an underwater kingdom ruled by the power-hungry King Orm.", ReleaseDate=DateTime.Parse("12/12/2018"), Rating=5, TrailerUrl="https://www.youtube.com/watch?v=2wcj6SrX4zw",ImageUrl="https://media-cache.cinematerial.com/p/500x/bokjl734/aquaman-movie-poster.jpg?v=1542736450"},
				new Movie() {Id=5, Title ="1917", Synopsis="During World War I, two British soldiers -- Lance Cpl. Schofield and Lance Cpl. Blake -- receive seemingly impossible orders.", ReleaseDate=DateTime.Parse("12/12/2018"), Rating=5, TrailerUrl="https://www.youtube.com/watch?v=YqNYrYUiMfg",ImageUrl="https://media-cache.cinematerial.com/p/500x/haeorwgk/1917-british-movie-poster.jpg?v=1579166770"},
				new Movie() {Id=6, Title ="Godzilla: King of Monsters", Synopsis="Members of the crypto-zoological agency Monarch face off against a battery of god-sized monsters, including the mighty Godzilla, who collides with Mothra, Rodan, and his ultimate nemesis, the three-headed King Ghidorah.", ReleaseDate=DateTime.Parse("12/12/2018"), Rating=5, TrailerUrl="https://www.youtube.com/watch?v=QFxN2oDKk0E",ImageUrl="https://media-cache.cinematerial.com/p/500x/dyf4wh2r/godzilla-king-of-the-monsters-movie-poster.jpg?v=1558985734"}
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

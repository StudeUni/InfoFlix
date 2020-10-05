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
				new Movie() {Id=1, Title ="John Whick", Synopsis="Legendary assassin John Wick (Keanu Reeves) retired from his violent career after marrying the love of his life. Her sudden death leaves John in deep mourning. When sadistic mobster Iosef Tarasov (Alfie Allen) and his thugs steal John's prized car and kill the puppy that was a last gift from his wife, John unleashes the remorseless killing machine within and seeks vengeance. Meanwhile, Iosef's father (Michael Nyqvist) -- John's former colleague -- puts a huge bounty on John's head.", ReleaseDate=DateTime.Parse("10/04/2015"), Rating="5", TrailerUrl="https://www.youtube.com/watch?v=2AUmvWm5ZDQ" ,ImageUrl="https://media-cache.cinematerial.com/p/500x/dq0gglvi/john-wick-chapter-3-parabellum-advance-movie-poster.jpg?v=1547571738"},
				new Movie() {Id=2, Title ="Logan", Synopsis="In the near future, a weary Logan (Hugh Jackman) cares for an ailing Professor X (Patrick Stewart) at a remote outpost on the Mexican border. His plan to hide from the outside world gets upended when he meets a young mutant (Dafne Keen) who is very much like him. Logan must now protect the girl and battle the dark forces that want to capture her.", ReleaseDate=DateTime.Parse("1/03/2017"), Rating="5", TrailerUrl="https://www.youtube.com/watch?v=Div0iP65aZo" ,ImageUrl="https://media-cache.cinematerial.com/p/500x/sjvehuzs/logan-theatrical-movie-poster.jpg?v=1487207987"},
				new Movie() {Id=3, Title ="The Kingsman", Synopsis="Gary Eggsy Unwin (Taron Egerton), whose late father secretly worked for a spy organization, lives in a South London housing estate and seems headed for a life behind bars. However, dapper agent Harry Hart (Colin Firth) recognizes potential in the youth and recruits him to be a trainee in the secret service. Meanwhile, villainous Richmond Valentine (Samuel L. Jackson) launches a diabolical plan to solve the problem of climate change via a worldwide killing spree.", ReleaseDate=DateTime.Parse("03/04/2021"), Rating="5", TrailerUrl="https://www.youtube.com/watch?v=5zdBG-iGfes",ImageUrl="https://media-cache.cinematerial.com/p/500x/iqo9ujpt/the-kings-man-movie-poster.jpg?v=1592763997"},
				new Movie() {Id=4, Title ="Aquaman", Synopsis="Once home to the most advanced civilization on Earth, the city of Atlantis is now an underwater kingdom ruled by the power-hungry King Orm. With a vast army at his disposal, Orm plans to conquer the remaining oceanic people -- and then the surface world. Standing in his way is Aquaman, Orm's half-human, half-Atlantean brother and true heir to the throne. With help from royal counselor Vulko, Aquaman must retrieve the legendary Trident of Atlan and embrace his destiny as protector of the deep.", ReleaseDate=DateTime.Parse("12/12/2018"), Rating="5", TrailerUrl="https://www.youtube.com/watch?v=2wcj6SrX4zw",ImageUrl="https://media-cache.cinematerial.com/p/500x/bokjl734/aquaman-movie-poster.jpg?v=1542736450"},
				new Movie() {Id=5, Title ="1917", Synopsis="April 6, 1917. On a battlefield in Northern France, Lance Corporal Tom Blake with the British Army is asked to choose one of his battalion colleagues to join him on an assignment, he choosing his best friend, Lance Corporal Will Schofield. It isn't until Blake chooses Schofield that they learn of the dangerous nature of the mission: to hand deliver a message to Colonel MacKenzie leading another nearby battalion, they having to cross no man's land to what they have been told are now the abandoned German trenches to get to MacKenzie just past the nearby town of Écoust.", ReleaseDate=DateTime.Parse("10/1/2020"), Rating="5", TrailerUrl="https://www.youtube.com/watch?v=YqNYrYUiMfg",ImageUrl="https://media-cache.cinematerial.com/p/500x/haeorwgk/1917-british-movie-poster.jpg?v=1579166770"},
				new Movie() {Id=6, Title ="Godzilla: King of Monsters", Synopsis="Members of the crypto-zoological agency Monarch face off against a battery of god-sized monsters, including the mighty Godzilla, who collides with Mothra, Rodan, and his ultimate nemesis, the three-headed King Ghidorah. When these ancient super-species-thought to be mere myths-rise again, they all vie for supremacy, leaving humanity's very existence hanging in the balance.", ReleaseDate=DateTime.Parse("13/05/2019"), Rating="5", TrailerUrl="https://www.youtube.com/watch?v=QFxN2oDKk0E",ImageUrl="https://media-cache.cinematerial.com/p/500x/dyf4wh2r/godzilla-king-of-the-monsters-movie-poster.jpg?v=1558985734"}
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
				movie.TrailerUrl = MovieUpdates.TrailerUrl;
				movie.ImageUrl = MovieUpdates.ImageUrl;
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

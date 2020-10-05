using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfoFlix.Migrations
{
    public partial class MoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "ImageUrl", "Rating", "ReleaseDate", "Synopsis", "Title", "TrailerUrl" },
                values: new object[,]
                {
                    { 2, "https://media-cache.cinematerial.com/p/500x/sjvehuzs/logan-theatrical-movie-poster.jpg?v=1487207987", "5", new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the near future, a weary Logan (Hugh Jackman) cares for an ailing Professor X (Patrick Stewart) at a remote outpost on the Mexican border. His plan to hide from the outside world gets upended when he meets a young mutant (Dafne Keen) who is very much like him. Logan must now protect the girl and battle the dark forces that want to capture her.", "Logan", "https://www.youtube.com/watch?v=Div0iP65aZo" },
                    { 3, "https://media-cache.cinematerial.com/p/500x/iqo9ujpt/the-kings-man-movie-poster.jpg?v=1592763997", "5", new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gary Eggsy Unwin (Taron Egerton), whose late father secretly worked for a spy organization, lives in a South London housing estate and seems headed for a life behind bars. However, dapper agent Harry Hart (Colin Firth) recognizes potential in the youth and recruits him to be a trainee in the secret service. Meanwhile, villainous Richmond Valentine (Samuel L. Jackson) launches a diabolical plan to solve the problem of climate change via a worldwide killing spree.", "The Kingsman", "https://www.youtube.com/watch?v=5zdBG-iGfes" },
                    { 4, "https://media-cache.cinematerial.com/p/500x/bokjl734/aquaman-movie-poster.jpg?v=1542736450", "5", new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Once home to the most advanced civilization on Earth, the city of Atlantis is now an underwater kingdom ruled by the power-hungry King Orm. With a vast army at his disposal, Orm plans to conquer the remaining oceanic people -- and then the surface world. Standing in his way is Aquaman, Orm's half-human, half-Atlantean brother and true heir to the throne. With help from royal counselor Vulko, Aquaman must retrieve the legendary Trident of Atlan and embrace his destiny as protector of the deep.", "Aquaman", "https://www.youtube.com/watch?v=2wcj6SrX4zw" },
                    { 5, "https://media-cache.cinematerial.com/p/500x/haeorwgk/1917-british-movie-poster.jpg?v=1579166770", "5", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "April 6, 1917. On a battlefield in Northern France, Lance Corporal Tom Blake with the British Army is asked to choose one of his battalion colleagues to join him on an assignment, he choosing his best friend, Lance Corporal Will Schofield. It isn't until Blake chooses Schofield that they learn of the dangerous nature of the mission: to hand deliver a message to Colonel MacKenzie leading another nearby battalion, they having to cross no man's land to what they have been told are now the abandoned German trenches to get to MacKenzie just past the nearby town of Écoust.", "1917", "https://www.youtube.com/watch?v=YqNYrYUiMfg" },
                    { 6, "https://media-cache.cinematerial.com/p/500x/dyf4wh2r/godzilla-king-of-the-monsters-movie-poster.jpg?v=1558985734", "5", new DateTime(2019, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Members of the crypto-zoological agency Monarch face off against a battery of god-sized monsters, including the mighty Godzilla, who collides with Mothra, Rodan, and his ultimate nemesis, the three-headed King Ghidorah. When these ancient super-species-thought to be mere myths-rise again, they all vie for supremacy, leaving humanity's very existence hanging in the balance.", "Godzilla: King of Monsters", "https://www.youtube.com/watch?v=QFxN2oDKk0E" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "ImageUrl", "Rating", "ReleaseDate", "Synopsis", "Title", "TrailerUrl" },
                values: new object[] { 1, "https://media-cache.cinematerial.com/p/500x/dq0gglvi/john-wick-chapter-3-parabellum-advance-movie-poster.jpg?v=1547571738", "5", new DateTime(2015, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Legendary assassin John Wick (Keanu Reeves) retired from his violent career after marrying the love of his life. Her sudden death leaves John in deep mourning. When sadistic mobster Iosef Tarasov (Alfie Allen) and his thugs steal John's prized car and kill the puppy that was a last gift from his wife, John unleashes the remorseless killing machine within and seeks vengeance. Meanwhile, Iosef's father (Michael Nyqvist) -- John's former colleague -- puts a huge bounty on John's head.", "John Whick", "https://www.youtube.com/watch?v=2AUmvWm5ZDQ" });
        }
    }
}

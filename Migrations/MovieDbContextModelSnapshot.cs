﻿// <auto-generated />
using System;
using InfoFlix.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InfoFlix.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InfoFlix.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Synopsis")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://media-cache.cinematerial.com/p/500x/sjvehuzs/logan-theatrical-movie-poster.jpg?v=1487207987",
                            Rating = "5",
                            ReleaseDate = new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Synopsis = "In the near future, a weary Logan (Hugh Jackman) cares for an ailing Professor X (Patrick Stewart) at a remote outpost on the Mexican border. His plan to hide from the outside world gets upended when he meets a young mutant (Dafne Keen) who is very much like him. Logan must now protect the girl and battle the dark forces that want to capture her.",
                            Title = "Logan",
                            TrailerUrl = "https://www.youtube.com/watch?v=Div0iP65aZo"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://media-cache.cinematerial.com/p/500x/iqo9ujpt/the-kings-man-movie-poster.jpg?v=1592763997",
                            Rating = "5",
                            ReleaseDate = new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Synopsis = "Gary Eggsy Unwin (Taron Egerton), whose late father secretly worked for a spy organization, lives in a South London housing estate and seems headed for a life behind bars. However, dapper agent Harry Hart (Colin Firth) recognizes potential in the youth and recruits him to be a trainee in the secret service. Meanwhile, villainous Richmond Valentine (Samuel L. Jackson) launches a diabolical plan to solve the problem of climate change via a worldwide killing spree.",
                            Title = "The Kingsman",
                            TrailerUrl = "https://www.youtube.com/watch?v=5zdBG-iGfes"
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "https://media-cache.cinematerial.com/p/500x/bokjl734/aquaman-movie-poster.jpg?v=1542736450",
                            Rating = "5",
                            ReleaseDate = new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Synopsis = "Once home to the most advanced civilization on Earth, the city of Atlantis is now an underwater kingdom ruled by the power-hungry King Orm. With a vast army at his disposal, Orm plans to conquer the remaining oceanic people -- and then the surface world. Standing in his way is Aquaman, Orm's half-human, half-Atlantean brother and true heir to the throne. With help from royal counselor Vulko, Aquaman must retrieve the legendary Trident of Atlan and embrace his destiny as protector of the deep.",
                            Title = "Aquaman",
                            TrailerUrl = "https://www.youtube.com/watch?v=2wcj6SrX4zw"
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "https://media-cache.cinematerial.com/p/500x/haeorwgk/1917-british-movie-poster.jpg?v=1579166770",
                            Rating = "5",
                            ReleaseDate = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Synopsis = "April 6, 1917. On a battlefield in Northern France, Lance Corporal Tom Blake with the British Army is asked to choose one of his battalion colleagues to join him on an assignment, he choosing his best friend, Lance Corporal Will Schofield. It isn't until Blake chooses Schofield that they learn of the dangerous nature of the mission: to hand deliver a message to Colonel MacKenzie leading another nearby battalion, they having to cross no man's land to what they have been told are now the abandoned German trenches to get to MacKenzie just past the nearby town of Écoust.",
                            Title = "1917",
                            TrailerUrl = "https://www.youtube.com/watch?v=YqNYrYUiMfg"
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "https://media-cache.cinematerial.com/p/500x/dyf4wh2r/godzilla-king-of-the-monsters-movie-poster.jpg?v=1558985734",
                            Rating = "5",
                            ReleaseDate = new DateTime(2019, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Synopsis = "Members of the crypto-zoological agency Monarch face off against a battery of god-sized monsters, including the mighty Godzilla, who collides with Mothra, Rodan, and his ultimate nemesis, the three-headed King Ghidorah. When these ancient super-species-thought to be mere myths-rise again, they all vie for supremacy, leaving humanity's very existence hanging in the balance.",
                            Title = "Godzilla: King of Monsters",
                            TrailerUrl = "https://www.youtube.com/watch?v=QFxN2oDKk0E"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfoFlix.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Movie",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "ImageUrl", "Rating", "ReleaseDate", "Synopsis", "Title", "TrailerUrl" },
                values: new object[] { 1, "https://media-cache.cinematerial.com/p/500x/dq0gglvi/john-wick-chapter-3-parabellum-advance-movie-poster.jpg?v=1547571738", "5", new DateTime(2015, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Legendary assassin John Wick (Keanu Reeves) retired from his violent career after marrying the love of his life. Her sudden death leaves John in deep mourning. When sadistic mobster Iosef Tarasov (Alfie Allen) and his thugs steal John's prized car and kill the puppy that was a last gift from his wife, John unleashes the remorseless killing machine within and seeks vengeance. Meanwhile, Iosef's father (Michael Nyqvist) -- John's former colleague -- puts a huge bounty on John's head.", "John Whick", "https://www.youtube.com/watch?v=2AUmvWm5ZDQ" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Movie",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

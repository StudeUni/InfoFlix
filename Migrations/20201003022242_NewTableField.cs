using Microsoft.EntityFrameworkCore.Migrations;

namespace InfoFlix.Migrations
{
    public partial class NewTableField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrailerUrl",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrailerUrl",
                table: "Movie");
        }
    }
}

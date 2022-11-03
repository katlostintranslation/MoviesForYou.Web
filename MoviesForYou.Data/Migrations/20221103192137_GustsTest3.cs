using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesForYou.Data.Migrations
{
    public partial class GustsTest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeywordId",
                table: "Movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KeywordId",
                table: "Movies",
                type: "int",
                nullable: true);
        }
    }
}

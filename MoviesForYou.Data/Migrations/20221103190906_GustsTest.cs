using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesForYou.Data.Migrations
{
    public partial class GustsTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieTitle",
                table: "Keywords");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieTitle",
                table: "Keywords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

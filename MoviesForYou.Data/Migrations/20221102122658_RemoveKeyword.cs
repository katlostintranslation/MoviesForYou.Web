using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesForYou.Data.Migrations
{
    public partial class RemoveKeyword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Keywords_KeywordId",
                table: "Movies");

            migrationBuilder.AlterColumn<int>(
                name: "KeywordId",
                table: "Movies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Keywords_KeywordId",
                table: "Movies",
                column: "KeywordId",
                principalTable: "Keywords",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Keywords_KeywordId",
                table: "Movies");

            migrationBuilder.AlterColumn<int>(
                name: "KeywordId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Keywords_KeywordId",
                table: "Movies",
                column: "KeywordId",
                principalTable: "Keywords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

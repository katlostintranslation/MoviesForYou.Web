using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesForYou.Data.Migrations
{
    public partial class GustsTest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Keywords_KeywordId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_KeywordId",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "KeywordMovie",
                columns: table => new
                {
                    KeywordsId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeywordMovie", x => new { x.KeywordsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_KeywordMovie_Keywords_KeywordsId",
                        column: x => x.KeywordsId,
                        principalTable: "Keywords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeywordMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KeywordMovie_MoviesId",
                table: "KeywordMovie",
                column: "MoviesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeywordMovie");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_KeywordId",
                table: "Movies",
                column: "KeywordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Keywords_KeywordId",
                table: "Movies",
                column: "KeywordId",
                principalTable: "Keywords",
                principalColumn: "Id");
        }
    }
}

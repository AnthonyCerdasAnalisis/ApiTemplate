using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiTemplate.Migrations
{
    public partial class AddToDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Movies",
                newName: "GenreIdGenre");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "IdMovie");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                newName: "IX_Movies_GenreIdGenre");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Genres",
                newName: "IdGenre");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_GenreIdGenre",
                table: "Movies",
                column: "GenreIdGenre",
                principalTable: "Genres",
                principalColumn: "IdGenre",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_GenreIdGenre",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "GenreIdGenre",
                table: "Movies",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "IdMovie",
                table: "Movies",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_GenreIdGenre",
                table: "Movies",
                newName: "IX_Movies_GenreId");

            migrationBuilder.RenameColumn(
                name: "IdGenre",
                table: "Genres",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

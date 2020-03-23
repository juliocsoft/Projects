using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GTSharp.Domain.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMovie = table.Column<int>(nullable: false),
                    Budget = table.Column<decimal>(nullable: false),
                    OriginalTitle = table.Column<string>(type: "varchar(300)", nullable: true),
                    Overview = table.Column<string>(nullable: true),
                    Popularity = table.Column<decimal>(nullable: false),
                    PosterPath = table.Column<string>(type: "varchar(200)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    VoteAverage = table.Column<double>(nullable: false),
                    VoteCount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(type: "varchar(160)", nullable: true),
                    Done = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "varchar(120)", nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGenre = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    MovieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genre_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genre_IdGenre",
                table: "Genre",
                column: "IdGenre");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_MovieId",
                table: "Genre",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_OriginalTitle",
                table: "Movie",
                column: "OriginalTitle");

            migrationBuilder.CreateIndex(
                name: "IX_Todo_User",
                table: "Todo",
                column: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Todo");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}

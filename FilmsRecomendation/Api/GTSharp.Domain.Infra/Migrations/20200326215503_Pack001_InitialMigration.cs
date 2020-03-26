using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GTSharp.Domain.Infra.Migrations
{
    public partial class Pack001_InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    IdMovie = table.Column<int>(nullable: false),
                    Budget = table.Column<decimal>(type: "decimal(10,0)", nullable: false),
                    OriginalTitle = table.Column<string>(maxLength: 400, nullable: true),
                    Popularity = table.Column<decimal>(type: "decimal(10,0)", nullable: false),
                    PosterPath = table.Column<string>(maxLength: 100, nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    VoteAverage = table.Column<double>(nullable: false),
                    VoteCount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.IdMovie);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    IdGenre = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 400, nullable: true),
                    MovieIdMovie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.IdGenre);
                    table.ForeignKey(
                        name: "FK_Genre_Movie_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "Movie",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Overview",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    MovieIdMovie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Overview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Overview_Movie_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "Movie",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genre_MovieIdMovie",
                table: "Genre",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_Overview_MovieIdMovie",
                table: "Overview",
                column: "MovieIdMovie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Overview");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}

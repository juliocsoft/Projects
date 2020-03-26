using Microsoft.EntityFrameworkCore.Migrations;

namespace GTSharp.Domain.Infra.Migrations
{
    public partial class Pack001_Overiview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Overview",
                columns: table => new
                {
                    IdOverview = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 400, nullable: true),
                    MovieIdMovie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Overview", x => x.IdOverview);
                    table.ForeignKey(
                        name: "FK_Overview_Movie_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "Movie",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Overview_MovieIdMovie",
                table: "Overview",
                column: "MovieIdMovie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Overview");
        }
    }
}

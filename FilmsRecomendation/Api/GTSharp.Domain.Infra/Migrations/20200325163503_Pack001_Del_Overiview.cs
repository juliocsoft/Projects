using Microsoft.EntityFrameworkCore.Migrations;

namespace GTSharp.Domain.Infra.Migrations
{
    public partial class Pack001_Del_Overiview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Overview",
                table: "Movie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Overview",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

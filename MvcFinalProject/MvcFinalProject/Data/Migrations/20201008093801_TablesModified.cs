using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcFinalProject.Data.Migrations
{
    public partial class TablesModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "HomeTeamItems");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "HomeTeamItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "HomeTeamItems",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "HomeTeamItems",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcFinalProject.Data.Migrations
{
    public partial class ProjectPricingHaveBeenUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Header",
                table: "ProjectPricings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Header",
                table: "ProjectPricings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

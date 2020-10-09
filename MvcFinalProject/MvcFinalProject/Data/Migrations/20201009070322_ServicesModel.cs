using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcFinalProject.Data.Migrations
{
    public partial class ServicesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactServicess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    Header = table.Column<string>(nullable: true),
                    HeaderConten1 = table.Column<string>(nullable: true),
                    HeaderConten2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactServicess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromoServicess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoServicess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolutionServicesItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionServicesItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolutionServicess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionServicess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrafficServicesItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrafficServicesItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrafficServicess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrafficServicess", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactServicess");

            migrationBuilder.DropTable(
                name: "PromoServicess");

            migrationBuilder.DropTable(
                name: "SolutionServicesItems");

            migrationBuilder.DropTable(
                name: "SolutionServicess");

            migrationBuilder.DropTable(
                name: "TrafficServicesItems");

            migrationBuilder.DropTable(
                name: "TrafficServicess");
        }
    }
}

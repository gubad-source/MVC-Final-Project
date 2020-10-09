using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcFinalProject.Data.Migrations
{
    public partial class AboutUsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutusPromos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutusPromos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamAboutusItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 30, nullable: true),
                    Position = table.Column<string>(maxLength: 50, nullable: true),
                    Photo = table.Column<string>(maxLength: 100, nullable: true),
                    Facebook = table.Column<string>(maxLength: 50, nullable: true),
                    Linkedin = table.Column<string>(maxLength: 50, nullable: true),
                    Dribble = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamAboutusItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamAboutuss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamAboutuss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestimonialAboutusItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    FullName = table.Column<string>(maxLength: 30, nullable: true),
                    Star = table.Column<byte>(nullable: false),
                    Position = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestimonialAboutusItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestimonialAboutuss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestimonialAboutuss", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutusPromos");

            migrationBuilder.DropTable(
                name: "TeamAboutusItems");

            migrationBuilder.DropTable(
                name: "TeamAboutuss");

            migrationBuilder.DropTable(
                name: "TestimonialAboutusItems");

            migrationBuilder.DropTable(
                name: "TestimonialAboutuss");
        }
    }
}

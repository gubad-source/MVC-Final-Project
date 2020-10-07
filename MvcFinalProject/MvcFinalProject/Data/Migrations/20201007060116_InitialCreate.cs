using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcFinalProject.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeAboutUss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeAboutUss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeBlogItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeBlogItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeBlogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeBlogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeDownloads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeDownloads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    Header = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeHeaders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePortfolioItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    Heading = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePortfolioItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePortfolios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePortfolios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePromos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePromos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeServicesItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeServicesItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeServicess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeServicess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeTeamItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true),
                    Dribble = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeTeamItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeTeams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeTeams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeTestimonialItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Star = table.Column<byte>(nullable: false),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeTestimonialItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeTestimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 300, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeTestimonials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeAboutUss");

            migrationBuilder.DropTable(
                name: "HomeBlogItems");

            migrationBuilder.DropTable(
                name: "HomeBlogs");

            migrationBuilder.DropTable(
                name: "HomeDownloads");

            migrationBuilder.DropTable(
                name: "HomeHeaders");

            migrationBuilder.DropTable(
                name: "HomePortfolioItems");

            migrationBuilder.DropTable(
                name: "HomePortfolios");

            migrationBuilder.DropTable(
                name: "HomePromos");

            migrationBuilder.DropTable(
                name: "HomeServicesItems");

            migrationBuilder.DropTable(
                name: "HomeServicess");

            migrationBuilder.DropTable(
                name: "HomeTeamItems");

            migrationBuilder.DropTable(
                name: "HomeTeams");

            migrationBuilder.DropTable(
                name: "HomeTestimonialItems");

            migrationBuilder.DropTable(
                name: "HomeTestimonials");
        }
    }
}

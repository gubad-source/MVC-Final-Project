using Microsoft.EntityFrameworkCore;
using MvcFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcFinalProject.Models.ViewModels;


namespace MvcFinalProject.Data
{
    public class CorporXContext:DbContext
    {
        public CorporXContext(DbContextOptions<CorporXContext> options) : base(options)
        {

        }
        public DbSet<HomeAboutUs> HomeAboutUss { get; set; }
        public DbSet<HomeBlog> HomeBlogs { get; set; }
        public DbSet<HomeBlogItem> HomeBlogItems { get; set; }
        public DbSet<HomeDownload> HomeDownloads { get; set; }
        public DbSet<HomeHeader> HomeHeaders { get; set; }
        public DbSet<HomePortfolio> HomePortfolios { get; set; }
        public DbSet<HomePortfolioItem> HomePortfolioItems { get; set; }
        public DbSet<HomePromo> HomePromos { get; set; }
        public DbSet<HomeServices> HomeServicess { get; set; }
        public DbSet<HomeServicesItem> HomeServicesItems { get; set; }
        public DbSet<HomeTeam> HomeTeams { get; set; }
        public DbSet<HomeTeamItem> HomeTeamItems { get; set; }
        public DbSet<HomeTestimonial> HomeTestimonials { get; set; }
        public DbSet<HomeTestimonialItem> HomeTestimonialItems { get; set; }

    }
  

}

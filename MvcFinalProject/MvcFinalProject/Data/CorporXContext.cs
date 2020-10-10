﻿using Microsoft.EntityFrameworkCore;
using MvcFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcFinalProject.Models.ViewModels;
using MvcFinalProject.Models.Services;
using MvcFinalProject.Models.Aboutus;
using MvcFinalProject.Models.Blog;
using MvcFinalProject.Models.FAQ;

namespace MvcFinalProject.Data
{
    public class CorporXContext:DbContext
    {
        public CorporXContext(DbContextOptions<CorporXContext> options) : base(options)
        {

        }
        ///Home DbSets
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

        ///Services Dbsets
        public DbSet<ContactServices>  ContactServicess { get; set; }
        public DbSet<PromoServices>  PromoServicess { get; set; }
        public DbSet<SolutionServices> SolutionServicess { get; set; }
        public DbSet<SolutionServicesItem> SolutionServicesItems { get; set; }
        public DbSet<TrafficServices> TrafficServicess { get; set; }
        public DbSet<TrafficServicesItem> TrafficServicesItems { get; set; }

        ///Aboutus DbSets
        public DbSet<AboutusPromo>AboutusPromos { get; set; }
        ///Blog DbSet
        public DbSet<BlogItem> BlogItems { get; set; }
        ///FAQ Dbset
        public DbSet<FAQItem> FAQItems { get; set; }
        public DbSet<FAQPromo> FAQPromos { get; set; }
    }
  

}

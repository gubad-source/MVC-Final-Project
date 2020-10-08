using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models.ViewModels
{
    public class HomeViewModel
    {
        public HomeAboutUs HomeAboutUs { get; set; }
        public HomeBlog HomeBlog { get; set; }
        public List<HomeBlogItem> HomeBlogItem { get; set; }
        public HomeDownload HomeDownload { get; set; }
        public HomeHeader HomeHeader { get; set; }
        
        public HomePortfolio HomePortfolio { get; set; }
        public HomePortfolioItem HomePortfolioItem { get; set; }
        public List<HomePromo>  HomePromo { get; set; }
        public HomeServices HomeServices { get; set; }
        public HomeServicesItem HomeServicesItem { get; set; }
        public HomeTeam HomeTeam { get; set; }
        public List<HomeTeamItem> HomeTeamItem { get; set; }
        public HomeTestimonial HomeTestimonial { get; set; }
        public List<HomeTestimonialItem>  HomeTestimonialItem { get; set; }
    }
}

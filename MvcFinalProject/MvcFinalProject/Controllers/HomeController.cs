using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcFinalProject.Data;
using MvcFinalProject.Models;
using MvcFinalProject.Models.ViewModels;

namespace MvcFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CorporXContext _context;
        

        public HomeController(ILogger<HomeController> logger,
                              CorporXContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                HomeAboutUs = _context.HomeAboutUss.FirstOrDefault(),
                HomeBlog=_context.HomeBlogs.FirstOrDefault(),
                HomeBlogItem=_context.HomeBlogItems.ToList(),
                HomeDownload=_context.HomeDownloads.FirstOrDefault(),
                HomeHeader=_context.HomeHeaders.FirstOrDefault(),
                HomePortfolio=_context.HomePortfolios.FirstOrDefault(),
                HomePortfolioItem=_context.HomePortfolioItems.FirstOrDefault(),
                HomePromo=_context.HomePromos.ToList(),
                HomeServices=_context.HomeServicess.FirstOrDefault(),
                HomeServicesItem=_context.HomeServicesItems.FirstOrDefault(),
                HomeTeam=_context.HomeTeams.FirstOrDefault(),
                HomeTeamItem=_context.HomeTeamItems.ToList(),
                HomeTestimonial=_context.HomeTestimonials.FirstOrDefault(),
                HomeTestimonialItem=_context.HomeTestimonialItems.ToList()
            };
            return View(homeViewModel);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}

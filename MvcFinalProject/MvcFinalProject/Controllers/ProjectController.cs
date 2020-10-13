using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcFinalProject.Data;
using MvcFinalProject.Models;
using MvcFinalProject.Models.Projects;
using MvcFinalProject.Models.ViewModels;

namespace MvcFinalProject.Controllers
{
    
    public class ProjectController : Controller
       
    {
        private readonly CorporXContext _context;
        public ProjectController(CorporXContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ProjectViewModels projectViewModels = new ProjectViewModels
            {
                ProjectPricing = _context.ProjectPricings.ToList(),
                heroViewModel=new HeroViewModel
                {
                    Title= "Our Projects",
                    Links = new List<string> {
                        "Home",
                        "Projects"
                    }
                }

            };
            return View(projectViewModels);
        }
        public IActionResult Detail()
        {
            ProjectViewModels projectViewModels = new ProjectViewModels
            {
                ProjectDetail = _context.ProjectDetails.FirstOrDefault(),
                heroViewModel=new HeroViewModel
                {
                    Title= "Project Details",
                    Links=new List<string>
                    {
                        "Home",
                        "Pages",
                        "Project Details"
                    }
                }
            };
            return View(projectViewModels);
        }
      
    }
}


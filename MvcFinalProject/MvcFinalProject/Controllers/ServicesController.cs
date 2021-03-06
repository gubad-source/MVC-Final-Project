﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcFinalProject.Data;
using MvcFinalProject.Models;
using MvcFinalProject.Models.ViewModels;

namespace MvcFinalProject.Controllers
{
    public class ServicesController : Controller
    {
        private readonly CorporXContext _context;
        public ServicesController(CorporXContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ServicesViewModels servicesViewModels = new ServicesViewModels
            {
                ContactServices = _context.ContactServicess.FirstOrDefault(),
                PromoServices=_context.PromoServicess.ToList(),
                SolutionServices=_context.SolutionServicess.FirstOrDefault(),
                SolutionServicesItem=_context.SolutionServicesItems.ToList(),
                TrafficServices=_context.TrafficServicess.FirstOrDefault(),
                TrafficServicesItem=_context.TrafficServicesItems.ToList(),
                heroViewModel=new HeroViewModel
                {
                    Title= "Our Services",
                    Links=new List<string>
                    {
                        "Home",
                        "Pages",
                        "Services"
                    }
                }
            };
            return View(servicesViewModels);
        }
        public IActionResult Detail()
        {
            ServicesViewModels servicesViewModels = new ServicesViewModels
            {
                ServicesDetail=_context.ServicesDetails.FirstOrDefault()
            };
            return View(servicesViewModels);
        }
           
        
    }
}

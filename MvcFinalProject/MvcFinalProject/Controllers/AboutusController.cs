﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcFinalProject.Data;
using MvcFinalProject.Models.ViewModels;

namespace MvcFinalProject.Controllers
{
    public class AboutusController : Controller
    {
        private readonly CorporXContext _context;
        public AboutusController(CorporXContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AboutusViewModels aboutUsViewModels = new AboutusViewModels
            {
                AboutusPromo = _context.AboutusPromos.ToList()
               
            };
            return View();
        }
    }
}

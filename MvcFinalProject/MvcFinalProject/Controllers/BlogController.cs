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
    public class BlogController : Controller
    {
        private readonly CorporXContext _context;
        public BlogController(CorporXContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            BlogViewModels blogViewModels = new BlogViewModels
            {
                BlogItem = _context.BlogItems.ToList(),

            heroViewModel=new HeroViewModel
            {
                Title= "Blog Default",
                Links = new List<string>
                {
                    "Home",
                    "Blog",
                    "Blog Default"
                }
            }
            };
            return View(blogViewModels);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}

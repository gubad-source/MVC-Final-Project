﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcFinalProject.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
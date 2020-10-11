using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcFinalProject.Data;
using MvcFinalProject.Models;
using MvcFinalProject.Models.ViewModels;

namespace MvcFinalProject.Controllers
{
    public class FaqController : Controller
    {
        private readonly CorporXContext _context;
        public FaqController(CorporXContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            FAQViewModels faqViewModels = new FAQViewModels
            {
                FAQItem = _context.FAQItems.ToList(),
                FaqPromo=_context.FAQPromos.ToList(),
                heroViewModel=new HeroViewModel
                {
                    Title= "FAQ Page",
                    Links=new List<string>
                    {
                        "Home",
                        "Pages",
                        "FAQ"
                    }
                }
            };
            return View(faqViewModels);
        }
    }
}

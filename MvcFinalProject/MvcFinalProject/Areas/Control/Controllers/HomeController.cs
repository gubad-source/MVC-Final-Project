using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcFinalProject.Data;
using MvcFinalProject.Models;



namespace MvcFinalProject.Areas.Control.Controllers
{
    [Area("control")]
    public class HomeController : Controller
    {
        private readonly CorporXContext _context;
        public HomeController (CorporXContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            
            return View();
        }
        public IActionResult AdminPanel()
        {
            var homeBlogItems = _context.HomeBlogItems.ToList();

            return View(homeBlogItems);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int Id,string Title,string Content,string Photo,string Label)
        {
            HomeBlogItem homeBlogItem = new HomeBlogItem
            {
                Id=Id,
                Title=Title,
                Content=Content,
                Photo=Photo,
                Label=Label
            };
            _context.HomeBlogItems.Add(homeBlogItem);
            _context.SaveChanges();
            return RedirectToAction("adminpanel");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var homeBlogItems = _context.HomeBlogItems.Find(Id);
            if (homeBlogItems == null) return NotFound();
            return View(homeBlogItems);
        }
        [HttpPost]
        public IActionResult Edit(int Id,string Photo,string Title,string Content,string Label)
        {
            var homeBlogItems = _context.HomeBlogItems.Find(Id);
            if (homeBlogItems == null) return NotFound();
            homeBlogItems.Title = Title;
            homeBlogItems.Content = Content;
            homeBlogItems.Label = Label;
            homeBlogItems.Photo = Photo;
            _context.SaveChanges();
            return RedirectToAction("adminpanel");
        }

        public IActionResult Delete(int Id)
        {
            var homeBlogItems = _context.HomeBlogItems.Find(Id);
            if (homeBlogItems == null) return NotFound();
            _context.HomeBlogItems.Remove(homeBlogItems);
            _context.SaveChanges();
            return RedirectToAction("adminpanel");
        }
    }
}

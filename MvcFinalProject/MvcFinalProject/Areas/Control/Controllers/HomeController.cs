using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CryptoHelper;
using Microsoft.AspNetCore.Mvc;
using MvcFinalProject.Data;
using MvcFinalProject.Filters;
using MvcFinalProject.Models;
using MvcFinalProject.Models.Login;

namespace MvcFinalProject.Areas.Control.Controllers
{
    [Area("Control")]
    //[TypeFilter(typeof(Auth))]
    public class HomeController : Controller
    {
        private User user => RouteData.Values["User"] as User;
        private readonly CorporXContext _context;
        public HomeController (CorporXContext context)
        {
            _context = context;
        }
        [TypeFilter(typeof(Auth))]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (_context.Users.Any(u => u.Email == model.Email))
            {
                ModelState.AddModelError("Email", "bele email movcuddur");
            }
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Fullname=model.Fullname,
                    Email=model.Email,
                    Password = Crypto.HashPassword(model.Password)
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("index","home", new { area = "control" });
            }
            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _context.Users.FirstOrDefault(u => u.Email == model.Email);
                if(user != null)
                {
                    if(Crypto.VerifyHashedPassword(user.Password,model.Password))
                    {
                        user.Token = Guid.NewGuid().ToString();
                        _context.SaveChanges();
                        Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                        {
                            Expires = DateTime.Now.AddDays(365),
                            HttpOnly = true
                        });
                        return RedirectToAction("adminpanel","home", new { area = "control" });
                    }
                }
                ModelState.AddModelError("Password", "E-poçt və ya şifrə yanlışdır");
            }
            return View(model);
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
        public IActionResult Create(int Id, string Title, string Content, string Photo, string Label)
        {
            HomeBlogItem homeBlogItem = new HomeBlogItem
            {
                Id = Id,
                Title = Title,
                Content = Content,
                Photo = Photo,
                Label = Label
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
        public IActionResult Edit(int Id, string Photo, string Title, string Content, string Label)
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

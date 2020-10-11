using MvcFinalProject.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models.ViewModels
{
    public class BlogViewModels
    {
        public List<BlogItem> BlogItem { get; set; }
        public HeroViewModel heroViewModel { get; set; }
    }
}

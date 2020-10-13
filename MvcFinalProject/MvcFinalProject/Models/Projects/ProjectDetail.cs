using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models.Projects
{
    public class ProjectDetail
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Content3 { get; set; }
        public HeroViewModel heroViewModel { get; set; }
    }
}

using MvcFinalProject.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models.ViewModels
{
    public class ProjectViewModels
    {
        public List<ProjectPricing> ProjectPricing { get; set; }
        public ProjectDetail ProjectDetail { get; set; }
        public HeroViewModel heroViewModel { get; set; }
    }
}

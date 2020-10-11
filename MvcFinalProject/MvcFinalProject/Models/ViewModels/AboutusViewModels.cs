using MvcFinalProject.Models.Aboutus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models.ViewModels
{
    public class AboutusViewModels
    {
        public List<AboutusPromo> AboutusPromo { get; set; }
        public HeroViewModel heroViewModel { get; set; }

    }
}

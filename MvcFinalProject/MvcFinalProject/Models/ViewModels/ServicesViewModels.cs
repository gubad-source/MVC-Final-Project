using MvcFinalProject.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models.ViewModels
{
    public class ServicesViewModels
    {
        public ContactServices ContactServices { get; set; }
        public List<PromoServices>  PromoServices { get; set; }
        public  SolutionServices SolutionServices { get; set; }
        public List <SolutionServicesItem>  SolutionServicesItem { get; set; }
        public TrafficServices TrafficServices { get; set; }
        public List<TrafficServicesItem> TrafficServicesItem { get; set; }
        public ServicesDetail ServicesDetail { get; set; }
        public HeroViewModel heroViewModel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models
{
    [NotMapped]
    public class HeroViewModel
    {
        public string Title { get; set; }
        public List<string> Links { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models
{
    public class HomePortfolioItem:BaseEntity
    {
        //public int Id { get; set; }
        //public string Title { get; set; }
        [MaxLength(30)]
        public string Heading { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
    }
}

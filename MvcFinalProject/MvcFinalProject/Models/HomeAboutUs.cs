using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models
{
    public class HomeAboutUs:BaseEntity
    {

        [MaxLength(50)]
        public string Details { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
    }
}

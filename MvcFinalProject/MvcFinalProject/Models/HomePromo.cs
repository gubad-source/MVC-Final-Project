using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models
{
    public class HomePromo:BaseEntity
    {
        [MaxLength(50)]
        public string Text { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models
{
    public class HomeHeader:BaseEntity
    {
        [MaxLength(50)]
        public string Header { get; set; }
       
    }
}

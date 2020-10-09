using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models
{
    public class HomeBlogItem:BaseEntity
    {
        [MaxLength(30)]
        public string Label { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
    }
}

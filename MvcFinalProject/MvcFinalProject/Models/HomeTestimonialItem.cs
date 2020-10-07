using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models
{
    public class HomeTestimonialItem:BaseEntity
    {
        //public int Id { get; set; }
        //public string Content { get; set; }

        [MaxLength(30)]
        public string FullName { get; set; }
        public byte Star { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models
{
    public class HomeTestimonialItem
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Content { get; set; }
        public byte Star { get; set; }
        public string Position { get; set; }
    }
}

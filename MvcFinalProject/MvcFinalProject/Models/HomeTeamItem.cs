using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models
{
    public class HomeTeamItem:BaseEntity
    {
        //public int Id { get; set; }
        //public string Content { get; set; }
        [MaxLength(30)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
        [MaxLength(50)]
        public string Facebook { get; set; }
        [MaxLength(50)]
        public string Linkedin { get; set; }
        [MaxLength(50)]
        public string Dribble { get; set; }
    }
}

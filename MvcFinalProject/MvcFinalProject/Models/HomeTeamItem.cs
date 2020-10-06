using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models
{
    public class HomeTeamItem
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }

        public string Dribble { get; set; }
    }
}

using MvcFinalProject.Models.FAQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Models.ViewModels
{
    public class FAQViewModels
    {
        public List<FAQItem> FAQItem { get; set; }
        public List<FAQPromo> FaqPromo { get; set; }
    }
}

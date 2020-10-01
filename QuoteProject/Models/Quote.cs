using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteProject.Models
{
    public class Quote
    {
        public string Text { get; set; }
        public DateTime DateofPost { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}

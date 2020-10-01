using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteProject.Models
{
    public class Tag
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public ICollection<QuoteTag> QuoteTags { get; set; }
    }
    public enum Category
    {
        prvni,
        druhy,
        treti,
        ctvrty
    }
}

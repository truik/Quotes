using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuoteProject.Models
{
    public class Quote
    {
        [Key]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime DateofPost { get; set; }
        [JsonIgnore]
        public ICollection<QuoteTag> QuoteTags { get; set; }
    }
}

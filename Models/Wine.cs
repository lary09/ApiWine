using System.ComponentModel.DataAnnotations.Schema;

namespace APIWine.Models
{
    [Table(nameof(Wine))]
    public class Wine
    {
        public long id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? CountryCode { get; set; }
        public int Type { get; set; }
        public DateTime Year { get; set; }
    }
}   
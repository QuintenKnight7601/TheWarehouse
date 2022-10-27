using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWarehouse.Models
{
    public class Warehouse
    {
        [Key]
        [ForeignKey("Company")]
        public string? CompanyId { get; set; }

        public virtual ICollection<Record>? Records { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
        public virtual ICollection<Category>? Categories { get; set; }
    }
}

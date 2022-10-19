using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWarehouse.Models
{
    public class Warehouse
    {
        public int Id { get; set; }

        [Key]
        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
        public virtual ICollection<Category>? Categories { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWarehouse.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Warehouse")]
        public string? WarehouseId { get; set; }
        [Required]
        public int Name { get; set; }

        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}

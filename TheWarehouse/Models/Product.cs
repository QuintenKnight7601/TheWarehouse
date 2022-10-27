using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWarehouse.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Warehouse")]
        public string? WarehouseId { get; set; }
        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [Required]
        public string? ProductName { get; set; }

        public virtual Warehouse? Warehouse { get; set; }
        public virtual Category? Category { get; set; }
    }
}

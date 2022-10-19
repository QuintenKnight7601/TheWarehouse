using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWarehouse.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string? Name { get; set; }

        [Key]
        [ForeignKey("Warehouse")]
        public string? WarehouseId { get; set; }

        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}

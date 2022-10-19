using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWarehouse.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Key]
        [ForeignKey("Warehouse")]
        public string? WarehouseId { get; set; }

        [Key]
        [ForeignKey("Category")]
        public string? CategoryId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string? Name { get; set; }

        public int Amount { get; set; }
        public int Sold { get; set; }
        public int Loss { get; set; }

        [DataType(DataType.Currency)]
        public int Price { get; set; }

        public virtual Warehouse? Warehouse { get; set; }
        public virtual Category? Category { get; set; }
    }
}

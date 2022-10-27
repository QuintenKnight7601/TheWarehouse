using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWarehouse.Models
{
    public class ProductRecord
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Record")]
        public int RecordId { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public int Sold { get; set; }
        public int Lost { get; set; }

        public virtual Record? Record { get; set; }
        public virtual Product? Product { get; set; }
    }
}

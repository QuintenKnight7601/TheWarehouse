using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWarehouse.Models
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Warehouse")]
        public string? WarehouseId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<ProductRecord>? ProductRecords { get; set; }
    }
}

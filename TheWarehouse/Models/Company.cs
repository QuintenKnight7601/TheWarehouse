using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheWarehouse.Areas.Identity.Models;

namespace TheWarehouse.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string? Name { get; set; }

        [Key]
        [ForeignKey("ApplicationUser")]
        [Required]
        public string? OwnerId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Phone]
        public int PhoneNumber { get; set; }

        [DataType(DataType.Text)]
        public string? Address { get; set; }

        public virtual Warehouse? Warehouse { get; set; }
        public virtual ApplicationUser? Owner { get; set; }
        public virtual ICollection<ApplicationUser>? Employees { get; set; }
    }
}

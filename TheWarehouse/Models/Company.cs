using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TheWarehouse.Models
{
    public class Company : IdentityUser
    {
        [Required]
        public string? CompanyName { get; set; }
        [Required]
        public string? OwnerName { get; set; }
        
        public virtual ICollection<Employee>? Employees { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
    }
}

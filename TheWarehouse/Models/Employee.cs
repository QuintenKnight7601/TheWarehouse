using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TheWarehouse.Models
{
    public class Employee : IdentityUser
    {
        [Key]
        [Required]
        [ForeignKey("Company")]
        public string? CompanyId { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }

        public virtual Company? Company { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using TheWarehouse.Models;

namespace TheWarehouse.Areas.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Required]
        public string? FirstName { get; set; }

        [PersonalData]
        [Required]
        public string? LastName { get; set; }

        [PersonalData]
        public bool? IsOwner { get; set; }

        [Key]
        [ForeignKey("Company")]
        public string? CompanyId { get; set; }

        [PersonalData]
        public virtual Company? Company { get; set; }    
    }
}

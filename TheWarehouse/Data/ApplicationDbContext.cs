using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheWarehouse.Models;
using Microsoft.AspNetCore.Identity;

namespace TheWarehouse.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TheWarehouse.Models.Product> Product { get; set; }
        public DbSet<TheWarehouse.Models.Category> Category { get; set; }
        public DbSet<TheWarehouse.Models.ProductRecord> ProductRecord { get; set; }
        public DbSet<TheWarehouse.Models.Record> Record { get; set; }
    }
}
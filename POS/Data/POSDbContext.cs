using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POS.Models;

namespace POS.Data
{
    public class POSDbContext : IdentityDbContext
    {
        public POSDbContext(DbContextOptions<POSDbContext> options): base(options)
        {
        }
        public DbSet<AppUsers> AppUsers { get; set; }
        public DbSet<Items> Items { get; set; } 
        public DbSet<ItemCategories> ItemCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
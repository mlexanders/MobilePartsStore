using Microsoft.EntityFrameworkCore;
using MobileParts.Common.Models;

namespace MobilePartsStore.Api
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Vendor> Vendors { get; set; } = null!;

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().
                Property(p => p.Cost).HasColumnType("Money");
            modelBuilder.Entity<Category>().Property(p => p.Id).UseIdentityColumn();
        }
    }
}

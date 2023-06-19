using Microsoft.EntityFrameworkCore;
using MobileParts.Common.Models;

namespace MobilePartsStore.Auth.Api
{
    public class AuthDbContext : DbContext
    {
        public DbSet<Account> Users { get; set; } = null!;

        public AuthDbContext(DbContextOptions options) : base(options) { }
    }
}

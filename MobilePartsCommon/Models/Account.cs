
namespace MobileParts.Common.Models
{
    public class Account : Entity<Guid>
    {
        public string Password { get; set; } = null!;
        public Role Role { get; set; }
    }
}

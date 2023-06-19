using CRUD.Actions;

namespace MobileParts.Common.Models
{
    public class Account : Entity<Guid>
    {
        public Guid Id { get; set; }
        public string Password { get; set; } = null!;

        public override Guid GetPrimaryKey()
        {
            return Id;
        }
    }
}

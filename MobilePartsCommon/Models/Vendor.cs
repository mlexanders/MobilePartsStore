using CRUD.Actions;

namespace MobileParts.Common.Models
{
    public class Vendor : Entity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public override int GetPrimaryKey()
        {
            return Id;
        }
    }
}

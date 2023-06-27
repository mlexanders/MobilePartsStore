using CRUD.Actions;

namespace MobileParts.Common.Models
{
    public class Vendor : Entity<int>
    {
        public string Name { get; set; } = null!;
    }
}

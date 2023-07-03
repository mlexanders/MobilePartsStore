using CRUD.Actions;

namespace MobileParts.Common.Models
{
    public class Product : Entity<Guid>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Cost { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; } = null!;
        public int VendorId { get; set; }
        public Vendor? Vendor { get; set; }
    }
}

namespace MobileParts.Common.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Cost { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; } //TODO: virtual and ef core? (navigation props)
        public int VendorId { get; set; }
        public Vendor? Vendor { get; set; }
    }
}

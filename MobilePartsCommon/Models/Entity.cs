namespace MobileParts.Common.Models
{
    public abstract class Entity<TKey>
    {
        public TKey Id { get; set; } = default!;
    }
}
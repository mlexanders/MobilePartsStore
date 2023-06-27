using CRUD.Actions;

namespace MobileParts.Common.Models
{
    public class Category : Entity<int>
    {
        public string Tittle { get; set; } = null!;
    }
}

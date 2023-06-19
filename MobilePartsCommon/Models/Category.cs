using CRUD.Actions;

namespace MobileParts.Common.Models
{
    public class Category : Entity<int>
    {
        public int Id { get; set; }
        public string Tittle { get; set; } = null!;

        public override int GetPrimaryKey()
        {
            return Id;
        }
    }
}

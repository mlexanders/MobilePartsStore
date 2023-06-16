using CRUD.Actions;
using System.Runtime.Serialization;

namespace MobileParts.Common.Models
{
    public class Category : Entity<int>
    {
        [IgnoreDataMember]
        public int Id { get; set; }
        public string Tittle { get; set; } = null!;

        public override int GetPrimaryKey()
        {
            return Id;
        }
    }
}

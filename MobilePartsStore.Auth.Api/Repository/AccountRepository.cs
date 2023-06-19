using CRUD.Actions.Implementation;
using Microsoft.EntityFrameworkCore;
using MobileParts.Common.Models;

namespace MobilePartsStore.Auth.Api.Repository
{
    public class AccountRepository : BaseCrudRepository<Account, Guid>
    {
        public AccountRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}

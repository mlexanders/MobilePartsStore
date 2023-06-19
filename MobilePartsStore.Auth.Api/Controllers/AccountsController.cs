using CRUD.Actions;
using CRUD.Actions.Implementation;
using MobileParts.Common.Models;

namespace MobilePartsStore.Auth.Api.Controllers
{
    public class AccountsController : BaseCrudController<Account, Guid>
    {
        public AccountsController(BaseCrudRepository<Account, Guid> repository) : base(repository)
        {
        }
    }
}

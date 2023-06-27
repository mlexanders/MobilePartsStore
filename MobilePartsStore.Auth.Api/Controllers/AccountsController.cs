using CRUD.Actions;
using MobileParts.Common.Models;
using MobilePartsStore.Auth.Api.Repository;

namespace MobilePartsStore.Auth.Api.Controllers
{
    public class AccountsController : BaseCrudController<Account, Guid>
    {
        public AccountsController(AccountRepository repository) : base(repository)
        {
        }
    }
}

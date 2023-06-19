using CRUD.Actions;
using CRUD.Actions.Implementation;
using MobileParts.Common.Models;

namespace MobilePartsStore.Api.Controllers
{
    public class VendorsController : BaseCrudController<Vendor, int>
    {
        public VendorsController(BaseCrudRepository<Vendor, int> repository) : base(repository)
        {
        }
    }
}

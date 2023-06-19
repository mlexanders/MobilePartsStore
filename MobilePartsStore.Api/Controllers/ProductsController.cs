using CRUD.Actions;
using CRUD.Actions.Implementation;
using MobileParts.Common.Models;

namespace MobilePartsStore.Api.Controllers
{
    public class ProductsController : BaseCrudController<Product, Guid>
    {
        public ProductsController(BaseCrudRepository<Product, Guid> repository) : base(repository)
        {
        }
    }
}

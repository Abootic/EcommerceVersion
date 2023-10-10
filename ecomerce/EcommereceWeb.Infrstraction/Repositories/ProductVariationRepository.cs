using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.Infrastraction.Data;

namespace EcommereceWeb.Infrstraction.Repositories
{
    public class ProductVariationRepository : GenirecRopoistories<ProductVariation>, IProductVariationRepository
    {
        public ProductVariationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public Task<IEnumerable<DataListItem>> GetDDL()
        {
            throw new NotImplementedException();
        }
    }

}

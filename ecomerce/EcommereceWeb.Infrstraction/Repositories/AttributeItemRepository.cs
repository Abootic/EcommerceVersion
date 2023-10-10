using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.Infrastraction.Data;

namespace EcommereceWeb.Infrstraction.Repositories
{
    public class AttributeItemRepository : GenirecRopoistories<AttributeItem>, IAttributeItemRepository
    {
        public AttributeItemRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public Task<IEnumerable<DataListItem>> GetDDL()
        {
            throw new NotImplementedException();
        }
    }

}

using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Infrastraction.Data;
using Attribute = EcommereceWeb.Domain.Entity.Attribute;

namespace EcommereceWeb.Infrstraction.Repositories
{
    public class AttributeRepository : GenirecRopoistories<Attribute>, IAttributeRepository
    {
        public AttributeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public Task<IEnumerable<DataListItem>> GetDDL()
        {
            throw new NotImplementedException();
        }
    }

}

using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Domain.Entity;


using EcommereceWeb.Infrastraction.Data;

namespace EcommereceWeb.Infrstraction.Repositories
{
    public class TaxConfigurationRepository : GenirecRopoistories<TaxConfiguration>, ITaxConfigurationRepository
    {
        public TaxConfigurationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public Task<IEnumerable<DataListItem>> GetDDL()
        {
            throw new NotImplementedException();
        }
    }
}

using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Domain.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommereceWeb.Infrastraction.Data;

namespace EcommereceWeb.Infrstraction.Repositories
{
    public class CurrencyRepository : GenirecRopoistories<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public Task<IEnumerable<DataListItem>> GetDDL()
        {
            throw new NotImplementedException();
        }
    }
}

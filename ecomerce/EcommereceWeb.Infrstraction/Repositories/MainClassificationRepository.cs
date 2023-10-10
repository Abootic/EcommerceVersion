using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Domain.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommereceWeb.Infrastraction.Data;
using EcommereceWeb.Infrstraction.Repositories;

namespace EcommereceWeb.Infrstraction.Repositories
{
    public class MainClassificationRepository : GenirecRopoistories<MainClassification>, IMainClassificationRepository
    {
        public MainClassificationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public Task<IEnumerable<DataListItem>> GetDDL()
        {
            throw new NotImplementedException();
        }
    }

}

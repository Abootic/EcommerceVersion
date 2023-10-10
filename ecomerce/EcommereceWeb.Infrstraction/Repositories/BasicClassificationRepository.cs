using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.Infrastraction.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Infrstraction.Repositories
{
    public class BasicClassificationRepository : GenirecRopoistories<BasicClassification>, IBasicClassificationRepository
    {
        public BasicClassificationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Task<IEnumerable<DataListItem>> GetDDL()
        {
            throw new NotImplementedException();
        }
    }
}

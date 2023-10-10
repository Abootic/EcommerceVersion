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
    public class ProductAdditionalDetailsRepository : GenirecRopoistories<ProductAdditionalDetails>, IProductAdditionalDetailsRepository
    {
        public ProductAdditionalDetailsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

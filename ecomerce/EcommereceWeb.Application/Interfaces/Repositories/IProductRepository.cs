using EcommereceWeb.Application.Common;
using EcommereceWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommereceWeb.Application.Interfaces.Common;

namespace EcommereceWeb.Application.Interfaces.Repositories
{
    public interface IProductRepository :IGenericRepository<Product>
    {
        Task<IEnumerable<DataListItem>> GetDDL();
    }
}

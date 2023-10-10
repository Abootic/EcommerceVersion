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
    public interface IProductSizeRepository : IGenericRepository<ProductSize>
    {
        Task<IEnumerable<DataListItem>> GetDDL();
    }
}

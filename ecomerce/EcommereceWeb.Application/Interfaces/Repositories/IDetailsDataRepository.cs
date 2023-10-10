using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Interfaces.Repositories
{
    public interface IDetailsDataRepository:IGenericRepository<DetailsData>
    {
        Task<IEnumerable<DataListItem>> GetDDL();
    }
}

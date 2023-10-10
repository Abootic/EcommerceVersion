using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Common;
using Attribute = EcommereceWeb.Domain.Entity.Attribute;

namespace EcommereceWeb.Application.Interfaces.Repositories
{
    public interface IAttributeRepository : IGenericRepository<Attribute>
    {
        Task<IEnumerable<DataListItem>> GetDDL();
    }

}

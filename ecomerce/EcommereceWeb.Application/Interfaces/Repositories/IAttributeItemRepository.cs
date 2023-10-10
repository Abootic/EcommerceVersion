using EcommereceWeb.Application.Common;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.Application.Interfaces.Common;

namespace EcommereceWeb.Application.Interfaces.Repositories
{
    public interface IAttributeItemRepository : IGenericRepository<AttributeItem>
    {
        Task<IEnumerable<DataListItem>> GetDDL();
    }

}

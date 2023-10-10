using EcommereceWeb.Application.Common;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.Application.Interfaces.Common;

namespace EcommereceWeb.Application.Interfaces.Repositories
{
    public interface IProductAttributeRepository : IGenericRepository<ProductAttribute>
    {
        Task<IEnumerable<DataListItem>> GetDDL();
        List<List<ProductAttribute>> GetListVarationData(int productId);
    }

}

using EcommereceWeb.Application.Common;
using EcommereceWeb.Domain.Entity;

using EcommereceWeb.Application.Interfaces.Common;

namespace EcommereceWeb.Application.Interfaces.Repositories
{

    public interface IAddProductToFavoriteRepository : IGenericRepository<AddProductToFavorite>
    {
        Task<IEnumerable<DataListItem>> GetDDL();
    }
}

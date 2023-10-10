using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.Infrastraction.Data;
using EcommereceWeb.Infrstraction.Repositories;


namespace EcommereceWeb.Infrstraction.Repositories
{
    public class AddProductToFavoriteRepository : GenirecRopoistories<AddProductToFavorite>, IAddProductToFavoriteRepository
    {
        public AddProductToFavoriteRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Task<IEnumerable<DataListItem>> GetDDL()
        {
            throw new NotImplementedException();
        }
    }
}

using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;
namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IAddProductToFavoriteService
    {
        Task<IResult<AddProductToFavoriteDto>> Add(AddProductToFavoriteDto entity, CancellationToken cancellationToken = default);
        Task<IResult<AddProductToFavoriteDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<AddProductToFavoriteDto>> Update(AddProductToFavoriteDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<AddProductToFavoriteDto>>> Find(Expression<Func<AddProductToFavoriteDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<AddProductToFavoriteDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<AddProductToFavoriteDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}

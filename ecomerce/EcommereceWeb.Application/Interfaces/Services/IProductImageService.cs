using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IProductImageService
    {
        Task<IResult<ProductImageDto>> Add(ProductImageDto entity, CancellationToken cancellationToken = default);
        Task<IResult<ProductImageDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<ProductImageDto>> Update(ProductImageDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<ProductImageDto>>> Find(Expression<Func<ProductImageDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<ProductImageDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<ProductImageDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}

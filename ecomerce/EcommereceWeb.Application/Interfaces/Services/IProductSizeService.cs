using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IProductSizeService
    {
        Task<IResult<ProductSizeDto>> Add(ProductSizeDto entity, CancellationToken cancellationToken = default);
        Task<IResult<ProductSizeDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<ProductSizeDto>> Update(ProductSizeDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<ProductSizeDto>>> Find(Expression<Func<ProductSizeDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<ProductSizeDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<ProductSizeDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}

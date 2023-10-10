using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IProductService
    {
        Task<IResult<ProductDto>> Add(ProductDto entity, CancellationToken cancellationToken = default);
        Task<IResult<ProductDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<ProductDto>> Update(ProductDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<ProductDto>>> Find(Expression<Func<ProductDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<ProductDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<ProductDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}

using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IProductUnitSizeService
    {
        Task<IResult<ProductUnitSizeDto>> Add(ProductUnitSizeDto entity, CancellationToken cancellationToken = default);
        Task<IResult<ProductUnitSizeDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<ProductUnitSizeDto>> Update(ProductUnitSizeDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<ProductUnitSizeDto>>> Find(Expression<Func<ProductUnitSizeDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<ProductUnitSizeDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<ProductUnitSizeDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}

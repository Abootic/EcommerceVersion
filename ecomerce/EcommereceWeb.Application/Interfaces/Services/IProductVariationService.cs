using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IProductVariationService
    {
        Task<IResult<ProductVariationDto>> Add(ProductVariationDto entity, CancellationToken cancellationToken = default);
        Task<IResult<ProductVariationDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<ProductVariationDto>> Update(ProductVariationDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<ProductVariationDto>>> Find(Expression<Func<ProductVariationDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<ProductVariationDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<ProductVariationDto>> GetById(int Id, CancellationToken cancellationToken = default);
    } 


}

using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Domain.Entity;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IProductAttributeService
    {
        Task<IResult<ProductAttributeDto>> Add(ProductAttributeDto entity, CancellationToken cancellationToken = default);
        Task<IResult<ProductAttributeDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<ProductAttributeDto>> Update(ProductAttributeDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<ProductAttributeDto>>> Find(Expression<Func<ProductAttributeDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<ProductAttributeDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<ProductAttributeDto>> GetById(int Id, CancellationToken cancellationToken = default);
        IResult<List<ProductVariationDto>> GetListVaration(int productId);
    } 


}

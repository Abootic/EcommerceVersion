using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IProductAdditionalDetailsService
    {
        Task<IResult<ProductAdditionalDetailsDto>> Add(ProductAdditionalDetailsDto entity, CancellationToken cancellationToken = default);
        Task<IResult<ProductAdditionalDetailsDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<ProductAdditionalDetailsDto>> Update(ProductAdditionalDetailsDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<ProductAdditionalDetailsDto>>> Find(Expression<Func<ProductAdditionalDetailsDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<ProductAdditionalDetailsDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<ProductAdditionalDetailsDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}

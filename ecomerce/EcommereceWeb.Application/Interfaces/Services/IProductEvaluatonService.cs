using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IProductEvaluatonService
    {
        Task<IResult<ProductEvaluatonDto>> Add(ProductEvaluatonDto entity, CancellationToken cancellationToken = default);
        Task<IResult<ProductEvaluatonDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<ProductEvaluatonDto>> Update(ProductEvaluatonDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<ProductEvaluatonDto>>> Find(Expression<Func<ProductEvaluatonDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<ProductEvaluatonDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<ProductEvaluatonDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}

using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IProductColorsService
    {
        Task<IResult<ProductColorsDto>> Add(ProductColorsDto entity, CancellationToken cancellationToken = default);
        Task<IResult<ProductColorsDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<ProductColorsDto>> Update(ProductColorsDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<ProductColorsDto>>> Find(Expression<Func<ProductColorsDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<ProductColorsDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<ProductColorsDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}

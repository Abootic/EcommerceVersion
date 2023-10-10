using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface ICouponItemService
    {
        Task<IResult<CouponItemDto>> Add(CouponItemDto entity, CancellationToken cancellationToken = default);
        Task<IResult<CouponItemDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<CouponItemDto>> Update(CouponItemDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<CouponItemDto>>> Find(Expression<Func<CouponItemDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<CouponItemDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<CouponItemDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}

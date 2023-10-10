using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface ICouponService
    {
        Task<IResult<CouponDto>> Add(CouponDto entity, CancellationToken cancellationToken = default);
        Task<IResult<CouponDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<CouponDto>> Update(CouponDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<CouponDto>>> Find(Expression<Func<CouponDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<CouponDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<CouponDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}

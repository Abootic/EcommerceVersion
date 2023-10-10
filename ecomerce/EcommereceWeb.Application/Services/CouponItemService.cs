using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Services
{
    public class CouponItemService : ICouponItemService
    {
        public Task<IResult<CouponItemDto>> Add(CouponItemDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<CouponItemDto>>> Find(Expression<Func<CouponItemDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<CouponItemDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<CouponItemDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<CouponItemDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<CouponItemDto>> Update(CouponItemDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}

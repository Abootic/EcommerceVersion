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
    public class ProductSizeService : IProductSizeService
    {
        public Task<IResult<ProductSizeDto>> Add(ProductSizeDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<ProductSizeDto>>> Find(Expression<Func<ProductSizeDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<ProductSizeDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductSizeDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductSizeDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductSizeDto>> Update(ProductSizeDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}

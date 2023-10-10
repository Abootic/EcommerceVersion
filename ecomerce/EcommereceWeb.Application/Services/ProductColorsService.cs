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
    public class ProductColorsService : IProductColorsService
    {
        public Task<IResult<ProductColorsDto>> Add(ProductColorsDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<ProductColorsDto>>> Find(Expression<Func<ProductColorsDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<ProductColorsDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductColorsDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductColorsDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductColorsDto>> Update(ProductColorsDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}

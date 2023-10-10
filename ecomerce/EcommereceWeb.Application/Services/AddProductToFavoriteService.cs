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
    public class AddProductToFavoriteService : IAddProductToFavoriteService
    {
        public Task<IResult<AddProductToFavoriteDto>> Add(AddProductToFavoriteDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<AddProductToFavoriteDto>>> Find(Expression<Func<AddProductToFavoriteDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<AddProductToFavoriteDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<AddProductToFavoriteDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<AddProductToFavoriteDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<AddProductToFavoriteDto>> Update(AddProductToFavoriteDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}

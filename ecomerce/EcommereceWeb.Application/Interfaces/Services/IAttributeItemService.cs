using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Domain.Entity;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IAttributeItemService
    {
        Task<IResult<AttributeItemDto>> Add(AttributeItemDto entity, CancellationToken cancellationToken = default);
        Task<IResult<AttributeItemDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<AttributeItemDto>> Update(AttributeItemDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<AttributeItemDto>>> Find(Expression<Func<AttributeItemDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<AttributeItemDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<AttributeItemDto>> GetById(int Id, CancellationToken cancellationToken = default);
    } 


}

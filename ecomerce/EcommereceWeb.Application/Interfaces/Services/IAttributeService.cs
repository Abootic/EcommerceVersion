using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IAttributeService
    {
        Task<IResult<AttributeDto>> Add(AttributeDto entity, CancellationToken cancellationToken = default);
        Task<IResult<AttributeDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<AttributeDto>> Update(AttributeDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<AttributeDto>>> Find(Expression<Func<AttributeDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<AttributeDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<AttributeDto>> GetById(int Id, CancellationToken cancellationToken = default);
    } 


}

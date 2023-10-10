using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;
using EcommereceWeb.Application.Common;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IContactService
    {
        Task<IResult<ContactDto>> Add(ContactDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<ContactDto>>> GetAll(CancellationToken cancellationToken = default);

        Task<IResult<ContactDto>> GetById(int Id, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<ContactDto>>> Find(Expression<Func<ContactDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<DataListItem>>> GetDDL(CancellationToken cancellationToken = default);


        Task<IResult<ContactDto>> Update(ContactDto entity, CancellationToken cancellationToken = default);
        Task<IResult<ContactDto>> Remove(int Id, CancellationToken cancellationToken = default);
    }
}


using System.Linq.Expressions;
using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Wrapper;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface IUserManager
    {
        Task<IResult<UserDto>>AddAsync(UserDto entity, CancellationToken cancellationToken=default);
        Task<IResult<UserDto>>FindByIdAsync(string id,CancellationToken cancellationToken=default);
        Task<IResult<UserDto>>FindByEmailAsync(string id,CancellationToken cancellationToken=default);
        Task<IResult<IEnumerable<UserDto>>>GetAll(CancellationToken cancellationToken=default);
        Task<IResult<DtResult<UserDto>>>GetAll(DtResult dtResult , CancellationToken cancellationToken= default);
        Task<IResult<IEnumerable<UserDto>>>Find(Expression<Func<UserDto, bool>> entity, CancellationToken cancellationToken=default);
        Task<IResult<DtResult<UserDto>>> Find(DtResult dtResult, Expression<Func<UserDto, bool>> entity,CancellationToken cancellationToken=default);
        Task<IResult<UserDto>> UpdateAsync(UserDto entity, CancellationToken cancellationToken = default);
        Task<IResult> RemoveAsync(string id, CancellationToken cancellationToken = default);

    }
}

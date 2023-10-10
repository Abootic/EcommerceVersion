using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<IResult<UserDto>> ChangeActive(string userId, int state, CancellationToken cancellationToken = default);
        Task<IResult<UserDto>> ChangeUserType(User user, CancellationToken cancellationToken = default);


        Task<IResult<UserDto>> AddAsync(UserDto entity, CancellationToken cancellationToken = default);
        Task<IResult<UserDto>> RestPassword(User entity, string currentPassword, string Password, CancellationToken cancellationToken = default);
        Task<IResult<UserDto>> RestForgttenPassword(User entity, string Password, CancellationToken cancellationToken = default);

        // Task<IResult<IEnumerable<UserDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<UserDto>>> GetAll();
        Task<IResult<User>> FindByIdAsync(string id, CancellationToken cancellationToken = default);
    }
}

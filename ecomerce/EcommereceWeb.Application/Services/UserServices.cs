using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using EcommereceWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Services
{
    public class UserServices : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;

        public UserServices(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public Task<IResult<UserDto>> AddAsync(UserDto entity, CancellationToken cancellationToken = default)
        {
            var res=_repositoryManager.UserRepository.AddAsync(entity, cancellationToken);
            return res;
               
        }

        public Task<IResult<UserDto>> ChangeActive(string userId, int state, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<UserDto>> ChangeUserType(User user, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<User>> FindByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<UserDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IResult<UserDto>> RestForgttenPassword(User entity, string Password, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<UserDto>> RestPassword(User entity, string currentPassword, string Password, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;

        public UserService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<IResult<UserDto>> AddAsync(UserDto entity, CancellationToken cancellationToken = default)
        {
            var res= await _repositoryManager.UserRepository.AddAsync(entity, cancellationToken);
            return res;
               
        }

        public Task<IResult<UserDto>> ChangeActive(string userId, int state, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<UserDto>> ChangeUserType(User user, CancellationToken cancellationToken = default)
        {
            var res=await _repositoryManager.UserRepository.ChangeUserType(user, cancellationToken);
            if (res.Status.Succeeded)
            {
                return res;
            }
            return res;
        }

        public async Task<IResult<User>> FindByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            var res = await _repositoryManager.UserRepository.FindByIdAsync(id);
            if (res.Status.Succeeded)
            {
                return res;
            }
            return res;
        }

        public async Task<IResult<IEnumerable<UserDto>>> GetAll()
        {
            try
            {
                var res = await _repositoryManager.UserRepository.GetAll();


                if (res.Status.Succeeded)
                {
                    Console.WriteLine($"resuilt is {res.Status.message}");

                    return res;
                }
                Console.WriteLine($"resuilt is {res.Status.message}");
                return res;
            }
            catch(Exception ex) {
                Console.WriteLine($"sdjvlmsdkhvn  {ex.Message}");
                return default;
            }
           
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

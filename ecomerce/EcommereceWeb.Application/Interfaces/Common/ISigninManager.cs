
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.DTOs.Auth;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface ISigninManager
    {
        
        public Task<IResult<UserTokenRequst>> PasswordSiginAsync(string username, string password, bool isPerisistent, bool LockOutoNFauilar);
        public Task<IResult<UserTokenRequst>> PasswordSiginByEmailAsync(string username, string password, bool isPerisistent, bool LockOutoNFauilar);
        public void Logout();

        //public Task<IResult<UserDto>> PasswordSiginAsync(string username, string password, bool isPerisistent, bool LockOutoNFauilar);
        //public  Task<IResult<UserDto>> PasswordSiginByEmailAsync(string username, string password, bool isPerisistent, bool LockOutoNFauilar);
    }
}

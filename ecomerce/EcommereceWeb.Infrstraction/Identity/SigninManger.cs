using EcommereceWeb.Application.DTOs.Auth;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Wrapper;
using EcommereceWeb.Domain.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Infrstraction.Identity
{
    public class SigninManger: ISigninManager
    {
        private readonly SignInManager<User> _signinManger;

        public SigninManger(SignInManager<User> signinManger)
        {
            _signinManger = signinManger;
        }

        public async Task<IResult<UserTokenRequst>> PasswordSiginAsync(string username, string password, bool isPerisistent, bool LockOutoNFauilar)
        {
            //try
            //{

            var user = await _signinManger.UserManager.FindByNameAsync(username);
            if (user == null)
            {

                return await Result<UserTokenRequst>.FailAsync($" اسم المستخد الذي ادخلتة {username}  غير موجود    ");

            }
            var res = await _signinManger.PasswordSignInAsync(username, password, isPerisistent, LockOutoNFauilar);
            // var res = await _signinManger.CheckPasswordSignInAsync(user, password, LockOutoNFauilar,isPerisistent);
            if (res.IsLockedOut)
            {
                return await Result<UserTokenRequst>.FailAsync("acount lock too many atmate");
            }

            if (res.Succeeded)
            {
                return Result<UserTokenRequst>.Sucess(new UserTokenRequst
                {
                    Id = user.Id,
                    Email = user.Email,
                    Password = password,
                    UserName = user.UserName,
                    Fullname = user.FullName,

                });
            }
            else
            {
                return Result<UserTokenRequst>.Fail("invalid Login ", 401);
            }
            //}catch (Exception ex)
            //{
            //    return await Result<UserTokenRequst>.FailAsync($"catch sgin by username Login {ex.Message} ");

            //}
        }

        public async Task<IResult<UserTokenRequst>> PasswordSiginByEmailAsync(string Email, string password, bool isPerisistent, bool LockOutoNFauilar)
        {
            try
            {
                var user = await _signinManger.UserManager.FindByEmailAsync(Email);

                Console.WriteLine("the eamil from PasswordSiginByEmailAsync is " + Email);

                if (user == null)
                {
                    Console.WriteLine($"the user that has this Email {Email} not Exsit ");
                    return await Result<UserTokenRequst>.FailAsync($"the user that has this Email {Email} not Exsit ");

                }
                var res = await _signinManger.CheckPasswordSignInAsync(user, password, LockOutoNFauilar);
                if (res.IsLockedOut)
                {
                    return await Result<UserTokenRequst>.FailAsync("Acoount locked to many atmpate ");

                }
                return res.Succeeded ? Result<UserTokenRequst>.Sucess(new UserTokenRequst
                {
                    Id = user.Id,
                    Email = user.Email,
                    Password = password,
                    UserName = user.UserName,

                }) : Result<UserTokenRequst>.Fail("invalid Login ", 401);
            }
            catch (Exception ex)
            {
                return await Result<UserTokenRequst>.FailAsync($"catch sgin by email Login {ex.Message} ");
            }
        }

        public async void Logout()
        {

            await _signinManger.SignOutAsync();

        }

    }
}

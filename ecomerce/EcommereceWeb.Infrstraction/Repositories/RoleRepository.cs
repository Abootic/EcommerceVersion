using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Application.Wrapper;
using EcommereceWeb.Domain.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Infrstraction.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public RoleRepository(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IResult<IEnumerable<RoleDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _roleManager.Roles.AsNoTracking().ToListAsync();
                if (res != null)
                {
                    var roles = new List<RoleDto>();
                    foreach (var role in res)
                    {
                        var itemMap = new RoleDto
                        {
                            Id = role.Id,
                            Name = role.Name,

                        };
                        roles.Add(itemMap);
                    }
                    return await Result<IEnumerable<RoleDto>>.SucessAsync(roles, "roles record");
                }
                return await Result<IEnumerable<RoleDto>>.FailAsync($"roles record null ", 710);
            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<RoleDto>>.FailAsync($"catch error {ex.Message}", 712);
            }
        }

        public async Task<IResult<UserAndRolesDto>> AddRoleToUserAsync(UserAndRolesDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(entity.UserId);


                if (user != null)
                {
                    var roles = await _roleManager.RoleExistsAsync(entity.RoleName);

                    if (roles)
                    {
                        var userRes = await _userManager.AddToRoleAsync(user, entity.RoleName);
                        if (!userRes.Succeeded)
                        {
                            string error = string.Empty;
                            foreach (var er in userRes.Errors)
                            {

                                error = er.Description;


                            }
                            return await Result<UserAndRolesDto>.FailAsync($"UserAndRoles something went erro !!!\n\n\n{error}  ");
                        }
                        else
                        {
                            // var itemMap=await _userManager.get

                            return await Result<UserAndRolesDto>.SucessAsync("UserAndRoles Created succssfully");
                        }
                    }
                    return await Result<UserAndRolesDto>.FailAsync($"Sorry! --> this RoleName {entity.RoleName} Not Exsit  ", 800);
                }
                return await Result<UserAndRolesDto>.FailAsync($"Sorry! --> this User Not Exsit  ", 801);
            }
            catch (Exception ex)
            {
                return await Result<UserAndRolesDto>.FailAsync($"catch UserAndRoles something Error {ex.Message}");
            }
        }



    }
}

using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly  IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<IResult<UserAndRolesDto>> AddRoleToUserAsync(UserAndRolesDto entity, CancellationToken cancellationToken = default)
        {
            var res = await _roleRepository.AddRoleToUserAsync(entity);
            if (res.Status.Succeeded)
            {
                return res;
            }
            return res;
        }

        public async Task<IResult<IEnumerable<RoleDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            var res = await _roleRepository.GetAll();
            if (res.Status.Succeeded)
            {
                return res;
            }
            return res;
        }
    }
}

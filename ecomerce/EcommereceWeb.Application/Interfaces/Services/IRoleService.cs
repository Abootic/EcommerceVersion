using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IRoleService
    {
        Task<IResult<UserAndRolesDto>> AddRoleToUserAsync(UserAndRolesDto entity, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<RoleDto>>> GetAll(CancellationToken cancellationToken = default);
    }
}

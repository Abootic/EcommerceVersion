using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.DTOs
{
    public class UserAndRolesDto
    {
        public string UserId { get; set; }
        public string RoleName { get; set; }
        public string? fullName { get; set; }
    }
}

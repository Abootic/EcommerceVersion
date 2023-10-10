using EcommereceWeb.Application.DTOs;

namespace EcommereceWeb.MVC.ViewModel
{
    public class UserAndRoleVm
    {
        public IEnumerable<UserDto> data { get; set; }
        public UserDto obj { get; set; }
        public UserAndRolesDto userAndRolesDto { get; set; }
    }
}

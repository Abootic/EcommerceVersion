using EcommereceWeb.Application.Interfaces.Common;

namespace EcommereceWeb.MVC.Services
{
    public class CurrentUserServices : ICurrentUserServices
    {
        public string UserId { get; set ; }
        public bool IsAuthenticated { get; set; }
        public string IpAddress { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface ICurrentUserServices
    {
        public string UserId { get; set; }
        public bool IsAuthenticated { get; set; }
        public string IpAddress { get; set; }
    }
}

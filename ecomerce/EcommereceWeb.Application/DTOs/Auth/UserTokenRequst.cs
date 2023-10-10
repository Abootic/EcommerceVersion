using EcommereceWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.DTOs.Auth
{
    public class UserTokenRequst
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User user { get; set; }
    }
}

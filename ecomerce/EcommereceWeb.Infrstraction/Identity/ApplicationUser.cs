using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Infrastraction.Identity
{
    public class ApplicationUser: IdentityUser
    {
        public string FullName { get; set; } = null!;       
        public string? UserType { get; set; } 
        public string? CreatedBy { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? LastModfiedBy { get; set; }
        public DateTime? LastModfiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int State { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Infrstraction.EntityConfigration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.ToTable("AspNetRoles", "dbo");
            builder.HasData(
                 new IdentityRole
                 {
                     Id = "ca34737e-e863-40aa-a82f-adbd3207988a",
                     Name = "Admin",
                     NormalizedName = "ADMIN".ToUpper(),
                     ConcurrencyStamp = "b9fce677-ff9b-4d55-93b0-dcb97d12b11c"
                 });
            builder.HasData(
                 new IdentityRole
                 {
                     Id = "8c1f7d67-0b9e-44ef-83d4-6e4ef72d3b6f",
                     Name = "Manager",
                     NormalizedName = "OWNER".ToUpper(),
                     ConcurrencyStamp = "ca3b3647-fb97-40a0-ad64-8a3d645cdc03"
                 }); builder.HasData(
                 new IdentityRole
                 {
                     Id = "eedae456-fa3a-47a0-9764-c634214bbe42",
                     Name = "User",
                     NormalizedName = "USER".ToUpper(),
                     ConcurrencyStamp = "a8333576-d0ec-4caa-925c-cf7113f8df7d"
                 }); builder.HasData(
                 new IdentityRole
                 {
                     Id = "cb512048-1ad1-437b-8930-1b70a31e4d5c",
                     Name = "ServiceProvider",
                     NormalizedName = "SERVICEPROVIDER".ToUpper(),
                     ConcurrencyStamp = "de8c59e2-0bf9-451e-8c0f-672e0335fbf2"
                 });
        }
    }
}

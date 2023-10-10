using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommereceWeb.Infrstraction.EntityConfigration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.ToTable("AspNetUserRoles", "dbo");
            builder.HasData(
                 new IdentityUserRole<string>
                 {
                     RoleId = "ca34737e-e863-40aa-a82f-adbd3207988a",
                     UserId = "4a2e1650-21bd-4e67-832e-2e99c267a2e4",

                 }

            );
        }
    }
}

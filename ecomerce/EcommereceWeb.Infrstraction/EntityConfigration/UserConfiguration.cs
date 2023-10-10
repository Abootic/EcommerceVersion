using EcommereceWeb.Domain.Entity;
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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.ToTable("AspNetUsers", "dbo");
            builder.Property(x => x.Image).HasColumnName(@"Image").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            var hasher = new PasswordHasher<User>();
            builder.HasData(
                  new User
                  {
                      Id = "4a2e1650-21bd-4e67-832e-2e99c267a2e4",
                      UserName = "Admin",
                      Email = "Admin@Gmail.com",
                      FullName = "Admin",
                     PhoneNumber="123456789",
                      Image = "unkown",
                      NormalizedUserName = "ADMIN",
                      NormalizedEmail = "ADMIN@GMAIL.COM",
                      PasswordHash = hasher.HashPassword(null, "123456"),

                  }

             );
        }
    }
}

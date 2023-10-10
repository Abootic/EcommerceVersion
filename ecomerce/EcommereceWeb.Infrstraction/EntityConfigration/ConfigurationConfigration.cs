using EcommereceWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Infrstraction.EntityConfigration
{
    public class ConfigurationConfigration : IEntityTypeConfiguration<Configuration>
    {
        public void Configure(EntityTypeBuilder<Configuration> builder)
        {
            builder.ToTable("Configuration", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_Configuration").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.ArValue).HasColumnName(@"ArValue").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnValue).HasColumnName(@"EnValue").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.Name).HasColumnName(@"Description").HasColumnType("nvarchar(MAX)").IsRequired(false).HasMaxLength(255);

        }
    }
}

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
    public class TaxConfigurationConfigration : IEntityTypeConfiguration<TaxConfiguration>
    {
        public void Configure(EntityTypeBuilder<TaxConfiguration> builder)
        {
            builder.ToTable("TaxConfiguration", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_TaxConfiguration").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.TaxNumber).HasColumnName(@"TaxNumber").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.Value).HasColumnName(@"Value").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.type).HasColumnName(@"type").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);

        }
    }
}

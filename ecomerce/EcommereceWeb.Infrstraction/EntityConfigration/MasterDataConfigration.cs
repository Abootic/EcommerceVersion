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
    public class MasterDataConfigration : IEntityTypeConfiguration<MasterData>
    {
        public void Configure(EntityTypeBuilder<MasterData> builder)
        {
            builder.ToTable("MasterData", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_MasterData").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.CodeValue).HasColumnName(@"CodeValue").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar(MAX)").IsRequired(false);

        }
    }
}

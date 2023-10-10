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
    public class ProductUnitSizeConfigration : IEntityTypeConfiguration<ProductUnitSize>
    {
        public void Configure(EntityTypeBuilder<ProductUnitSize> builder)
        {
            builder.ToTable("ProductUnitSize", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_ProductUnitSize").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Weight).HasColumnName(@"Weight").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Height).HasColumnName(@"Height").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Width).HasColumnName(@"Width").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ProductType).HasColumnName(@"ProductType").HasColumnType("bit").IsRequired(false);
            builder.Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.Product).WithMany(b => b.ProductUnitSizes).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductUnitSizes_Products");


        }
    }
}

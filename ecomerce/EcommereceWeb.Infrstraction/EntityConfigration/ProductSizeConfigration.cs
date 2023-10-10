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
    public class ProductSizeConfigration : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder.ToTable("ProductSize", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_ProductSize").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Price).HasColumnName(@"Price").HasColumnType("decimal").IsRequired(false);
            builder.Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.ArSizeName).HasColumnName(@"ArSizeName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnSizeName).HasColumnName(@"EnSizeName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.HasOne(a => a.Product).WithMany(b => b.ProductSize).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductSize_Products");
        }
    }
}

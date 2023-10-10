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
    public class ProductColorsConfigration : IEntityTypeConfiguration<ProductColors>
    {
        public void Configure(EntityTypeBuilder<ProductColors> builder)
        {
            builder.ToTable("ProductColors", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_ProductColors").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.ImgUrl).HasColumnName(@"ImgUrl").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ArColorName).HasColumnName(@"ArColorName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnColorName).HasColumnName(@"EnColorName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.Product).WithMany(b => b.ProductColors).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductColors_Products");

        }
    }
}

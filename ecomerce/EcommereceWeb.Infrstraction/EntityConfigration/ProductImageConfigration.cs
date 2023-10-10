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
    public class ProductImageConfigration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImage", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_ProductImage").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ImageUrl).HasColumnName(@"ImageUrl").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.Product).WithMany(b => b.ProductImages).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductImages_Products");


        }
    }
}

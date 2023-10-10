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
    public class ProductAdditionalDetailsConfigration : IEntityTypeConfiguration<ProductAdditionalDetails>
    {
        public void Configure(EntityTypeBuilder<ProductAdditionalDetails> builder)
        {
            builder.ToTable("ProductAdditionalDetails", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_ProductAdditionalDetails").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ArTitle).HasColumnName(@"ArTitle").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnTitle).HasColumnName(@"EnTitle").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ArValue).HasColumnName(@"ArValue").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnValue).HasColumnName(@"EnValue").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.Product).WithMany(b => b.ProductAdditionalDetails).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Product_ProductAdditionalDetails");

        }
    }
}

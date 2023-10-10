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
    public class CouponItemConfigration : IEntityTypeConfiguration<CouponItem>
    {
        public void Configure(EntityTypeBuilder<CouponItem> builder)
        {
            builder.ToTable("CouponItem", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_CouponItem").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.CouponId).HasColumnName(@"CouponId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.Products).WithMany(b => b.CouponItems).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CouponItems_Product");
            builder.HasOne(a => a.Coupons).WithMany(b => b.CouponItems).HasForeignKey(b => b.CouponId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CouponItems_Coupon");




        }
    }
}

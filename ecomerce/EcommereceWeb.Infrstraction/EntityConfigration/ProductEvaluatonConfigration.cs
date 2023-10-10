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
    public class ProductEvaluatonConfigration : IEntityTypeConfiguration<ProductEvaluaton>
    {
        public void Configure(EntityTypeBuilder<ProductEvaluaton> builder)
        {
            builder.ToTable("ProductEvaluaton", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_ProductEvaluaton").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Rating).HasColumnName(@"Rating").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("nvarchar(450)").IsRequired(false);
            builder.Property(x => x.Comment).HasColumnName(@"Comment").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.HasOne(a => a.Product).WithMany(b => b.ProductEvaluatons).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductEvaluaton_Products");
            builder.HasOne(a => a.Users).WithMany(b => b.ProductEvaluaton).HasForeignKey(b => b.UserId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductEvaluaton_User");


        }
    }
}

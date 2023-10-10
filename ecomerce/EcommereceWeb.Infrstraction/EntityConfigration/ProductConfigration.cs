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
    public class ProductConfigration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_Product").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ArName).HasColumnName(@"ArName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnName).HasColumnName(@"EnName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnDetails).HasColumnName(@"EnDetails").HasColumnType("nvarchar(MAX)").IsRequired(false);
            builder.Property(x => x.ArDetails).HasColumnName(@"ArDetails").HasColumnType("nvarchar(MAX)").IsRequired(false);
            builder.Property(x => x.Logo).HasColumnName(@"Logo").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.VideoProvider).HasColumnName(@"VideoProvider").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.VideoUrl).HasColumnName(@"VideoUrl").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);

            builder.Property(x => x.Discount).HasColumnName(@"Discount").HasColumnType("decimal(10, 2)").IsRequired(false);
            builder.Property(x => x.MinOrderQuantity).HasColumnName(@"MinOrderQuantity").HasColumnType("decimal(10, 2)").IsRequired(false);
            builder.Property(x => x.MaxOrderQuantity).HasColumnName(@"MaxOrderQuantity").HasColumnType("decimal(10, 2)").IsRequired(false);
            builder.Property(x => x.TaxType).HasColumnName(@"TaxType").HasColumnType("int").IsRequired();
            builder.Property(x => x.ArKeyWords).HasColumnName(@"ArKeyWords").HasColumnType("nvarchar(255)").IsRequired(false);
            builder.Property(x => x.EnKeyWords).HasColumnName(@"EnKeyWords").HasColumnType("nvarchar(255)").IsRequired(false);
            builder.Property(x => x.BrandId).HasColumnName(@"BrandId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.MainClassificationId).HasColumnName(@"MainClassificationId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.BasicClassificationId).HasColumnName(@"BasicClassificationId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SubClassificationBaseId).HasColumnName(@"SubClassificationBaseId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SubSubclassificationId).HasColumnName(@"SubSubclassificationId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.Brand).WithMany(b => b.Products).HasForeignKey(b => b.BrandId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Brand_Products");
            builder.HasOne(a => a.MainClassification).WithMany(b => b.Products).HasForeignKey(b => b.MainClassificationId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_MainClassification_Products");
            builder.HasOne(a => a.BasicClassification).WithMany(b => b.Products).HasForeignKey(b => b.BasicClassificationId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BasicClassification_Products");
            builder.HasOne(a => a.SubClassificationBase).WithMany(b => b.Products).HasForeignKey(b => b.SubClassificationBaseId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SubClassificationBase_Products");
            builder.HasOne(a => a.SubSubClassification).WithMany(b => b.Products).HasForeignKey(b => b.SubSubclassificationId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SubSubClassification_Products");

        }
    }
}

using EcommereceWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommereceWeb.Infrstraction.EntityConfigration
{
    public class ProductAttributeConfigration : IEntityTypeConfiguration<ProductAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            builder.ToTable("ProductAttribute", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_ProductAttribute").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.AttributeId).HasColumnName(@"AttributeId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.AttributeItemId).HasColumnName(@"AttributeItemId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);

            builder.HasOne(a => a.Attribute).WithMany(b => b.ProductAttributes).HasForeignKey(b => b.AttributeId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AttributeId_ProductAttribute");
            builder.HasOne(a => a.AttributeItem).WithMany(b => b.ProductAttributes).HasForeignKey(b => b.AttributeItemId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AttributeItemId_ProductAttribute");
            builder.HasOne(a => a.Product).WithMany(b => b.ProductAttributes).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductId_ProductAttribute");


        }
    }

}

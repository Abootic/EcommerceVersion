using EcommereceWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommereceWeb.Infrstraction.EntityConfigration
{
    public class ProductVariationConfigration : IEntityTypeConfiguration<ProductVariation>
    {
        public void Configure(EntityTypeBuilder<ProductVariation> builder)
        {
            builder.ToTable("ProductVariation", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_ProductVariation").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ArName).HasColumnName(@"ArName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.EnName).HasColumnName(@"EnName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.AttItemId).HasColumnName(@"AttItemId").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Image).HasColumnName(@"Image").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Quantity).HasColumnName(@"Quntatiy").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Price).HasColumnName(@"Price").HasColumnType("decimal(10, 2)").IsRequired(false);
            builder.Property(x => x.Cost).HasColumnName(@"Cost").HasColumnType("decimal(10, 2)").IsRequired();
            builder.Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.Product).WithMany(b => b.ProductVariations).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductId_ProductVariation");


        }
    }

}

using EcommereceWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommereceWeb.Infrstraction.EntityConfigration
{
    public class AttributeItemConfigration : IEntityTypeConfiguration<AttributeItem>
    {
        public void Configure(EntityTypeBuilder<AttributeItem> builder)
        {
            builder.ToTable("AttributeItem", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_AttributeItem").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ArName).HasColumnName(@"ArName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnName).HasColumnName(@"EnName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ColorCode).HasColumnName(@"ColorCode").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Details).HasColumnName(@"Details").HasColumnType("nvarchar(MAX)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.AttributeId).HasColumnName(@"AttributeId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.Attribute).WithMany(b => b.AttributeItems).HasForeignKey(b => b.AttributeId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AttributeId_AttributeItem");


        }
    }

}

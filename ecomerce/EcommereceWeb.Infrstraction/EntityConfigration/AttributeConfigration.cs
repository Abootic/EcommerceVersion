using EcommereceWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Attribute = EcommereceWeb.Domain.Entity.Attribute;

namespace EcommereceWeb.Infrstraction.EntityConfigration
{
    public class AttributeConfigration : IEntityTypeConfiguration<Attribute>
    {
        public void Configure(EntityTypeBuilder<Attribute> builder)
        {

            builder.ToTable("Attribute", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_Attributes").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ArName).HasColumnName(@"ArName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnName).HasColumnName(@"EnName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Type).HasColumnName(@"Type").HasColumnType("int").IsRequired(false);
        }
    }

}

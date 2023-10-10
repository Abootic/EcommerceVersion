using EcommereceWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
namespace EcommereceWeb.Infrstraction.EntityConfigration
{
    public class BrandConfigration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {

            builder.ToTable("Brands", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_Brands").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ArName).HasColumnName(@"ArName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnName).HasColumnName(@"EnName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.CompanyInfo).HasColumnName(@"CompanyInfo").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ImageUrl).HasColumnName(@"ImageUrl").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
        }
    }

}

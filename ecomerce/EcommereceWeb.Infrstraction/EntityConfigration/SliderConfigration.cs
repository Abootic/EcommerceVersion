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
    public class SliderConfigration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.ToTable("Slider", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_Slider").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.EnName).HasColumnName(@"EnName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ArName).HasColumnName(@"ArName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.ImgUrl).HasColumnName(@"ImgUrl").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
          //  builder.Property(x => x.Type).HasColumnName(@"Type").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.EnDetails).HasColumnName(@"EnDetails").HasColumnType("nvarchar(MAX)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ArDetails).HasColumnName(@"ArDetails").HasColumnType("nvarchar(MAX)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime2").IsRequired();

        }
    }
}

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
    public class CouponConfigration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.ToTable("Coupon", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_Coupon").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime2").IsRequired();
             builder.Property(x=>x.Rate).HasColumnName(@"Rate").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
             builder.Property(x=>x.ApplyTo).HasColumnName(@"ApplyTo").HasColumnType("int").IsRequired(false).HasMaxLength(255);
             builder.Property(x=>x.QtRequire).HasColumnName(@"QtRequire").HasColumnType("int").IsRequired(false);
             builder.Property(x=>x.PriceRequire).HasColumnName(@"PriceRequire").HasColumnType("decimal").IsRequired(false);
             builder.Property(x=>x.Type).HasColumnName(@"Type").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
             builder.Property(x=>x.ArDetails).HasColumnName(@"ArDetails").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
             builder.Property(x=>x.EnDetails).HasColumnName(@"EnDetails").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);


        }
    }
}

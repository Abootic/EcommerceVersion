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
    public class BasicClassificationConfigration : IEntityTypeConfiguration<BasicClassification>
    {
        public void Configure(EntityTypeBuilder<BasicClassification> builder)
        {
            builder.ToTable("BasicClassification", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_BasicClassification").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.EnBasicClassificationName).HasColumnName(@"EnBasicClassificationName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ArBasicClassificationName).HasColumnName(@"ArBasicClassificationName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.ImageUrl).HasColumnName(@"ImageUrl").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.MainClassificationId).HasColumnName(@"MainClassificationId").HasColumnType("int").IsRequired(false);
             builder.HasOne(a => a.MainClassification).WithMany(b => b.BasicClassifications).HasForeignKey(b => b.MainClassificationId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_MainClassification_BasicClassification");


        }
    }

}

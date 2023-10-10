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
    public class SubClassificationBaseConfigration : IEntityTypeConfiguration<SubClassificationBase>
    {
        public void Configure(EntityTypeBuilder<SubClassificationBase> builder)
        {
            builder.ToTable("SubClassificationBase", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_SubClassificationBase").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ArSubClassificationName).HasColumnName(@"ArSubClassificationName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnSubClassificationName).HasColumnName(@"EnSubClassificationName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ImageUrl).HasColumnName(@"ImageUrl").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.BasicClassificationId).HasColumnName(@"BasicClassificationId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.BasicClassification).WithMany(b => b.SubClassificationBases).HasForeignKey(b => b.BasicClassificationId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BasicClassificationId_SubClassificationBases");


        }
    }
}

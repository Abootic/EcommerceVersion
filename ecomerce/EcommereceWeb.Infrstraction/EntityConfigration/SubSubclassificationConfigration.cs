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
    public class SubSubclassificationConfigration : IEntityTypeConfiguration<SubSubclassification>
    {
        public void Configure(EntityTypeBuilder<SubSubclassification> builder)
        {
            builder.ToTable("SubSubclassification", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_SubSubclassification").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ArSubSubClassificationName).HasColumnName(@"ArSubSubClassificationName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnSubSubClassificationName).HasColumnName(@"EnSubSubClassificationName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ImageUrl).HasColumnName(@"ImageUrl").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.SubClassificationBaseId).HasColumnName(@"SubClassificationBaseId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.SubClassificationBase).WithMany(b => b.SubSubclassifications).HasForeignKey(b => b.SubClassificationBaseId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SubClassificationBaseId_SubSubclassifications");


        }
    }
}

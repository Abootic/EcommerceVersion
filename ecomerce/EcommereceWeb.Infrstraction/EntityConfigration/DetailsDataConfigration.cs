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
    public class DetailsDataConfigration : IEntityTypeConfiguration<DetailsData>
    {
        public void Configure(EntityTypeBuilder<DetailsData> builder)
        {
            builder.ToTable("DetailsData", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_DetailsData").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
           // builder.Property(x => x.CodeValue).HasColumnName(@"CodeValue").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.ArValue).HasColumnName(@"ArName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.EnValue).HasColumnName(@"EnName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar(MAX)").IsRequired(false);
            builder.Property(x => x.MasterDataId).HasColumnName(@"MasterDataId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.MasterData).WithMany(b => b.DetailsDatas).HasForeignKey(b => b.MasterDataId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_MasterDatan_DetailsDatas");



        }
    }
}

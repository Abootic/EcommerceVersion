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
    public class AddProductToFavoriteConfigration : IEntityTypeConfiguration<AddProductToFavorite>
    {
        public void Configure(EntityTypeBuilder<AddProductToFavorite> builder)
        {

            builder.ToTable("AddProductToFavorite", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_AddProductToFavorite").IsClustered();
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired();
            builder.Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("nvarchar(450)").IsRequired();
            builder.HasOne(a => a.Products).WithMany(b => b.AddProductToFavorites).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AddProductToFavorites_Products");
            builder.HasOne(a => a.Users).WithMany(b => b.AddProductToFavorites).HasForeignKey(b => b.UserId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AddProductToFavorites_User");



        }
    }
}

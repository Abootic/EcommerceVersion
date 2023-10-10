
using EcommereceWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Attribute = EcommereceWeb.Domain.Entity.Attribute;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface IApplicationDbContext
    {

        DbSet<AddProductToFavorite> AddProductToFavorite { get; }
        DbSet<BasicClassification> BasicClassification { get; }
        DbSet<Brand> Brand { get; }
        DbSet<Configuration> Configuration { get; }
        DbSet<Coupon> Coupon { get; }
        DbSet<CouponItem> CouponItem { get; }
        DbSet<Contact> Contact { get; }
        DbSet<Currency> Currency { get; }
        DbSet<DetailsData> DetailsData { get; }
        DbSet<MainClassification> MainClassification { get; }
        DbSet<MasterData> MasterData { get; }
        DbSet<Product> Product { get; }
        DbSet<ProductAdditionalDetails> ProductAdditionalDetails { get; }
        DbSet<ProductColors> ProductColors { get; }
        DbSet<ProductEvaluaton> ProductEvaluaton { get; }
        DbSet<ProductImage> ProductImage { get; }
        DbSet<ProductSize> ProductSize { get; }
        DbSet<ProductUnitSize> ProductUnitSize { get; }
        DbSet<Slider> Slider { get; }
        DbSet<Attribute> Attribute { get; }
        DbSet<AttributeItem> AttributeItem { get; }
        DbSet<ProductAttribute> ProductAttribute { get; }
        DbSet<ProductVariation> ProductVariation { get; }
        DbSet<SubClassificationBase> SubClassificationBase { get; }
      //  DbSet<SubSubclassification> SubSubclassification { get; }
        DbSet<TaxConfiguration> TaxConfiguration { get; }

        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
        //Task<int> SaveChange(CancellationToken cancellationToken);
    }
}


using EcommereceWeb.Application.Interfaces.Services;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface IServiceManager
    {
        IAddProductToFavoriteService AddProductToFavoriteService { get; }
        IBasicClassificationService BasicClassificationService { get; }
        IBrandService BrandService { get; }
        IConfigurationService ConfigurationService { get; }
        IContactService ContactServices { get; }
        ICouponItemService CouponItemService { get; }
        ICouponService CouponService { get; }
        ICurrencyService CurrencyService { get; }
        IDetailsDataService DetailsDataService { get; }
        IMainClassificationService MainClassificationService { get; }
        IMasterDataService MasterDataService { get; }
        IProductAdditionalDetailsService ProductAdditionalDetailsService { get; }
        IProductColorsService ProductColorsService { get; }
        IProductEvaluatonService ProductEvaluatonService { get; }
        IProductImageService ProductImageService { get; }
        IProductService ProductService { get; }
        IProductSizeService ProductSizeService { get; }
        IProductUnitSizeService ProductUnitSizeService { get; }
        ISliderService SliderService { get; }
        ISubClassificationBaseService SubClassificationBaseService { get; }
        ISubSubclassificationService SubSubclassificationService { get; }
        ITaxConfigurationService TaxConfigurationService { get; }
        IAttributeService AttributeService { get; }
        IAttributeItemService AttributeItemService { get; }
        IProductAttributeService ProductAttributeService { get; }
        IProductVariationService ProductVariationService { get; }
        IUserService UserService { get; }
        IUplaodFileService UplaodFileService { get; }
        IRoleService RoleService { get; }


    }
}
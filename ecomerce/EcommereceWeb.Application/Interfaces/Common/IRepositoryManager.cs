

using EcommereceWeb.Application.Interfaces.Repositories;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface IRepositoryManager
    {
        IAddProductToFavoriteRepository AddProductToFavoriteRepository { get; }
        IBrandRepository BrandRepository { get; }
        IConfigurationRepository ConfigurationRepository { get; }
        IProductRepository ProductRepository { get; }
        //ICouponRepository CouponRepository { get; }
         ICouponItemRepository CouponItemRepository { get; }
        ICurrencyRepository CurrencyRepository { get; }
        IMainClassificationRepository MainClassificationRepository { get; }
        IMasterDataRepository MasterDataRepository { get; }
        IProductColorsRepository ProductColorsRepository { get; }
        IProductEvaluatonRepository ProductEvaluatonRepository { get; }
        IProductImageRepository ProductImageRepository { get; }
        IProductSizeRepository ProductSizeRepository { get; }
        //IProductUnitSizeRepository ProductUnitSizeRepository { get;  
        IBasicClassificationRepository BasicClassificationRepository { get; }
        ISliderRepository SliderRepository { get; }
        ISubClassificationBaseRepository SubClassificationBaseRepository { get; }
        ISubSubclassificationRepository SubSubclassificationRepository { get; }
        ITaxConfigurationRepository TaxConfigurationRepository { get; }
        IAttributeRepository AttributeRepository { get; }
        IAttributeItemRepository AttributeItemRepository { get; }
        IProductAttributeRepository ProductAttributeRepository { get; }
        IProductVariationRepository ProductVariationRepository { get; }
        IProductAdditionalDetailsRepository ProductAdditionalDetailsRepository { get; }
        IUserRepository UserRepository { get; }
        IUnitOfWork UnitOfWork { get; }

    }
}

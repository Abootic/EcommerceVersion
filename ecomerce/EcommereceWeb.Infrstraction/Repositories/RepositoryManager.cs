using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Infrstraction.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly IAddProductToFavoriteRepository addProductToFavoriteRepository;

        private readonly IBrandRepository brandRepository;

        private readonly IConfigurationRepository configurationRepository;

        private readonly IProductRepository productRepository ;

      //  private readonly ICouponRepository couponRepository ;


        private readonly ICouponItemRepository couponItemRepository ;

        private readonly ICurrencyRepository currencyRepository ;

        private readonly IMainClassificationRepository mainClassificationRepository ;

        private readonly IMasterDataRepository masterDataRepository ;

        private readonly IProductColorsRepository productColorsRepository ;

        private readonly IProductEvaluatonRepository productEvaluatonRepository ;

        private readonly IProductImageRepository productImageRepository ;

        private readonly IProductSizeRepository productSizeRepository ;

       // private readonly IProductUnitSizeRepository productUnitSizeRepository ;

        private readonly ISliderRepository sliderRepository ;

        private readonly ISubClassificationBaseRepository subClassificationBaseRepository ;

        private readonly ISubSubclassificationRepository subSubclassificationRepository ;

        private readonly ITaxConfigurationRepository taxConfigurationRepository ;
        private readonly IAttributeItemRepository attributeItemRepository;
        private readonly IAttributeRepository attributeRepository;
        private readonly IProductAttributeRepository productAttributeRepository;
        private readonly IProductVariationRepository productVariationRepository;
        private readonly IUserRepository userRepository  ;
        private readonly IBasicClassificationRepository basicClassificationRepository;
        private readonly IDetailsDataRepository detailsDataRepository;
        private readonly IProductAdditionalDetailsRepository productAdditionalDetailsRepository;
        private readonly IUnitOfWork unitOfWork;

        public RepositoryManager(IAddProductToFavoriteRepository addProductToFavoriteRepository, IBrandRepository brandRepository, IConfigurationRepository configurationRepository, IProductRepository productRepository, ICouponItemRepository couponItemRepository, ICurrencyRepository currencyRepository, IMainClassificationRepository mainClassificationRepository, IMasterDataRepository masterDataRepository, IProductColorsRepository productColorsRepository, IProductEvaluatonRepository productEvaluatonRepository, IProductImageRepository productImageRepository, IProductSizeRepository productSizeRepository, ISliderRepository sliderRepository, ISubClassificationBaseRepository subClassificationBaseRepository, ISubSubclassificationRepository subSubclassificationRepository, ITaxConfigurationRepository taxConfigurationRepository, IAttributeItemRepository attributeItemRepository, IAttributeRepository attributeRepository, IProductAttributeRepository productAttributeRepository, IProductVariationRepository productVariationRepository, IUserRepository userRepository, IBasicClassificationRepository basicClassificationRepository, IDetailsDataRepository detailsDataRepository, IProductAdditionalDetailsRepository productAdditionalDetailsRepository, IUnitOfWork unitOfWork)
        {
            this.addProductToFavoriteRepository = addProductToFavoriteRepository;
            this.brandRepository = brandRepository;
            this.configurationRepository = configurationRepository;
            this.productRepository = productRepository;
            this.couponItemRepository = couponItemRepository;
            this.currencyRepository = currencyRepository;
            this.mainClassificationRepository = mainClassificationRepository;
            this.masterDataRepository = masterDataRepository;
            this.productColorsRepository = productColorsRepository;
            this.productEvaluatonRepository = productEvaluatonRepository;
            this.productImageRepository = productImageRepository;
            this.productSizeRepository = productSizeRepository;
            this.sliderRepository = sliderRepository;
            this.subClassificationBaseRepository = subClassificationBaseRepository;
            this.subSubclassificationRepository = subSubclassificationRepository;
            this.taxConfigurationRepository = taxConfigurationRepository;
            this.attributeItemRepository = attributeItemRepository;
            this.attributeRepository = attributeRepository;
            this.productAttributeRepository = productAttributeRepository;
            this.productVariationRepository = productVariationRepository;
            this.userRepository = userRepository;
            this.basicClassificationRepository = basicClassificationRepository;
            this.detailsDataRepository = detailsDataRepository;
            this.productAdditionalDetailsRepository = productAdditionalDetailsRepository;
            this.unitOfWork = unitOfWork;
        }

        public IAddProductToFavoriteRepository AddProductToFavoriteRepository => addProductToFavoriteRepository;
        public IBrandRepository BrandRepository => brandRepository;
        public IConfigurationRepository ConfigurationRepository => configurationRepository;
        public IProductRepository ProductRepository => productRepository;
       // public ICouponRepository CouponRepository =>couponRepository;

        public ICouponItemRepository CouponItemRepository => couponItemRepository;
        public ICurrencyRepository CurrencyRepository => currencyRepository;

        public IMainClassificationRepository MainClassificationRepository => mainClassificationRepository;

        public IMasterDataRepository MasterDataRepository => masterDataRepository;

        public IProductColorsRepository ProductColorsRepository => productColorsRepository;

        public IProductEvaluatonRepository ProductEvaluatonRepository => productEvaluatonRepository;
        public IProductImageRepository ProductImageRepository => productImageRepository;

        public IProductSizeRepository ProductSizeRepository => productSizeRepository;

       // public IProductUnitSizeRepository ProductUnitSizeRepository => productUnitSizeRepository;

        public ISliderRepository SliderRepository => sliderRepository;

        public ISubClassificationBaseRepository SubClassificationBaseRepository => subClassificationBaseRepository;

        public ISubSubclassificationRepository SubSubclassificationRepository => subSubclassificationRepository;

        public ITaxConfigurationRepository TaxConfigurationRepository => taxConfigurationRepository;

        public IUserRepository UserRepository => userRepository;

        public IUnitOfWork UnitOfWork => unitOfWork;

        public IAttributeRepository AttributeRepository => attributeRepository;

        public IAttributeItemRepository AttributeItemRepository => attributeItemRepository;

        public IProductAttributeRepository ProductAttributeRepository => productAttributeRepository;

        public IProductVariationRepository ProductVariationRepository => productVariationRepository;

        public IBasicClassificationRepository BasicClassificationRepository => basicClassificationRepository;

        public IDetailsDataRepository DetailsDataRepository => detailsDataRepository;

        public IProductAdditionalDetailsRepository ProductAdditionalDetailsRepository => productAdditionalDetailsRepository;
    }

}

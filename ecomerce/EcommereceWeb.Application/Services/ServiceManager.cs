using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IAddProductToFavoriteService addProductToFavoriteService;
        private readonly IBasicClassificationService basicClassificationService;
        private readonly IBrandService brandService  ;
        private readonly IConfigurationService configurationService   ;
        private readonly IContactService contactServices;
        private readonly ICouponItemService couponItemService ;
        private readonly ICouponService couponService   ;
        private readonly ICurrencyService currencyService;
        private readonly IDetailsDataService detailsDataService;
        private readonly IMainClassificationService mainClassificationService ;
        private readonly IMasterDataService masterDataService  ;
        private readonly IProductService productService ;
        private readonly IProductAdditionalDetailsService productAdditionalDetailsService;
        private readonly IProductColorsService productColorsService  ;
        private readonly IProductEvaluatonService productEvaluatonService;
        private readonly IProductImageService productImageService;
        private readonly IProductSizeService productSizeService;
        private readonly IProductUnitSizeService productUnitSizeService;
        private readonly ISliderService sliderService;
        private readonly ISubClassificationBaseService subClassificationBaseService;
        private readonly ISubSubclassificationService subSubclassificationService;
        private readonly ITaxConfigurationService taxConfigurationService;
        private readonly IProductVariationService productVariationService;
        private readonly IProductAttributeService productAttributeService;
        private readonly IAttributeService attributeService;
        private readonly IAttributeItemService attributeItemService;

        private readonly IUserService userService;
        private readonly IUplaodFileService uplaodFileService;
        private readonly IRoleService roleService;

        public ServiceManager(IAddProductToFavoriteService addProductToFavoriteService, IBasicClassificationService basicClassificationService, IBrandService brandService, IConfigurationService configurationService, IContactService contactServices, ICouponItemService couponItemService, ICouponService couponService, ICurrencyService currencyService, IDetailsDataService detailsDataService, IMainClassificationService mainClassificationService, IMasterDataService masterDataService, IProductService productService, IProductAdditionalDetailsService productAdditionalDetailsService, IProductColorsService productColorsService, IProductEvaluatonService productEvaluatonService, IProductImageService productImageService, IProductSizeService productSizeService, IProductUnitSizeService productUnitSizeService, ISliderService sliderService, ISubClassificationBaseService subClassificationBaseService, ISubSubclassificationService subSubclassificationService, ITaxConfigurationService taxConfigurationService, IProductVariationService productVariationService, IProductAttributeService productAttributeService, IAttributeService attributeService, IAttributeItemService attributeItemService, IUserService userService, IUplaodFileService uplaodFileService, IRoleService roleService)
        {
            this.addProductToFavoriteService = addProductToFavoriteService;
            this.basicClassificationService = basicClassificationService;
            this.brandService = brandService;
            this.configurationService = configurationService;
            this.contactServices = contactServices;
            this.couponItemService = couponItemService;
            this.couponService = couponService;
            this.currencyService = currencyService;
            this.detailsDataService = detailsDataService;
            this.mainClassificationService = mainClassificationService;
            this.masterDataService = masterDataService;
            this.productService = productService;
            this.productAdditionalDetailsService = productAdditionalDetailsService;
            this.productColorsService = productColorsService;
            this.productEvaluatonService = productEvaluatonService;
            this.productImageService = productImageService;
            this.productSizeService = productSizeService;
            this.productUnitSizeService = productUnitSizeService;
            this.sliderService = sliderService;
            this.subClassificationBaseService = subClassificationBaseService;
            this.subSubclassificationService = subSubclassificationService;
            this.taxConfigurationService = taxConfigurationService;
            this.productVariationService = productVariationService;
            this.attributeService = attributeService;
            this.attributeItemService = attributeItemService;
            this.productAttributeService = productAttributeService;
            this.userService = userService;
            this.uplaodFileService = uplaodFileService;
            this.roleService = roleService;
        }

        public IAddProductToFavoriteService AddProductToFavoriteService => addProductToFavoriteService;

        public IBasicClassificationService BasicClassificationService => basicClassificationService;

        public IBrandService BrandService =>brandService;

        public IConfigurationService ConfigurationService => configurationService;

        public IContactService ContactServices => contactServices;

        public ICouponItemService CouponItemService =>couponItemService;

        public ICouponService CouponService => couponService;

        public ICurrencyService CurrencyService => currencyService;

        public IDetailsDataService DetailsDataService => detailsDataService;

        public IMainClassificationService MainClassificationService => mainClassificationService;

        public IMasterDataService MasterDataService => masterDataService;

        public IProductAdditionalDetailsService ProductAdditionalDetailsService =>productAdditionalDetailsService;

        public IProductColorsService ProductColorsService => productColorsService;

        public IProductEvaluatonService ProductEvaluatonService => productEvaluatonService;

        public IProductImageService ProductImageService => productImageService;

        public IProductService ProductService => productService;

        public IProductSizeService ProductSizeService =>productSizeService;

        public IProductUnitSizeService ProductUnitSizeService => productUnitSizeService;

        public ISliderService SliderService => sliderService;

        public ISubClassificationBaseService SubClassificationBaseService => subClassificationBaseService;

        public ISubSubclassificationService SubSubclassificationService =>subSubclassificationService;

        public ITaxConfigurationService TaxConfigurationService => taxConfigurationService;

        public IUserService UserService =>userService;
        public IUplaodFileService UplaodFileService => uplaodFileService;
        public IRoleService RoleService => roleService;

        public IAttributeService AttributeService => attributeService;

        public IAttributeItemService AttributeItemService => attributeItemService;

        public IProductAttributeService ProductAttributeService => productAttributeService;

        public IProductVariationService ProductVariationService => productVariationService;
    }
}

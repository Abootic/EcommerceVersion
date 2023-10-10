using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Product : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }

        public string ArName { get; set; }
        public string? EnName { get; set; }
        // كود  المنتج  عند  مشاركة المنتج يتم ارساله هذا الكود  ليتمكن من البحث عبره
        public string Code { get; set; }
        /* public decimal? Price { get; set; }
         public decimal? Cost { get; set; }
                public int? Quantity { get; set; }

         */
        public string Logo { get; set; }// الصورة الرئيسة للمنتج
        public string? EnDetails { get; set; }
        public string? ArDetails { get; set; }
        public decimal? MinOrderQuantity { get; set; } // اقل كمية يتم  طلبة
        public decimal? MaxOrderQuantity { get; set; } // اكثر كمية يتم  طلبة   //AddNew

        public decimal? Discount { get; set; } // 

        public string? VideoProvider { get; set; }// نوع مزود الخدمة  هل يوتيوب او غيرة 
        public string? VideoUrl { get; set; }
        public int? TaxType { get; set; }// نوع الضريبة  هل قيمة او نسبة مئوية


        public string? ArKeyWords { get; set; }   //AddedNew
        public string? EnKeyWords { get; set; }     //AddedNew

        public int? BrandId { get; set; }//العلامة  التجارية
                                         // from brand model
        public int? MainClassificationId { get; set; }
        //from MainClassfication model
        public int? BasicClassificationId { get; set; }
        // from BasicClassification model
        public int? SubClassificationBaseId { get; set; }
        // from Subclassification model
        public int? SubSubclassificationId { get; set; }
        // from SubSubClassification model

        public virtual MainClassification? MainClassification { get; set; }
        public virtual BasicClassification? BasicClassification { get; set; }
        public virtual SubClassificationBase? SubClassificationBase { get; set; }
        public virtual SubSubclassification? SubSubClassification { get; set; }
        public virtual Brand? Brand { get; set; }

        public virtual ICollection<AddProductToFavorite> AddProductToFavorites { get; set; }
        public virtual ICollection<CouponItem> CouponItems { get; set; }
        public virtual ICollection<ProductAdditionalDetails> ProductAdditionalDetails { get; set; }
        public virtual ICollection<ProductColors> ProductColors { get; set; }
        public virtual ICollection<ProductEvaluaton> ProductEvaluatons { get; set; }
        public virtual ICollection<ProductUnitSize> ProductUnitSizes { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductSize> ProductSize { get; set; }
        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
        public virtual ICollection<ProductVariation> ProductVariations { get; set; }


    }
}

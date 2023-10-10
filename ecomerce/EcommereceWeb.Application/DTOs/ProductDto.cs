

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ProductViewDto
    {

        public int Id { get; set; }

        public string Name { get; set; }

        // كود  المنتج  عند  مشاركة المنتج يتم ارساله هذا الكود  ليتمكن من البحث عبره
        public string Code { get; set; }

        public string Logo { get; set; }// الصورة الرئيسة للمنتج
        public string? Details { get; set; }
        public decimal? MinOrderQuantity { get; set; } // اقل كمية يتم  طلبة
        public decimal? MaxOrderQuantity { get; set; } // اكثر كمية يتم  طلبة
        public decimal? Discount { get; set; }

        public string? VideoProvider { get; set; }// نوع مزود الخدمة  هل يوتيوب او غيرة 
        public string? VideoUrl { get; set; }
        public int? TaxType { get; set; }// نوع الضريبة  هل قيمة او نسبة مئوية


        public string? KeyWords { get; set; }
        public int? BrandId { get; set; }

        public int? MainClassificationId { get; set; }
        public int? BasicClassificationId { get; set; }
        public int? SubClassificationBaseId { get; set; }
        public int? SubSubclassificationId { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }
    public class ProductDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال اسم المنتج       ")]

        [Display(Name = "الاسم")]
        public string ArName { get; set; }
        [Display(Name = "الاسم انجليزي")]
        public string? EnName { get; set; }
        // كود  المنتج  عند  مشاركة المنتج يتم ارساله هذا الكود  ليتمكن من البحث عبره
        [Display(Name = "كود المنتج")]
        public string Code { get; set; }

        [Required(ErrorMessage = " يرجى ادخال صورة المنتج الرئيسية        ")]
        [Display(Name = "الصورة الرئيسية")]
        public string Logo { get; set; }// الصورة الرئيسة للمنتج
        [Display(Name = "الوصف")]
        public string? ArDetails { get; set; }
        [Display(Name = "الوصف انجليزي")]
        public string? EnDetails { get; set; }
        [Display(Name = "اقل كمية يتم  طلبة")]
        public decimal? MinOrderQuantity { get; set; } // اقل كمية يتم  طلبة
        [Display(Name = "اكثر كمية يتم  طلبة")]
        public decimal? MaxOrderQuantity { get; set; } // اكثر كمية يتم  طلبة
        [Display(Name = "الخصم")]
        public decimal? Discount { get; set; }

        public string? VideoProvider { get; set; }// نوع مزود الخدمة  هل يوتيوب او غيرة 
        public string? VideoUrl { get; set; }
        [Display(Name = "نوع الضريبة")]
        public int? TaxType { get; set; }// نوع الضريبة  هل قيمة او نسبة مئوية

        [Display(Name = "الكلمات المفتاحية")]
        public string? ArKeyWords { get; set; }
        [Display(Name = "الكلمات المفتاحية انجليزي")]
        public string? EnKeyWords { get; set; }
        [Display(Name = "رقم الماركة")]

        public int? BrandId { get; set; }//العلامة  التجارية
                                         // from brand model
        [Display(Name = "رقم التصنيف الرئيسي")]

        public int? MainClassificationId { get; set; }
        [Display(Name = "رقم التصنيف الاساسي")]

        public int? BasicClassificationId { get; set; }
        [Display(Name = "رقم التصنيف الفرعي")]

        public int? SubClassificationBaseId { get; set; }
        [Display(Name = "رقم التصنيف فرعي الفرعي")]

        public int? SubSubclassificationId { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }


}



using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class CouponViewDto
    {
      
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Rate { get; set; }
        public int? ApplyTo { get; set; }
                                           
        public int? QtRequire { get; set; }
        public decimal? PriceRequire { get; set; }
        public string? Type { get; set; }
        public string? Details { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }

    public class CouponDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Display(Name = "تاريخ بداية العرض")]
        public DateTime StartDate { get; set; }
        [Display(Name = "تاريخ نهاية العرض")]
        public DateTime EndDate { get; set; }
        [Display(Name = "النسبة")]
        public string Rate { get; set; }
        [Display(Name = "ينطبق على")]
        public int? ApplyTo { get; set; }
        [Display(Name = "الكمية المطلوبة")]
        public int? QtRequire { get; set; }
        [Display(Name = "السعر المطلوب")]
        public decimal? PriceRequire { get; set; }
        [Display(Name = "النوع")]
        public string? Type { get; set; }
        [Display(Name = "الوصف")]
        public string? ArDetails { get; set; }
        [Display(Name = "الوصف انجليزي")]
        public string? EnDetails { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }


}

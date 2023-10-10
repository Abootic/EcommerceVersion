
using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ProductSizeViewDto
    {
        [Required]
        public int Id { get; set; }
        public int? ProductId { get; set; } // from product model
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال    الحجم     ")]
      
        public string SizeName { get; set; } //AddedNew

    }
     public class ProductSizeDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Display(Name = "رقم المنتج")]
        public int? ProductId { get; set; } // from product model
        [Display(Name = "الكمية")]
        public int? Quantity { get; set; }
        [Display(Name = "السعر")]
        public decimal? Price { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال    الحجم     ")]
        [Display(Name = "الحجم")]
        public string? ArSizeName { get; set; }
        [Display(Name = "الحجم انجليزي")]
        public string? EnSizeName { get; set; } 

    }

}

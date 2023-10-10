

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ProductVariationViewDto
    {

        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string? ArName { get; set; }
        public string? EnName { get; set; }
        public string? AttItemId { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
        public int? Quantity { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }


    }
    public class ProductVariationDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Display(Name = "رقم المنتج")]
        public int? ProductId { get; set; }
        [Display(Name = "الصفات عربي  ")]
        public string? ArName { get; set; }
        [Display(Name = "الصفات انجليزي ")]
        public string? EnName { get; set; }
        [Display(Name = "ارقام الصفات ")]
        public string? AttItemId { get; set; }
        [Display(Name = "الصور ")]
        public string? Image { get; set; }
        [Display(Name = "السعر")]
        [Required(ErrorMessage = " يرجى ادخال سعر المنتج       ")]
        public decimal Price { get; set; }
        [Display(Name = "التكلفة")]
        public decimal? Cost { get; set; }
        [Display(Name = "الكمية الكلية")]
        public int? Quantity { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }

}

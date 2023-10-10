
using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ProductUnitSizeViewDto
    {
        public int Id { get; set; }
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public string? Width { get; set; }
        public bool? ProductType { get; set; }
        public int? ProductId { get; set; } // from product model
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
     public class ProductUnitSizeDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Display(Name = "الوزن")]
        public string? Weight { get; set; }
        [Display(Name = "الطول")]
        public string? Height { get; set; }
        [Display(Name = "العرض")]
        public string? Width { get; set; }
        [Display(Name = "نوع المنتج")]
        public bool? ProductType { get; set; }
        [Display(Name = "رقم المنتج")]
        public int? ProductId { get; set; } // from product model
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }

}

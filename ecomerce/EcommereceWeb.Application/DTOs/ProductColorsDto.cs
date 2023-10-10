
using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ProductColorsViewDto
    {
        
        public int Id { get; set; }
        public int? ProductId { get; set; } // from product model
        public int? Quantity { get; set; }
        public string? ImgUrl { get; set; }

        public string ColorName { get; set; }   
    }
     public class ProductColorsDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Display(Name = "رقم المنتج")]
        public int? ProductId { get; set; } // from product model
        [Display(Name = "الكمية")]
        public int? Quantity { get; set; }
        [Display(Name = "الصورة")]
        public string? ImgUrl { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال    الون     ")]
        [Display(Name = "الون")]
        public string ArColorName { get; set; }
        [Display(Name = "الون انجليزي")]
        public string? EnColorName { get; set; }   
    }
    
}

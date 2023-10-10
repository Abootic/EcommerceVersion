
using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ProductImageViewDto
    {
        [Display(Name = "الرقم")]
        public int Id { get; set; }
       
        public int? ProductId { get; set; } // from product model
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
    public class ProductImageDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Display(Name = "رقم المنتج")]
        public int? ProductId { get; set; } // from product model
        [Display(Name = "الصورة ")]
        public string? ImageUrl { get; set; }
        public List<string> Image1 { get; set; } = new List<string>();

        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }

}

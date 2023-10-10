

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ProductAttributeDto 
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Display(Name = "رقم المنتج")]
        public int? ProductId { get; set; }
        [Display(Name = "رقم الصفة")]
        public int? AttributeId { get; set; }
        [Display(Name = "اسم العنصر ")]
        public string? Name { get; set; }
        [Display(Name = "رقم العنصر")]
        public int? AttributeItemId { get; set; }

        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }

}

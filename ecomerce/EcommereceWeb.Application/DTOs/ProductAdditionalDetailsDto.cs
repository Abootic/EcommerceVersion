
using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ProductAdditionalDetailsViewDto
    {
       
        public int Id { get; set; }
        public string Title { get; set; }   

        public string Value { get; set; }   
        public int ProductId { get; set; } // from product model
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }
    public class ProductAdditionalDetailsDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال اسم   العنصر     ")]
        [Display(Name = "اسم العنصر")]
        public string ArTitle { get; set; }
        [Display(Name = "اسم العنصر انجليزي")]
        public string? EnTitle { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال  قيمة  العنصر     ")]
        [Display(Name = "قيمة العنصر")]
        public string ArValue { get; set; }
        [Display(Name = "قيمة العنصر انجليزي")]
        public string? EnValue { get; set; }
        [Display(Name = "رقم المنتج")]
        public int ProductId { get; set; } // from product model
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }
    
}

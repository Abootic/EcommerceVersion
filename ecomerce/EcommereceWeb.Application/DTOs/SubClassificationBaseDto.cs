

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class SubClassificationBaseViewDto
    {
        public int Id { get; set; }

        public string SubClassificationName { get; set; } = null!;
       
        public int? BasicClassificationId { get; set; } 
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
    public class SubClassificationBaseDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال اسم  التصنيف الفرعي     ")]
        [Display(Name = "الاسم")]
        public string ArSubClassificationName { get; set; } = null!;
        [Display(Name = "الاسم انجليزي")]
        public string? EnSubClassificationName { get; set; }
        [Display(Name = "رقم التصنيف الاساسي")]
        public int? BasicClassificationId { get; set; }
        [Display(Name = "الصورة")]
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }


}


using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class MainClassificationViewDto
    {
        public int Id { get; set; }
        public string MainClassificationName { get; set; } 
      
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
     public class MainClassificationDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال اسم  التصنيف الرئيسي     ")]
        [Display(Name = "الاسم")]
        public string ArMainClassificationName { get; set; } = null!;
        [Display(Name = "الاسم انجليزي")]
        public string? EnMainClassificationName { get; set; }
        [Display(Name = "الصورة")]
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
    
}

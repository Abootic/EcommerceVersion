

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{

    public class BasicClassificationViewDto
    {
      
        public int Id { get; set; }
       
        public string BasicClassificationName { get; set; } = null!;
        public int? MainClassificationId { get; set; } 
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
    public class BasicClassificationDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال اسم  التصنيف الاساسي     ")]
        [Display(Name = "الاسم")]
        public string ArBasicClassificationName { get; set; }
        [Display(Name = "الاسم انجليزي")]
        public string? EnBasicClassificationName { get; set; }
        [Display(Name = "رقم التصنيف الرئيسي")]
        public int? MainClassificationId { get; set; }
        [Display(Name = "الصورة")]
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }


}



using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class SubSubclassificationViewDto
    {
       
        public int Id { get; set; }
       
        public string SubSubClassificationName { get; set; } = null!;
      
        public int? SubClassificationBaseId { get; set; } 
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
     public class SubSubclassificationDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال اسم  التصنيف فرعي الفرعي     ")]
        [Display(Name = "الاسم")]
        public string ArSubSubClassificationName { get; set; } = null!;
        [Display(Name = "الاسم انجليزي")]
        public string? EnSubSubClassificationName { get; set; }
        [Display(Name = "رقم النصنيف الفرعي")]
        public int? SubClassificationBaseId { get; set; } // from  Subclassification model
        [Display(Name = "الصورة")]
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }


}

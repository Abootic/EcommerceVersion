

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ConfigurationViewDto
    {
       
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; }

        public string Value { get; set; } = null!;
      
        public string? Description { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }
     public class ConfigurationDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال الاسم     ")]
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        [Display(Name = "الكود الخاص")]
        public string Code { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال القيمة لهذا الاسم     ")]
        [Display(Name = "القيمة")]
        public string ArValue { get; set; }
        [Display(Name = "القيمة انجليزي")]
        public string? EnValue { get; set; }
        [Display(Name = "الوصف")]
        public string? Description { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }


}

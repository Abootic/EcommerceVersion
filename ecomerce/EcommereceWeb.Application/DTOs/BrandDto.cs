

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class BrandViewDto
    {
       
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? CompanyInfo { get; set; }

        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }

     public class BrandDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال اسم  الماركة     ")]
        [Display(Name = "الاسم ")]
        public string ArName { get; set; }
        [Display(Name = "الاسم انجليزي")]
        public string? EnName { get; set; }
        [Display(Name = "معلومات الماركة")]
        public string? CompanyInfo { get; set; }
        [Display(Name = "الصورة")]
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }

}

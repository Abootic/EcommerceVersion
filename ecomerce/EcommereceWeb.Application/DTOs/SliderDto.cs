
using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class SliderViewDto
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
       
        public string ImgUrl { get; set; }
        public string? Details { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }
    public class SliderDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال اسم        ")]
        [Display(Name = "الاسم")]
        public string ArName { get; set; }
        [Display(Name = "الاسم انجليزي")]
        public string? EnName { get; set; }
        [Display(Name = "الصورة")]
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال الصورة        ")]

        public string ImgUrl { get; set; }
        [Display(Name = "التفاصيل")]
        public string? EnDetails { get; set; }
        [Display(Name = "التفاصيل انجليزي")]
        public string? ArDetails { get; set; }
        [Display(Name = "تاريخ البداية")]
        public DateTime StartDate { get; set; }
        [Display(Name = "تاريخ النهائية")]
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }


    }

}

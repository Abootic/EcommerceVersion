

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class AttributeItemViewDto
    {
       
        public int Id { get; set; }
        
        public string Name { get; set; }
       
        public string? Code { get; set; }
        public string? Details { get; set; }
        public string? ColorCode { get; set; }
        public int? AttributeId { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }

    public class AttributeItemDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال اسم       ")]

        [Display(Name = "الاسم ")]
        public string ArName { get; set; }
        [Display(Name = "الاسم انجليزي")]
        public string? EnName { get; set; }
        [Display(Name = "الرمز ")]
        public string? Code { get; set; }
        [Display(Name = "التفاصيل ")]
        public string? Details { get; set; }
        [Display(Name = " رقم الون")]
        public string? ColorCode { get; set; }
        [Display(Name = "رقم العنصر")]
        public int? AttributeId { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }

}

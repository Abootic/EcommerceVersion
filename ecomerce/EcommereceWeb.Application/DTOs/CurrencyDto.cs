

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class CurrencyViewDto
    {
        public int Id { get; set; }
        public string Name { get; set; }   
     

        public string? Simbol { get; set; }
        public string? Value { get; set; }
        public int IsMain { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
     public class CurrencyDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال اسم  العملة     ")]
        [Display(Name = "الاسم")]
        public string ArName { get; set; }
        [Display(Name = "الاسم انجليزي")]
        public string? EnName { get; set; }
        [Display(Name = "رمز العملة")]
        public string? Simbol { get; set; }
        [Display(Name = "القيمة")]
        public string? Value { get; set; }
        [Display(Name = "الرئسية")]
        public int IsMain { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }


}

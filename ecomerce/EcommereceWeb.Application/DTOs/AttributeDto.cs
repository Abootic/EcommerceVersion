

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class AttributeViewDto 
    {
       
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string? Code { get; set; }
   
        public int? Type { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; } 

    }
  public class AttributeDto 
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
        [Display(Name = "النوع")]
        public int? Type { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }

}

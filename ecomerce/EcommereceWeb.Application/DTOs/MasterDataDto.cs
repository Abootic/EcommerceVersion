

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class MasterDataViewDto
    {
       
        public int Id { get; set; }
        public int CodeValue { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
     public class MasterDataDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Display(Name = "الكود")]
        public int CodeValue { get; set; }
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        [Display(Name = "الوصف")]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }


}

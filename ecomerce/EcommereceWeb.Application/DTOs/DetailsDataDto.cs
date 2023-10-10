

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class DetailsDataViewDto
    {
        public int Id { get; set; }
        public string Value { get; set; }  
        public string? Description { get; set; }
        public int? MasterDataId { get; set; } // from MasterData model
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }
      public class DetailsDataDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " يرجى ادخال القيمة       ")]
        [Display(Name = "القيمة")]
        public string ArValue { get; set; }
        [Display(Name = "القيمة انجليزي")]
        public string? EnValue { get; set; }
        [Display(Name = "الوصف")]
        public string? Description { get; set; }
        public int? MasterDataId { get; set; } // from MasterData model

        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }


}

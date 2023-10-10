

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ProductEvaluatonViewDto
    {
        public int Id { get; set; }

        public double Rating { get; set; }
        public string Comment { get; set; }
        public int? ProductId { get; set; }
        public string? UserId { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }

    public class ProductEvaluatonDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Display(Name = "النسبة")]
        public double Rating { get; set; }
        [Display(Name = "التعليق")]
        public string Comment { get; set; }
        [Display(Name = "رقم المنتج")]
        public int? ProductId { get; set; }
        [Display(Name = "المستخدم")]
        public string? UserId { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }


}

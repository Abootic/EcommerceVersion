

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class CouponItemViewDto
    {
        
        public int Id { get; set; }

        public int? CouponId { get; set; }
        public string? ProductId { get; set; }  //   productId 
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }
    public class CouponItemDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Display(Name = "رقم الكوبون")]
        public int? CouponId { get; set; }
        [Display(Name = "رقم المنتج")]
        public string? ProductId { get; set; }  //   productId 

        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }


}

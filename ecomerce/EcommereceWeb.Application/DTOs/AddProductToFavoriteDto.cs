

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class AddProductToFavoriteViewDto
    {
        
        public int Id { get; set; }
        public int? ProductId { get; set; } // from Product Model
        public string? UserId { get; set; } // from user Model
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

    }

     public class AddProductToFavoriteDto
    {
        [Required]
        [Display(Name ="الرقم")]
        public int Id { get; set; }
        [Display(Name = "رقم المنتج")]
        public int? ProductId { get; set; }
        // from Product Model
        [Display(Name = "رقم المستخدم")]
        public string? UserId { get; set; } // from user Model

        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }


}

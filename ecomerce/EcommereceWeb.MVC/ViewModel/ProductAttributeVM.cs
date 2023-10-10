using EcommereceWeb.Application.DTOs;

namespace EcommereceWeb.MVC.ViewModel
{
    public class ProductAttributeVM
    {
        public List<ProductVariationDto> productVariationDto { get; set; }
        public int productId { get; set; }

    }
}

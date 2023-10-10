using EcommereceWeb.Application.DTOs;

namespace EcommereceWeb.MVC.ViewModel
{
    public class ProductAdditionalVM
    {
        public List<CheckBoxListVm> checkBoxListVms { get; set; }
        public ProductAttributeDto ProductAttributeDto { get; set; }
        public CheckBoxListVm CheckBoxListVm { get; set; }
        public ProductDto productDto { get; set; }
        public int ProductId { get; set; }
        public int? AttributeId { get; set; }
        public string AttributeItemId { get; set; }
        public string Name { get; set; }

    }
}

using EcommereceWeb.Application.DTOs;

namespace EcommereceWeb.MVC.ViewModel
{
	public class ProductHomeVm
	{
		public List<ProdctListVm> prodctListVms { get; set; }
		public List<SliderDto> Slider { get; set; }
		public ProductDetailsVM productDetails { get; set; }
	}
}

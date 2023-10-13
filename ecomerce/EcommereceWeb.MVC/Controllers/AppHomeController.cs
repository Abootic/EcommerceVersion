using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class AppHomeController : BaseMVCController
    {

		public async Task<IActionResult> Index()
        {
			ProductHomeVm productHomeVm = new ProductHomeVm();
			productHomeVm.productDetails=new ProductDetailsVM();
			productHomeVm.prodctListVms  = new List<ProdctListVm>();
			productHomeVm.Slider = new List<SliderDto>();
			var res =await ServiceManager.ProductService.GetAll();
			if(res.Status.Succeeded)
			{
				foreach(var item in res.Data)
				{

					Console.WriteLine($"product idddddddddddddddddd   {item.Id}");
					var respRODUCTvaration = await ServiceManager.ProductVariationService.Find(a => a.ProductId.Value == item.Id);
					if(respRODUCTvaration.Status.Succeeded) {
					foreach(var item2 in respRODUCTvaration.Data)
						{
							Console.WriteLine($"produt varrrrrrrrrrrrrr   {item2.Id}");
							Console.WriteLine($"prodct id 22222222222   {item2.ProductId}");
							var prodctListVm = new ProdctListVm
							{
								Id = item.Id,
								Name = item.ArName,
								description = item.ArDetails,
								Price = item2.Price,
								image = item.Logo,
								discount = item.Discount
							};
							productHomeVm.prodctListVms.Add(prodctListVm);
						}
					}
					
					
				}
				return View(productHomeVm);

			}
			return View(productHomeVm);
		}

		public async Task<IActionResult> AppIndex()
		{
			var res = await ServiceManager.SliderService.GetAll();
			Console.WriteLine($"aaaaaaaaaa  {res.Data.First().ArName}");
			if (res.Status.Succeeded)
			{
				return PartialView("Views/Slider/AppIndex.schtml", res.Data);
			}
			return View();

		}
		public async Task<IActionResult> ProducrDetails(int productId)
		{

			var product = await ServiceManager.ProductService.GetById(productId);
			if (product.Status.Succeeded)
			{
				var resProductVaration = await ServiceManager.ProductVariationService.Find(a => a.ProductId == product.Data.Id);
				if (resProductVaration.Status.Succeeded)
				{
					foreach(var item in resProductVaration.Data)
					{

					}
				}
				
			}
			return View();
		}
	}
}

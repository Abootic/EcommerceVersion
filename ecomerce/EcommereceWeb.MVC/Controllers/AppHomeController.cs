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
			decimal TatalTax = 0.0m;
			ProductHomeVm productHomeVm = new ProductHomeVm();
			productHomeVm.productDetails=new ProductDetailsVM();
			productHomeVm.prodctListVms  = new List<ProdctListVm>();
			productHomeVm.Slider = new List<SliderDto>();
			var res =await ServiceManager.ProductService.GetAll();
			if(res.Status.Succeeded)
			{
				foreach(var item in res.Data)
				{

					
					var respRODUCTvaration = await ServiceManager.ProductVariationService.Find(a => a.ProductId.Value == item.Id);
					if(respRODUCTvaration.Status.Succeeded) {
						if (item.TaxType == 0)

						{
							foreach (var item2 in respRODUCTvaration.Data)
							{
							
								


								var prodctListVm = new ProdctListVm
								{
									Id = item.Id,
									productName = item.ArName,
									description = item.ArDetails,
									Price = item2.Price,
									image = item.Logo,
									discount = item.Discount
								};
								productHomeVm.prodctListVms.Add(prodctListVm);
							}
						}
						else
						{


							var taxRes = await ServiceManager.TaxConfigurationService.GetAll();
							var _tax = 1;
							if (taxRes.Status.Succeeded)
							{
								foreach(var taxItem in taxRes.Data)

									if (taxItem.Value != null)
									{
										_tax = int.Parse(taxItem.Value);
									}


								 TatalTax = Convert.ToDecimal( _tax);
								
							
								foreach (var item2 in respRODUCTvaration.Data)
								{
									decimal t = item2.Price * (TatalTax / 100);

								//	decimal totalPraice =( (totalTax/100) * item2.Price);
									Console.WriteLine($"222222222222222222 {t}");

									var prodctListVm = new ProdctListVm
									{
										Id = item.Id,
										productName = item.ArName,
										description = item.ArDetails,
										Price = t+item2.Price,
										image = item.Logo,
										discount = item.Discount,
										Taxtype = "ضريبة مبسطة"

									};
									productHomeVm.prodctListVms.Add(prodctListVm);
								}
							}
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

using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class AppHomeController : BaseMVCController
    {
		public async Task<IActionResult> Index()
        {
		
			return View();
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
	}
}

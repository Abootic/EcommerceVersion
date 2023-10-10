using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Services;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductController : BaseMVCController
    {
        public async Task<IActionResult> IndexProd()
        {
            var res = await ServiceManager.ProductService.GetAll();
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;
            return View();
        }
        public async Task<IActionResult> Index1()
        {
           
            return View();
        }
        public IActionResult Index(int? pid )
        {

            ProductDto productDto = new ProductDto();
            if (pid != null)
            {
                productDto.Id = pid.Value;
            }
           
            return View(productDto); 
           
        }  
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductDto entity) {
            if (entity == null) RedirectToAction("Index");
           
            entity.Code = "2";
          
            entity.VideoProvider = "5";
            entity.VideoUrl = "8";
            entity.EnKeyWords = "8ss";
            var res = await ServiceManager.ProductService.Add(entity);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index", new { pid = res.Data.Id });

            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Index", new { pid =0 });
        }

     
    }
}

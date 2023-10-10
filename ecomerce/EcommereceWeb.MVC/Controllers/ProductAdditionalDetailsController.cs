using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductAdditionalDetailsController : BaseMVCController
    {
        public async Task<IActionResult> Index( int id)
        {
           
            if (id != 0)
            {
                Console.WriteLine($"ffffffffffff   {id}");
                TempData.SetTemp<int>("ProductId", id);
                var res = await ServiceManager.ProductAdditionalDetailsService.Find(a => a.ProductId == id);
                var mainRes = await ServiceManager.ProductService.GetById(id);
                if (mainRes.Status.Succeeded)
                {
                    TempData.SetTemp<string>("name", mainRes.Data.ArName);
                    TempData["Id"] = id;
                    if (res.Status.Succeeded)
                    {

                        return View(res.Data);
                    }
                    TempData["msg"] = res.Status.message;
                    return View();
                }
                else
                {
                    TempData["msg"] = "لا يوجد بيانات ملحقة بهذا الرقم";
                    return RedirectToAction("IndexProd", "Product");
                }

            }
            else
            {
                return RedirectToAction("IndexProd", "Product");
            }
        }
        public async Task<IActionResult> Create(int productId)
        {
            if(productId != 0)
            {
                ProductAdditionalDetailsDto productAdditionalDetailsDto = new ProductAdditionalDetailsDto();
                productAdditionalDetailsDto.ProductId = productId;
                return View(productAdditionalDetailsDto);
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductAdditionalDetailsDto entity)
        {
            try
            {
                if (entity == null) { TempData["err"] =  "ادخل البيانات"; return RedirectToAction("Create", new { productId = entity.ProductId }); }
                if (!ModelState.IsValid)
                {
                    TempData["msg"] = "خطاء في البيانات";
                    Console.WriteLine("in ModelState inValid");
                    ModelState.AsEnumerable().ToList().ForEach(x => Console.WriteLine("Key : {0},value:{1}", x.Key, ModelState.GetValidationState(x.Key).ToString()));
                    return View(entity);
                }
                else
                {
                    var res = await ServiceManager.ProductAdditionalDetailsService.Add(entity);
                    if (res.Status.Succeeded)
                    {
                        TempData["msg"] = res.Status.message;
                        return RedirectToAction("Create", new { productId = entity.ProductId });
                    }
                    TempData["msg"] = res.Status.message;
                    return RedirectToAction("Create", new { productId = entity.ProductId });
                }
            }
            catch (Exception ex)
            {

                TempData["msg"] = ex.Message;
                Console.WriteLine("in Catch");
                return View(entity);
            }

            
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var res = await ServiceManager.ProductAdditionalDetailsService.GetById(Id);
            var mainRes = await ServiceManager.ProductService.GetById(res.Data.ProductId);

            TempData.SetTemp<int>("ProductId", mainRes.Data.Id);

            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;

            return RedirectToAction("Index", new { id = TempData["Id"] });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductAdditionalDetailsDto entity)
        {

            if (entity == null) { TempData["msg"] =  "ادخل البيانات"; return View(entity); }
            var res = await ServiceManager.ProductAdditionalDetailsService.Update(entity);
            TempData.SetTemp<int>("ProductId", res.Data.ProductId);

            if (res.Status.Succeeded)
            {
                TempData["msg"] = res.Status.message;
                return RedirectToAction("Index", new { id = TempData["Id"] });
            }
            TempData["msg"] = res.Status.message;
            return View(entity);
        }
        public async Task<ActionResult> Delete(int Id)
        {
            try
            {
                var res = await ServiceManager.ProductAdditionalDetailsService.Remove(Id);
                if (res.Status.Succeeded)
                {
                    TempData["msg"] = res.Status.message;
                    TempData["suc"] = "تم الحذف بنجاح";
                    return RedirectToAction("Index", new { id = TempData["Id"] });
                }
                else
                {


                    TempData["msg"] = res.Status.message;
                    TempData["didentDelete"] = "لا يمكن حذف العنصر لانه هناك بيانات في جداول  اخرى متعلقة في هذا العنصر .قم بحذف البيانات المتعلقة بعدين احذف العنصر";

                    return RedirectToAction("Index", new { id = TempData["Id"] });
                }

            }


            catch (Exception ex)
            {

                TempData["msg"] = $"error {ex.Message}  ";
                return RedirectToAction("Index", new { id = TempData["Id"] });
            }

        }


    }
}

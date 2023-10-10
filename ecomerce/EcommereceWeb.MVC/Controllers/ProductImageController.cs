using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductImageController : BaseMVCController
    {
        public async Task<IActionResult> Index(int id)
        {
            if (id != 0)
            {
              
                var res = await ServiceManager.ProductImageService.Find(a => a.ProductId == id);
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
                    TempData["msg"] = "لا توجد صور  بهذا الرقم";
                    return RedirectToAction("IndexProd", "Product");
                }

            }
            else
            {
                return RedirectToAction("IndexProd", "Product");
            }
        }     
        public IActionResult Create(int productId)
        {
            if (productId != 0)
            {
                var productimag = new ProductImageDto { ProductId = productId };
                return View(productimag);
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductImageDto entity)
        {
            Console.WriteLine("ddddddddddddddddddddddddddddddddddddddddddddddd");
            var imgList = new List<string>();
            bool success = false;
            string msg = "";
            var e = new ProductImageDto();

            if (entity == null) return RedirectToAction("Create", new { productId = entity.ProductId });
            for (int i = 0; i < entity.Image1.Count; i++)
            {
                if (entity.Image1[i] != null)
                {
                    imgList = entity.Image1[i].Split(",").ToList();
                }
                else
                {
                    TempData["err"] = "لم يتم اختيار صورة";
                    return View(entity);
                }
            }
            for (int i = 0; i < imgList.Count; i++)
            {

                e.ImageUrl = imgList[i];
                e.ProductId = entity.ProductId;
                var res = await ServiceManager.ProductImageService.Add(e);
                if (res.Status.Succeeded)
                {
                    success = res.Status.Succeeded;
                    msg = res.Status.message;
                }
                else
                {
                    success = res.Status.Succeeded;
                    msg = res.Status.message;
                }

               

            }

            if (success)
            {
                TempData["suc"] = msg;
                return RedirectToAction("Create", new { productId = entity.ProductId });
            }
            TempData["err"] = msg;

            return RedirectToAction("Create", new { productId = entity.ProductId });



        }
        public async Task<IActionResult> Edit(int Id)
        {
            var res = await ServiceManager.ProductImageService.GetById(Id);
            var mainRes = await ServiceManager.ProductService.GetById((int)res.Data.ProductId);

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
        public async Task<IActionResult> Edit(ProductImageDto entity)
        {

            if (entity == null) { TempData["msg"] = "ادخل البيانات"; return View(entity); }
            var res = await ServiceManager.ProductImageService.Update(entity);
            TempData.SetTemp<int>("ProductId",(int) res.Data.ProductId);

            if (res.Status.Succeeded)
            {
                TempData["msg"] = res.Status.message;
                return RedirectToAction("Index", new { id = TempData["Id"] });
            }
            TempData["msg"] = res.Status.message;
            return View(entity);
        }
        public async Task<IActionResult> Delete(int Id)
        {

            try
            {

                var res = await ServiceManager.ProductImageService.Remove(Id);
                if (res.Status.Succeeded)
                {
                    const string folderName = "ProductImage";
                    var deleteRes = ServiceManager.UplaodFileService.DeleteImageFile(res.Data.ImageUrl, folderName);

                    if (deleteRes == true)
                    {

                        TempData["msg"] = res.Status.message;
                        TempData["suc"] = "تم الحذف بنجاح";
                        return RedirectToAction("Index", new { id = TempData["Id"] });
                    }
                    else
                    {
                        TempData["msg"] = "file not deleted because there is no file name ";

                        return RedirectToAction("Index", new { id = TempData["Id"] });
                    }

                }
                else
                {


                    TempData["msg"] = res.Status.message;
                    TempData["didentDelete"] = "لا يمكن حذف الصورة  لانه هناك بيانات في   جداول  اخرى متعلقة في هذا الصورة .قم بحذف البيانات المتعلقة بعدين احذف الصورة";

                    return RedirectToAction("Index", new { Id = TempData["Id"] });
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

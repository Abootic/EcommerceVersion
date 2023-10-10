using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ProductVariationController : BaseMVCController
    {
        // GET: ProductVariationController
        public async Task<ActionResult> Index(int id)
        {
            if (id != 0)
            {
                Console.WriteLine($"ffffffffffff   {id}");
                TempData.SetTemp<int>("ProductId", id);
                TempData["Id"] = id;
                var res = await ServiceManager.ProductVariationService.Find(a => a.ProductId == id);
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
                    TempData["msg"] = "لا يوجد منتج  بهذا الرقم";
                    return RedirectToAction("IndexProd", "Product");
                }

            }
            else
            {
                return RedirectToAction("IndexProd", "Product");
            }
        }

        // GET: ProductVariationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductVariationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductVariationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductVariationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductVariationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductVariationController/Delete/5
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {

                var res = await ServiceManager.ProductVariationService.Remove(Id);
                if (res.Status.Succeeded)
                {
                    const string folderName = "variation";
                    var deleteRes = ServiceManager.UplaodFileService.DeleteImageFile(res.Data.Image, folderName);

                    if (deleteRes == true)
                    {

                        TempData["msg"] = res.Status.message;
                        TempData["suc"] = "تم الحذف بنجاح";
                        return RedirectToAction("Index", new { MainClassificationId = TempData["Id"] });
                    }
                    else
                    {
                        TempData["msg"] = "file not deleted because there is no file name ";

                        return RedirectToAction("Index", "ProductVariation", new { id = TempData["Id"] });
                    }

                }
                else
                {


                    TempData["msg"] = res.Status.message;
                    TempData["didentDelete"] = "لا يمكن حذف متغيرات المنتج لانه هناك بيانات في جداول   اخرى متعلقة في هذا الجدول .قم بحذف البيانات المتعلقة بعدين احذف متغيرات المنتج";

                    return RedirectToAction("Index", "ProductVariation", new { id = TempData["Id"] });
                }

            }


            catch (Exception ex)
            {

                TempData["msg"] = $"error {ex.Message}  ";
                return RedirectToAction("Index", "ProductVariation", new { id = TempData["Id"] });
            }

        }
    }
}

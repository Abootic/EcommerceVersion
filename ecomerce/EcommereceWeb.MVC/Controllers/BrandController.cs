using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class BrandController : BaseMVCController
    {
        public async Task<IActionResult> Index()
        {
            var res = await ServiceManager.BrandService.GetAll();
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            return View();

        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BrandDto entity)
        {

            if (entity == null) { TempData["err"] = "ادخل البيانات"; return View(entity); }
            var res = await ServiceManager.BrandService.Add(entity);
            if (res.Status.Succeeded)
            {
                TempData["msg"] = res.Status.message;
                return RedirectToAction("Index");
            }
            TempData["msg"] = res.Status.message;
            return View(entity);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var res = await ServiceManager.BrandService.GetById(Id);
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BrandDto entity)
        {

            if (entity == null) { TempData["err"] = "ادخل البيانات"; return View(entity); }
            var res = await ServiceManager.BrandService.Update(entity);
            if (res.Status.Succeeded)
            {

                TempData["msg"] = res.Status.message;
                return RedirectToAction("Index");
            }
            TempData["msg"] = res.Status.message;
            return View(entity);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var res = await ServiceManager.BrandService.Remove(Id);
                if (res.Status.Succeeded)
                {
                    const string folderName = "Brand";
                    var deleteRes = ServiceManager.UplaodFileService.DeleteImageFile(res.Data.ImageUrl, folderName);


                    if (deleteRes == true)
                    {

                        TempData["msg"] = res.Status.message;
                        TempData["suc"] = "تم الحذف بنجاح";
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        TempData["msg"] = "file not deleted because there is no file name ";

                        return RedirectToAction(nameof(Index));
                    }

                }
                else
                {


                    TempData["msg"] = res.Status.message;
                    TempData["didentDelete"] = "لا يمكن حذف التصنيف الفرعي لانه هناك بيانات في التصنيفات فرعية الفرعية  اخرى متعلقة في هذا التصنيف .قم بحذف البيانات المتعلقة بعدين احذف التصنيف";

                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {


                TempData["msg"] = $"error {ex.Message}  ";
                return RedirectToAction(nameof(Index));
            }
          

        }

    }
}

using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class SliderController : BaseMVCController
    {
        public async Task<IActionResult> Index()
        {
            var res = await ServiceManager.SliderService.GetAll();
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
        public async Task<IActionResult> Create(SliderDto entity)
        {

            if (entity == null) { TempData["err"] = "ادخل البيانات"; return View(entity); }
            var res = await ServiceManager.SliderService.Add(entity);
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
            var res = await ServiceManager.SliderService.GetById(Id);
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SliderDto entity)
        {

            if (entity == null) { TempData["msg"] = "ادخل البيانات"; return View(entity); }
            var res = await ServiceManager.SliderService.Update(entity);
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
                var res = await ServiceManager.SliderService.Remove(Id);
                if (res.Status.Succeeded)
                {
                    const string folderName = "Slider";
                    var deleteRes = ServiceManager.UplaodFileService.DeleteImageFile(res.Data.ImgUrl, folderName);


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
                TempData["err"] = res.Status.message;
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {


                TempData["msg"] = $"error {ex.Message}  ";
                return RedirectToAction(nameof(Index));
            }

        }



    }
}

using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Services;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class MainClassificationController : BaseMVCController
    {
        public async Task<IActionResult> Index()
        {
            var res = await ServiceManager.MainClassificationService.GetAll();
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;

            return View();

        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MainClassificationDto entity)
        {
            try
            {
                if (entity == null)
                {
                    TempData["msg"] = "ادخل البيانات";
                     return View(entity); 
                }
                if (!ModelState.IsValid)
                {

                    TempData["msg"] = "خطاء في البيانات";
                    //TempData["msg"] = "errrror";
                    Console.WriteLine("in ModelState inValid");
                    ModelState.AsEnumerable().ToList().ForEach(x => Console.WriteLine("Key : {0},value:{1}", x.Key, ModelState.GetValidationState(x.Key).ToString()));


                    return View(entity);

                }
                else
                {
                    var res = await ServiceManager.MainClassificationService.Add(entity);
                    if (res.Status.Succeeded)
                    {
                        TempData["msg"] = res.Status.message;

                        return RedirectToAction("Index");
                    }
                    TempData["msg"] = res.Status.message;
                    return View(entity);
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
            
            var res = await ServiceManager.MainClassificationService.GetById(Id);
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MainClassificationDto entity)
        {

            if (entity == null) { TempData["msg"] = "ادخل البيانات";  return View(entity); }
            var res = await ServiceManager.MainClassificationService.Update(entity);
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
                var res = await ServiceManager.MainClassificationService.Remove(Id);
                if (res.Status.Succeeded)
                {
                    const string folderName = "MainClassification";
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
                    TempData["didentDelete"] = "لا يمكن حذف التصنيف لانه هناك بيانات في التصنيفات الاساسية اخرى متعلقة في هذا التصنيف .قم بحذف البيانات المتعلقة بعدين احذف التصنيف";

                    return RedirectToAction(nameof(Index));
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

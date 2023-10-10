using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Services;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using EcommereceWeb.MVC.Services;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.MVC.Controllers
{
    public class BasicClassificationController : BaseMVCController
    {
        public async Task<IActionResult> Index(int MainClassificationId)
        {
            if (MainClassificationId != 0)
            {
                Console.WriteLine($"ffffffffffff   {MainClassificationId}");
                TempData.SetTemp<int>("MainClassificationId", MainClassificationId);
                var res = await ServiceManager.BasicClassificationService.Find(a => a.MainClassificationId == MainClassificationId);
                var mainRes = await ServiceManager.MainClassificationService.GetById(MainClassificationId);
                if (mainRes.Status.Succeeded)
                {
                    TempData.SetTemp<string>("name", mainRes.Data.ArMainClassificationName);
                    TempData["Id"] = MainClassificationId;
                    if (res.Status.Succeeded)
                    {

                        return View(res.Data);
                    }
                    TempData["msg"] = res.Status.message;
                    return View();
                }
                else
                {
                 TempData["msg"] = "لا يوجد تصنيفات اساسية بهذا الرقم";
                return RedirectToAction("Index", "MainClassification");
                }
              
            }
            else
            {
                return RedirectToAction("Index", "MainClassification");
            }
        }
        public async Task<IActionResult> Create(int MainClassificationId)
        {
            if(MainClassificationId != 0)
            {
                TempData.SetTemp<int>("MainClassificationId", MainClassificationId);
                var obj = new BasicClassificationDto { MainClassificationId = MainClassificationId };
                var res = await ServiceManager.MainClassificationService.GetById(MainClassificationId);
              
                 if (res.Status.Succeeded)
                   {
                   TempData.SetTemp<string>("name", res.Data.ArMainClassificationName);            
                  return View(obj);             
                    }
                    else
                    {
                        return RedirectToAction("Index", new { id = MainClassificationId });
                    }
            }
            else
            {
                return RedirectToAction("Index", "MainClassification");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BasicClassificationDto entity)
        {
            try
            {
                if (entity == null) { TempData["msg"] = "ادخل البيانات"; return View(entity); }
                if (!ModelState.IsValid)
                {
                    TempData["msg"] = "خطاء في البيانات";
                    Console.WriteLine("in ModelState inValid");
                    ModelState.AsEnumerable().ToList().ForEach(x => Console.WriteLine("Key : {0},value:{1}", x.Key, ModelState.GetValidationState(x.Key).ToString()));
                    return View(entity);
                }
                else
                {
                    var res = await ServiceManager.BasicClassificationService.Add(entity);
                    if (res.Status.Succeeded)
                    {
                        TempData.SetTemp<int>("MainClassificationId", (int)res.Data.MainClassificationId);

                        TempData["msg"] = res.Status.message;
                        return RedirectToAction("Index", new { MainClassificationId = entity.MainClassificationId });
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
            var res = await ServiceManager.BasicClassificationService.GetById(Id);
            if (res.Status.Succeeded)
            {
                TempData.SetTemp<int>("MainClassificationId", (int)res.Data.MainClassificationId);

                TempData.SetTemp<string>("name", res.Data.ArBasicClassificationName);
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BasicClassificationDto entity)
        {

            if (entity == null) { TempData["msg"] = "ادخل البيانات"; return View(entity); }
            var res = await ServiceManager.BasicClassificationService.Update(entity);
            if (res.Status.Succeeded)
            {

                TempData["msg"] = res.Status.message;
                return RedirectToAction("Index", new { MainClassificationId = entity.MainClassificationId });
            }
            TempData["msg"] = res.Status.message;
            return View(entity);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
               
                var res = await ServiceManager.BasicClassificationService.Remove(Id);
                if (res.Status.Succeeded)
                {
                    const string folderName = "BasicClassification";
                    var deleteRes = ServiceManager.UplaodFileService.DeleteImageFile(res.Data.ImageUrl, folderName);
                   
                    if (deleteRes == true)
                    {

                        TempData["msg"] = res.Status.message;
                        TempData["suc"] = "تم الحذف بنجاح";
                        return RedirectToAction("Index", new { MainClassificationId = TempData["Id"] });
                    }
                    else
                    {
                        TempData["msg"] = "file not deleted because there is no file name ";

                        return RedirectToAction("Index", new { MainClassificationId = TempData["Id"] });
                    }

                }
                else
                {


                    TempData["msg"] = res.Status.message;
                    TempData["didentDelete"] = "لا يمكن حذف التصنيف الاساسي لانه هناك بيانات في التصنيفات الفرعية  اخرى متعلقة في هذا التصنيف .قم بحذف البيانات المتعلقة بعدين احذف التصنيف";

                    return RedirectToAction("Index", new { MainClassificationId = TempData["Id"] });
                }

            }


            catch (Exception ex)
            {

                TempData["msg"] = $"error {ex.Message}  ";
                return RedirectToAction("Index", new { MainClassificationId = TempData["Id"] });
            }

        }
        public async Task<IActionResult> GetmainBisikClassFication(int mainClassficationId)
        {
            var res = await ServiceManager.BasicClassificationService.Find(a => a.MainClassificationId == mainClassficationId);
            var list = new List<dynamic>();
            if (res.Status.Succeeded)
            {
                foreach (var item in res.Data)
                {
                    var dict = new Dictionary<string, dynamic>();
                    dict.Add("id", item.Id);
                    dict.Add("name", item.ArBasicClassificationName);
                    list.Add(dict);
                }
                return Ok(list);
            }
            return BadRequest(res.Status.message);
        }


    }
}

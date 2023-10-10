using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class SubClassificationBaseController : BaseMVCController
    {

        public async Task<IActionResult> Index(int BasicClassificationId)
        {
            if (BasicClassificationId != 0)
            {
                Console.WriteLine($"ffffffffffff   {BasicClassificationId}");
                TempData.SetTemp<int>("BasicClassificationId", BasicClassificationId);
                var res = await ServiceManager.SubClassificationBaseService.Find(a => a.BasicClassificationId == BasicClassificationId);
                var mainRes = await ServiceManager.BasicClassificationService.GetById(BasicClassificationId);
                if (mainRes.Status.Succeeded)
                {
                    TempData.SetTemp<string>("name", mainRes.Data.ArBasicClassificationName);
                    TempData.SetTemp<int>("MainClassificationId", (int)mainRes.Data.MainClassificationId);

                    TempData["Id"] = BasicClassificationId;
                    if (res.Status.Succeeded)
                    {

                        return View(res.Data);
                    }
                    TempData["msg"] = res.Status.message;
                    return View();
                }
                else
                {
                    TempData["msg"] = "لا يوجد تصنيفات فرعية بهذا الرقم";
                    return RedirectToAction("Index", "MainClassification");
                }

            }
            else
            {
                return RedirectToAction("Index", "MainClassification");
            }
           

        }
        public async Task<IActionResult> Create(int BasicClassificationId)
        {
           
            if (BasicClassificationId != 0)
            {
                TempData.SetTemp<int>("BasicClassificationId", BasicClassificationId);
                var obj = new SubClassificationBaseDto { BasicClassificationId = BasicClassificationId };
                var res = await ServiceManager.BasicClassificationService.GetById(BasicClassificationId);

                if (res.Status.Succeeded)
                {
                    TempData.SetTemp<string>("name", res.Data.ArBasicClassificationName);
                    return View(obj);
                }
                else
                {
                    return RedirectToAction("Index", new { id = BasicClassificationId });
                }
            }
            else
            {
                return RedirectToAction("Index", "MainClassification");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubClassificationBaseDto entity)
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
                    var res = await ServiceManager.SubClassificationBaseService.Add(entity);
                    if (res.Status.Succeeded)
                    {
                        TempData.SetTemp<int>("BasicClassificationId", (int)res.Data.BasicClassificationId);

                        TempData["msg"] = res.Status.message;
                        return RedirectToAction("Index", new { BasicClassificationId = entity.BasicClassificationId });
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
            var res = await ServiceManager.SubClassificationBaseService.GetById(Id);
            if (res.Status.Succeeded)
            {
                TempData.SetTemp<int>("BasicClassificationId", (int)res.Data.BasicClassificationId);

                TempData.SetTemp<string>("name", res.Data.ArSubClassificationName);
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SubClassificationBaseDto entity)
        {

            if (entity == null) { TempData["msg"] =  "ادخل البيانات"; return View(entity); }
            var res = await ServiceManager.SubClassificationBaseService.Update(entity);
            if (res.Status.Succeeded)
            {

                TempData["msg"] = res.Status.message;
                return RedirectToAction("Index", new { BasicClassificationId = entity.BasicClassificationId });
            }
            TempData["msg"] = res.Status.message;
            return View(entity);
        }
        public async Task<IActionResult> Delete(int Id)
        {

            try
            {

                var res = await ServiceManager.SubClassificationBaseService.Remove(Id);
                if (res.Status.Succeeded)
                {
                    const string folderName = "SubClassificationBase";
                    var deleteRes = ServiceManager.UplaodFileService.DeleteImageFile(res.Data.ImageUrl, folderName);

                    if (deleteRes == true)
                    {

                        TempData["msg"] = res.Status.message;
                        TempData["suc"] = "تم الحذف بنجاح";
                        return RedirectToAction("Index", new { BasicClassificationId = TempData["Id"] });
                    }
                    else
                    {
                        TempData["msg"] = "file not deleted because there is no file name ";

                        return RedirectToAction("Index", new { BasicClassificationId = TempData["Id"] });
                    }

                }
                else
                {


                    TempData["msg"] = res.Status.message;
                    TempData["didentDelete"] = "لا يمكن حذف التصنيف الفرعي لانه هناك بيانات في التصنيفات فرعية الفرعية  اخرى متعلقة في هذا التصنيف .قم بحذف البيانات المتعلقة بعدين احذف التصنيف";

                    return RedirectToAction("Index", new { BasicClassificationId = TempData["Id"] });
                }

            }


            catch (Exception ex)
            {

                TempData["msg"] = $"error {ex.Message}  ";
                return RedirectToAction("Index", new { BasicClassificationId = TempData["Id"] });
            }

        }


        public async Task<IActionResult> GetSubclassFicationBase(int bisikId)
        {
            var res = await ServiceManager.SubClassificationBaseService.Find(a => a.BasicClassificationId == bisikId);
            var list = new List<dynamic>();
            if (res.Status.Succeeded)
            {
                foreach (var item in res.Data)
                {
                    var dict = new Dictionary<string, dynamic>();
                    dict.Add("id", item.Id);
                    dict.Add("name", item.ArSubClassificationName);
                    list.Add(dict);
                }
                return Ok(list);
            }
            return BadRequest(res.Status.message);
        }
    }
}

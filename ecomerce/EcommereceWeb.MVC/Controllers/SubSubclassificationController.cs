using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class SubSubclassificationController : BaseMVCController
    {
        public async Task<IActionResult> Index(int SubClassificationBaseId)
        {
            
            if (SubClassificationBaseId != 0)
            {
                Console.WriteLine($"ffffffffffff   {SubClassificationBaseId}");
                TempData.SetTemp<int>("SubClassificationBaseId", SubClassificationBaseId);
                var res = await ServiceManager.SubSubclassificationService.Find(a => a.SubClassificationBaseId == SubClassificationBaseId);
                var mainRes = await ServiceManager.SubClassificationBaseService.GetById(SubClassificationBaseId);
                if (mainRes.Status.Succeeded)
                {
                    TempData.SetTemp<string>("name", mainRes.Data.ArSubClassificationName);
                    TempData.SetTemp<int>("BasicClassificationId", (int)mainRes.Data.BasicClassificationId);

                    TempData["Id"] = SubClassificationBaseId;
                    if (res.Status.Succeeded)
                    {

                        return View(res.Data);
                    }
                    TempData["msg"] = res.Status.message;
                    return View();
                }
                else
                {
                    TempData["msg"] = "لا يوجد تصنيفات فرعيةالفرعية بهذا الرقم";
                    return RedirectToAction("Index", "MainClassification");
                }

            }
            else
            {
                return RedirectToAction("Index", "MainClassification");
            }

        }
        public async Task<IActionResult> Create(int SubClassificationBaseId)
        {
          
            if (SubClassificationBaseId != 0)
            {
                TempData.SetTemp<int>("SubClassificationBaseId", SubClassificationBaseId);
                var obj = new SubSubclassificationDto { SubClassificationBaseId = SubClassificationBaseId };
                var res = await ServiceManager.SubClassificationBaseService.GetById(SubClassificationBaseId);

                if (res.Status.Succeeded)
                {
                    TempData.SetTemp<string>("name", res.Data.ArSubClassificationName);
                    return View(obj);
                }
                else
                {
                    return RedirectToAction("Index", new { id = SubClassificationBaseId });
                }
            }
            else
            {
                return RedirectToAction("Index", "MainClassification");
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubSubclassificationDto entity)
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
                    var res = await ServiceManager.SubSubclassificationService.Add(entity);
                    if (res.Status.Succeeded)
                    {
                        TempData.SetTemp<int>("SubClassificationBaseId", (int)res.Data.SubClassificationBaseId);

                        TempData["msg"] = res.Status.message;
                        return RedirectToAction("Index", new { SubClassificationBaseId = entity.SubClassificationBaseId });
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
            var res = await ServiceManager.SubSubclassificationService.GetById(Id);
            if (res.Status.Succeeded)
            {
                TempData.SetTemp<int>("SubClassificationBaseId", (int)res.Data.SubClassificationBaseId);

                TempData.SetTemp<string>("name", res.Data.ArSubSubClassificationName);

                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SubSubclassificationDto entity)
        {

            if (entity == null) { TempData["msg"] = "ادخل البيانات"; return View(entity); }
            var res = await ServiceManager.SubSubclassificationService.Update(entity);
            if (res.Status.Succeeded)
            {

                TempData["msg"] = res.Status.message;
                return RedirectToAction("Index", new { SubClassificationBaseId = entity.SubClassificationBaseId });
            }
            TempData["msg"] = res.Status.message;
            return View(entity);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            
            try
            {
                var res = await ServiceManager.SubSubclassificationService.Remove(Id);
                if (res.Status.Succeeded)
                {
                    const string folderName = "SubClassification";
                    var deleteRes = ServiceManager.UplaodFileService.DeleteImageFile(res.Data.ImageUrl, folderName);

                    if (deleteRes == true)
                    {

                        TempData["msg"] = res.Status.message;
                        TempData["suc"] = "تم الحذف بنجاح";
                        return RedirectToAction("Index", new { SubClassificationBaseId = TempData["Id"] });
                    }
                    else
                    {
                        TempData["msg"] = "file not deleted because there is no file name ";

                        return RedirectToAction("Index", new { SubClassificationBaseId = TempData["Id"] });
                    }

                }
                else
                {


                    TempData["msg"] = res.Status.message;
                    TempData["didentDelete"] = "لا يمكن حذف التصنيف فرعي الفرعي لانه هناك   منتجات متعلقة في هذا التصنيف .قم بحذف البيانات المتعلقة بعدين احذف التصنيف";

                    return RedirectToAction("Index", new { SubClassificationBaseId = TempData["Id"] });
                }

            }


            catch (Exception ex)
            {

                TempData["msg"] = $"error {ex.Message}  ";
                return RedirectToAction("Index", new { SubClassificationBaseId = TempData["Id"] });
            }
        }
        public async Task<IActionResult> GetSubclassFication(int subId)
        {
            var res = await ServiceManager.SubSubclassificationService.Find(a => a.SubClassificationBaseId == subId);
            var list = new List<dynamic>();
            if (res.Status.Succeeded)
            {
                foreach (var item in res.Data)
                {
                    var dict = new Dictionary<string, dynamic>();
                    dict.Add("id", item.Id);
                    dict.Add("name", item.ArSubSubClassificationName);
                    list.Add(dict);
                }
                return Ok(list);
            }
            return BadRequest(res.Status.message);
        }

    }
}

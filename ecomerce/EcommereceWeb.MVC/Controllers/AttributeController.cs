using EcommereceWeb.Application.Services;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.ViewModel;
using EcommereceWeb.MVC.Services;

namespace EcommereceWeb.MVC.Controllers
{
    public class AttributeController : BaseMVCController
    {
        // GET: AttributeController
        public async Task<ActionResult> Index()
        {
            
            var res = await ServiceManager.AttributeService.GetAll();
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;
            return View();
        }

        // GET: AttributeController/Details/5
        public ActionResult Details()
        {
            ProductAdditionalVM vm =new ProductAdditionalVM();
         vm.checkBoxListVms = new List<CheckBoxListVm>();
           vm.CheckBoxListVm= new CheckBoxListVm();
            return View(vm);
        }

        // GET: AttributeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AttributeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AttributeDto entity)
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
                    var res = await ServiceManager.AttributeService.Add(entity);
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

        // GET: AttributeController/Edit/5
        public async Task<ActionResult> Edit(int Id)
        {
            var res = await ServiceManager.AttributeService.GetById(Id);
            if (res.Status.Succeeded)
            {

                TempData.SetTemp<string>("name", res.Data.ArName);
                return View(res.Data);
            }
            TempData["msg"] = res.Status.message;

            return RedirectToAction("Index");
        }

        // POST: AttributeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(AttributeDto entity)
        {
            if (entity == null) { TempData["msg"] = "ادخل البيانات"; return View(entity); }
            var res = await ServiceManager.AttributeService.Update(entity);
            if (res.Status.Succeeded)
            {

                TempData["msg"] = res.Status.message;
                return RedirectToAction("Index");
            }
            TempData["msg"] = res.Status.message;
            return View(entity);
        }

        public async Task<ActionResult> Delete(int Id)
        {
            try
            {
                var res = await ServiceManager.AttributeService.Remove(Id);
                if (res.Status.Succeeded)
                {
                    TempData["msg"] = res.Status.message;
                    TempData["suc"] = "تم الحذف بنجاح";
                    return RedirectToAction(nameof(Index));
                }
                else
                {


                    TempData["msg"] = res.Status.message;
                    TempData["didentDelete"] = "لا يمكن حذف الصفة لانه هناك بيانات في جداول  اخرى متعلقة في هذا الصفة .قم بحذف البيانات المتعلقة بعدين احذف الصفة";

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

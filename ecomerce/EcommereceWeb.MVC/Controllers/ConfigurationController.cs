using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class ConfigurationController : BaseMVCController
    {
        public async Task<IActionResult> Index()
        {
            var res = await ServiceManager.ConfigurationService.GetAll();
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
        public async Task< IActionResult> Create(ConfigurationDto entity)
        {
            
            if(entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.ConfigurationService.Add(entity);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index");
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }
        
        public async Task<IActionResult> Edit(int Id)
        {
            var res = await ServiceManager.ConfigurationService.GetById(Id);
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["err"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ConfigurationDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.ConfigurationService.Update(entity);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index");
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var res = await ServiceManager.ConfigurationService.Remove(Id);
            if (res.Status.Succeeded) {
                TempData["suc"]=res.Status.message;
                return RedirectToAction("Index");
            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Index");
        }

    }
}

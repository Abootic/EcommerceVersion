using EcommereceWeb.Application.DTOs;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class TaxConfigurationController : BaseMVCController
    {
        public async Task<IActionResult> Index()
        {
            var res = await ServiceManager.TaxConfigurationService.GetAll();
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
        public async Task<IActionResult> Create(TaxConfigurationDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.TaxConfigurationService.Add(entity);
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
            var res = await ServiceManager.TaxConfigurationService.GetById(Id);
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["err"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TaxConfigurationDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.TaxConfigurationService.Update(entity);
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
            var res = await ServiceManager.TaxConfigurationService.Remove(Id);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index");
            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Index");
        }

    }
}

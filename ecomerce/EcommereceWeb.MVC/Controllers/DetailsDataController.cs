using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Services;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class DetailsDataController : BaseMVCController
    {
        public async Task<IActionResult> Index(int masterId)
        {
            var res = await ServiceManager.DetailsDataService.Find(a => a.MasterDataId == masterId);
            if (res.Status.Succeeded)
            {
                var mainRes = await ServiceManager.MasterDataService.GetById(masterId);
                if (mainRes.Status.Succeeded)
                    TempData.SetTemp<string>("name", mainRes.Data.Name);
                TempData.SetTemp<int>("masterId", masterId);



                return View(res.Data);
            }
            return View();

        }
        public async Task<IActionResult> Create(int masterId)
        {
            var obj = new DetailsDataDto { MasterDataId = masterId };
            var res = await ServiceManager.MasterDataService.GetById(masterId);
            if (res.Status.Succeeded)
            {
                TempData.SetTemp<string>("name", res.Data.Name);
                ;
                return View(obj);
            }

            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DetailsDataDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.DetailsDataService.Add(entity);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index", new { masterId = entity.MasterDataId });
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var res = await ServiceManager.DetailsDataService.GetById(Id);
            if (res.Status.Succeeded)
            {
                return View(res.Data);
            }
            TempData["err"] = res.Status.message;

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DetailsDataDto entity)
        {

            if (entity == null) { TempData["err"] = "null value"; return View(entity); }
            var res = await ServiceManager.DetailsDataService.Update(entity);
            if (res.Status.Succeeded)
            {

                TempData["suc"] = res.Status.message;
                return RedirectToAction("Index", new { masterId = entity.MasterDataId });
            }
            TempData["err"] = res.Status.message;
            return View(entity);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var res = await ServiceManager.DetailsDataService.Remove(Id);
            if (res.Status.Succeeded)
            {

                return RedirectToAction("Index", new { masterId = res.Data.MasterDataId });
            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Index", new { masterId = res.Data.MasterDataId });
        }
    }
}

using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Infrstraction.Repositories;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class AccountController : BaseMVCController
    {
      
    public async Task<IActionResult>  Index()
        {
        UserAndRoleVm userAndRoleVm = new UserAndRoleVm();
        userAndRoleVm.obj = new UserDto();
        var res=await ServiceManager.UserService.GetAll();
                if (res.Status.Succeeded)
                {
                TempData["suc"] = res.Status.message;
            userAndRoleVm.data = res.Data;
                Console.WriteLine($"bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb     {res.Data.First().FullName}");
            return View(userAndRoleVm);

                }
            TempData["err"] =res.Status.message;
            return View(res.Data);
           
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserDto userDto)
        {
            try { 
            if(userDto == null) {
                    TempData["err"] = "null value";
                return View(userDto);
            }
            var res=await ServiceManager.UserService.AddAsync(userDto);
                if (res.Status.Succeeded)
                {
                    TempData["suc"] = "done";
                    return View(res.Data);
                }
                TempData["err"] = $"error: {res.Status.message}";
                return   View(userDto);
            }
            catch(Exception ex)
            {
                TempData["err"] = $"catch err {ex.Message}";
                Console.WriteLine($" error is {ex.Message}");
                Console.WriteLine($" error is {ex.InnerException.Message}");
                return View(userDto);
            }
        }
    }
}

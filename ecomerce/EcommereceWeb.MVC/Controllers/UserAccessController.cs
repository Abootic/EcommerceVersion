using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.MVC.Controllers.Base;
using EcommereceWeb.MVC.Services;
using EcommereceWeb.MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers
{
    public class UserAccessController : BaseMVCController
    {
        private readonly ISigninManager _SignManager;

        public UserAccessController(ISigninManager signManager)
        {
            _SignManager = signManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVm loginVm)
        {
            if (ModelState.IsValid)
            {
                Console.Write("remmmmmmmmmmmmmmmmmm " + loginVm.RememberMe);

                var res = await _SignManager.PasswordSiginAsync(loginVm.userName, loginVm.Password, loginVm.RememberMe, false);
                if (res.Status.Succeeded)
                {
                    
                  

                   

                    return RedirectToAction("Index", "Home");

                }
                TempData["error"] = res.Status.message;
                return View(loginVm);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "يجب ادخال البيانات");
                return View(loginVm);

            }

        }
        public IActionResult Logout()
        {
            _SignManager.Logout();
            return RedirectToAction("Login", "UserAccess");
        }
    }
}

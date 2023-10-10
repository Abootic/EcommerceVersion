using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Services;
using EcommereceWeb.Infrstraction.Repositories;
using EcommereceWeb.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EcommereceWeb.MVC.Controllers
{
    public class RolesManagerController : BaseMVCController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRoleToUser(UserAndRolesDto userAndRolesDto)
        {
            // bool suceess=false;
            if (userAndRolesDto == null) return BadRequest("the data is null");

           
            var res = await ServiceManager.RoleService.AddRoleToUserAsync(userAndRolesDto);
            if (res.Status.Succeeded)
            {
                TempData["suc"] = res.Status.message;
                var user = await ServiceManager.UserService.FindByIdAsync(userAndRolesDto.UserId);
                user.Data.UserType = userAndRolesDto.RoleName;
                var update = await ServiceManager.UserService.ChangeUserType(user.Data);
                if (update.Status.Succeeded)
                {
                    TempData["suc"] = update.Status.message;
                    return RedirectToAction("Account", "Index");
                }
                else
                {
                    TempData["err"] = update.Status.message;
                    return RedirectToAction("Account", "Index");

                }

                // return Ok(res.Status.message);

            }
            TempData["err"] = res.Status.message;
            return RedirectToAction("Account", "Index");

        }
    }
}

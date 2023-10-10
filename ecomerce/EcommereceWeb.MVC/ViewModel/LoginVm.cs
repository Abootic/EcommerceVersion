using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.MVC.ViewModel
{
    public class LoginVm
    {
        [Required(ErrorMessage = "يجب ادخال اسم المستخدم")]
        public string? userName { get; set; }
        [Required(ErrorMessage = "يجب ادخال كلمة السر ")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

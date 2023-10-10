using EcommereceWeb.Application.Interfaces.Common;
using Microsoft.AspNetCore.Mvc;

namespace EcommereceWeb.MVC.Controllers.Base
{
    public class BaseMVCController : Controller
    {
        private IServiceManager _serviceManager { get; set; }
        protected IServiceManager ServiceManager => _serviceManager ??= HttpContext.RequestServices.GetService<IServiceManager>();


        public ActionResult UploadJobImage(IFormFile Image, string folderName)//notic how to make it dynamic function to all controller
        {
            Console.WriteLine($"11111111111111111111111111111111111111111111111111  {Image.FileName} ");

            var img = ServiceManager.UplaodFileService.UploadFileAsBase64(Image, folderName);
            Console.WriteLine($"222222222222222222222   {img}");
            if (img == "NotImage")
            {
                return BadRequest("  png or jpg يجب ان تكون صيغة الصور من نوع  ");
                //  return BadRequest("the must upload image jpg or png");

            }
            else if (img == "over")
            {
                return BadRequest("يجب ان تكون حجم الصورة 2 ميجا  او اقل");
                // return BadRequest("the Image must be or less than 2mb");

            }
            else if (img == "err")
            {
                return BadRequest("يوجد خطاء في الصور اعد رفع الصور من جديد");

            }
            else
            {
                var dict = new Dictionary<string, string>();
                dict.Add("image", img);
                return Ok(dict);
            }


        }
        public ActionResult UploadFileToGallery(IFormFile[] Image, string folderName)//notic how to make it dynamic function to all controller
        {


            var img = ServiceManager.UplaodFileService.UploadFileToGallery(Image, folderName);
            var ListDict = new List<Dictionary<string, dynamic>>();
            for (int i = 0; i < img.Count(); i++)
            {
                if (img[i] == "NotImage")
                {
                    return BadRequest("  png or jpg يجب ان تكون صيغة الصور من نوع  ");

                }
                else if (img[i] == "over")
                {
                    return BadRequest("يجب ان تكون حجم الصور 2 ميجا  او اقل");
                    // return BadRequest("the Image must be or less than 2mb");

                }
                else if (img[i] == "err")
                {
                    return BadRequest("يوجد خطاء في الصور اعد رفع الصور من جديد");

                }
                else
                {
                    var dict = new Dictionary<string, dynamic>();
                    dict.Add("image", img[i]);
                    ListDict.Add(dict);


                }

            }
            return Ok(ListDict);



        }
        public async Task<ActionResult> DeleteImage(string image, string folderName, string ext) //notic how to make it dynamic function to all controller
        {
            if (string.IsNullOrWhiteSpace(image))
            {
                if (ext == "jpg" || ext == "png")
                {
                    image = "no.png";
                }
                image = "no.pdf";
            }

            Console.WriteLine("pic is  =>  " + image);
            var res = ServiceManager.UplaodFileService.DeleteImageFile(image, folderName);

            var dict = new Dictionary<string, dynamic>();
            dict.Add("result", res);

            return Ok(dict);
        }
    }
}

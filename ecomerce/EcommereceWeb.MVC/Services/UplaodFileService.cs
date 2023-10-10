using EcommereceWeb.Application.Constant;
using EcommereceWeb.Application.Interfaces.Common;

namespace EcommereceWeb.MVC.Services
{
    public class UplaodFileService : IUplaodFileService
    {
        private readonly IWebHostEnvironment _env;

        public UplaodFileService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public bool DeleteImageLogoSponserFile(string fileNameWithPath, string folderName)
        {
            var ufolder = Path.Combine(_env.WebRootPath, ProjectConstant.ProjectUpload);


            var subFolder = Path.Combine(ufolder, folderName);
            var path = Path.Combine(subFolder, fileNameWithPath);
            Console.WriteLine("path=>  " + path);
            if (File.Exists(path) == false)
            {


                Console.WriteLine("the file logo path not exsit =>  " + path);
                return false;
            }
            File.Delete(path);

            Console.WriteLine("logo deleted successFully");
            return true;


        }
        public bool DeleteImageFile(string fileNameWithPath, string folderName)
        {
            var ufolder = Path.Combine(_env.WebRootPath, ProjectConstant.ProjectUpload);


            var subFolder = Path.Combine(ufolder, folderName);
            var path = Path.Combine(subFolder, fileNameWithPath);
            Console.WriteLine("path=>  " + path);
            if (File.Exists(path) == false)
            {


                Console.WriteLine("the file path not exsit =>  " + path);
                return false;
            }
            File.Delete(path);

            Console.WriteLine("Image deleted successFully");
            return true;


        }


        public List<string> UploadFileToGallery(IFormFile[] Image, string SubFolder)
        {
            List<string> err = new List<string>();
            List<string> data = new List<string>();

            List<string> imageName = new List<string>();
            if (Image == null)
            {

                err.Add("err");
                return err;
            }
            try
            {
                // string check = string.Empty;

                for (int i = 0; i < Image.Length; i++)
                {
                    string ext = Image[i].FileName.Split(".").Last();

                    if (ext == "jpg" || ext == "png")
                    {

                        if (Image[i].Length > 3 * 1024 * 1024)
                        {
                            err.Add("over");
                            return err;
                        }
                        string uniqueFileName = string.Empty;
                        string uploadsFolder = Path.Combine(_env.WebRootPath, ProjectConstant.ProjectUpload);
                        var subFolder = Path.Combine(uploadsFolder, SubFolder);


                        if (!System.IO.Directory.Exists(uploadsFolder))
                        {
                            System.IO.Directory.CreateDirectory(uploadsFolder);

                        }

                        if (!System.IO.Directory.Exists(subFolder))
                        {
                            System.IO.Directory.CreateDirectory(subFolder);
                        }
                        while (true)
                        {
                            uniqueFileName = Guid.NewGuid().ToString() + "." + Image[i].FileName.Split(".").Last();
                            data.Add(uniqueFileName);
                            if (!System.IO.File.Exists(subFolder))
                            {


                                break;
                            }
                            if (!System.IO.File.Exists(Path.Combine(subFolder, uniqueFileName)))
                            {


                                break;
                            }


                        }
                        string filePath = Path.Combine(subFolder, uniqueFileName);
                        using (FileStream str = new FileStream(filePath, FileMode.Create))
                        {
                            Image[i].CopyTo(str);
                        }






                    }
                    else
                    {
                        data.Add("NotImage");
                    }
                }
                return data;
            }
            catch (Exception ex)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, ProjectConstant.ProjectUpload);
                err.Add("Erro Occured" + uploadsFolder);
                return err;
            }


        }
        public string UploadFileAsBase64(IFormFile Image, string SubFolder)
        {
            
            List<string> imageName = new List<string>();
            if (Image == null)
            {
                return "Erorr: Can't Upload File";
            }

            try
            {
                Console.Write("55555555555555555555555555555");
                string ext = Image.FileName.Split(".").Last();


                if (ext == "jpg" || ext == "png")
                {



                    if (Image.Length > 3 * 1024 * 1024)
                    {
                        return "over";
                    }
                    string uniqueFileName = null;

                    string uploadsFolder = Path.Combine(_env.WebRootPath, ProjectConstant.ProjectUpload);
                    var subFolder = Path.Combine(uploadsFolder, SubFolder);


                    if (!System.IO.Directory.Exists(uploadsFolder))
                    {
                        System.IO.Directory.CreateDirectory(uploadsFolder);

                    }

                    if (!System.IO.Directory.Exists(subFolder))
                    {
                        System.IO.Directory.CreateDirectory(subFolder);
                    }
                    while (true)
                    {




                        uniqueFileName = Guid.NewGuid().ToString() + "." + Image.FileName.Split(".").Last();

                        if (!System.IO.File.Exists(subFolder))
                        {


                            break;
                        }
                        if (!System.IO.File.Exists(Path.Combine(subFolder, uniqueFileName)))
                        {


                            break;
                        }


                    }
                    string filePath = Path.Combine(subFolder, uniqueFileName);
                    using (FileStream str = new FileStream(filePath, FileMode.Create))
                    {
                        Image.CopyTo(str);
                    }



                    return uniqueFileName;


                }
                else
                {

                    Console.WriteLine($"the image exten condition false ==> {ext}");
                    return "NotImage";
                }

        }
            catch (Exception ex)
            {
              
            
                string uploadsFolder = Path.Combine(_env.WebRootPath, ProjectConstant.ProjectUpload);
        
                return "Erro Occured" + uploadsFolder;
            }


}

        public string UploadPdfFile(IFormFile Image, string SubFolder)
        {
            List<string> imageName = new List<string>();
            if (Image == null)
            {
                return "Erorr: Can't Upload File";
            }

            try
            {
                string ext = Image.FileName.Split(".").Last();


                if (ext == "pdf")
                {






                    Console.WriteLine($"the image exten condition true ==> {ext}");
                    //if (Image.Length > 2 * 1024 * 1024)
                    //{
                    //    return "File Size Is Grater Than 2MB";
                    //}
                    string uniqueFileName = null;

                    string uploadsFolder = Path.Combine(_env.WebRootPath, ProjectConstant.ProjectUpload);
                    var subFolder = Path.Combine(uploadsFolder, SubFolder);


                    if (!System.IO.Directory.Exists(uploadsFolder))
                    {
                        System.IO.Directory.CreateDirectory(uploadsFolder);

                    }

                    if (!System.IO.Directory.Exists(subFolder))
                    {
                        System.IO.Directory.CreateDirectory(subFolder);
                    }
                    while (true)
                    {




                        uniqueFileName = Guid.NewGuid().ToString() + "." + Image.FileName.Split(".").Last();

                        if (!System.IO.File.Exists(subFolder))
                        {


                            break;
                        }
                        if (!System.IO.File.Exists(Path.Combine(subFolder, uniqueFileName)))
                        {


                            break;
                        }


                    }
                    string filePath = Path.Combine(subFolder, uniqueFileName);
                    using (FileStream str = new FileStream(filePath, FileMode.Create))
                    {
                        Image.CopyTo(str);
                    }



                    return uniqueFileName;


                }
                else
                {

                    Console.WriteLine($"the image exten condition false ==> {ext}");
                    return "NotImage";
                }

            }
            catch (Exception ex)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, ProjectConstant.ProjectUpload);
                return "Erro Occured" + uploadsFolder;
            }


        }


    }

}

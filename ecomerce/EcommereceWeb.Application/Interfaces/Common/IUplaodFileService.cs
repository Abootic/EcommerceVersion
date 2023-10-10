using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface IUplaodFileService
    {
        string UploadFileAsBase64(IFormFile Image, string SubFolder);
        List<string> UploadFileToGallery(IFormFile[] Image, string SubFolder);
        string UploadPdfFile(IFormFile Image, string SubFolder);
     
        bool DeleteImageFile(string fileNameWithPath, string folderName);
        bool DeleteImageLogoSponserFile(string fileNameWithPath, string folderName);
        }
}

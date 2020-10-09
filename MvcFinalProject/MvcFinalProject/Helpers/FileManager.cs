using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Helpers
{
    public class FileManager
    {
        private IWebHostEnvironment _webHostEnvironment;
        public FileManager(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public string Upload(IFormFile file, string allowedTypes = "image/png|image/jpeg|image/gif|image/jpg", int maxSize = 4096)
        {
            string UploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "images");
            if (file == null)
            {
                string fileName = "about-1.jpg";
                return fileName;
            }
            if (file.Length / 4096 > maxSize)
            {
                throw new Exception("File size can be max 4096kb");
            }
            if (!allowedTypes.Split('|').Contains(file.ContentType))
            {
                throw new Exception("File type is not acceptable");
            }
            string filename = Guid.NewGuid().ToString() + "-" + file.FileName;
            string filePath = Path.Combine(UploadPath, filename);
            FileStream fs = new FileStream(filePath, FileMode.Create);
            file.CopyToAsync(fs);
            fs.Close();

            return filename;
        }
    }
}

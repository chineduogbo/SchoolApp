using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using SchoolAppForUcheApi.Services.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppForUcheApi.Services.Implementation
{
    public class UtilityService : IUtilityService
    {
        private readonly IHostEnvironment _hostingEnvironment;
        public UtilityService(IHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
      
        public async Task<List<string>> GetNoteUploadLink(List<IFormFile> files)
        {
            var directory = Path.Combine("Images", "Pictures");
            var filePath = Path.Combine(_hostingEnvironment.ContentRootPath, directory);
            List<string> media = new List<string>();
            foreach (var file in files)
            {

                var noteUrl = string.Empty;
                //Define allowed property of the uploaded file

                var validFileSize = 20 * (1024 * 1024);//1mb
                List<string> validFileExtension = new List<string>();

                validFileExtension.Add(".jpg");
                validFileExtension.Add(".png");
                validFileExtension.Add(".jpeg");
                validFileExtension.Add(".JPG");
                validFileExtension.Add(".PNG");
                validFileExtension.Add(".JPEG");
                validFileExtension.Add(".Gif");
                validFileExtension.Add(".MP4");
                validFileExtension.Add(".Mp3");
                validFileExtension.Add(".3Gp");
                validFileExtension.Add(".mp4");
                validFileExtension.Add(".Mp4");
                validFileExtension.Add(".mov");
                validFileExtension.Add(".MOV");




                if (file.Length > 0)
                {

                    var extType = Path.GetExtension(file.FileName);
                    var fileSize = file.Length;
                    if (fileSize <= validFileSize)
                    {

                        if (validFileExtension.Contains(extType))
                        {
                            string fileName = string.Format("{0}{1}", file.FileName + "_" + DateTime.UtcNow.Millisecond, extType);
                            //create file path if it doesnt exist
                            if (!Directory.Exists(filePath))
                            {
                                Directory.CreateDirectory(filePath);
                            }
                            var fullPath = Path.Combine(filePath, fileName);
                            noteUrl = Path.Combine(directory, fileName);
                            //Delete if file exist
                            FileInfo fileExists = new FileInfo(fullPath);
                            if (fileExists.Exists)
                            {
                                fileExists.Delete();
                            }

                            using (var stream = new FileStream(fullPath, FileMode.Create))
                            {
                                await file.CopyToAsync(stream);
                            }

                             noteUrl = noteUrl.Replace('\\', '/');
                            media.Add(noteUrl);




                        }
                        else
                        {
                            throw new BadImageFormatException("Invalid file type...Accepted formats are ppt, pdf, and ppx");
                        }
                    }
                }
             
            }
            return media;
        }
       

    }
}

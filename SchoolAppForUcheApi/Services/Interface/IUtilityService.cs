using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppForUcheApi.Services.Interface
{
   public interface IUtilityService
    {
        Task<List<string>> GetNoteUploadLink(List<IFormFile> files);
    }
}

using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace SchoolAppForUcheApi.Model.DTO
{
    public class CreateAnnouncementsDTO
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public List<IFormFile> Imagelinks { get; set; }
    };
}

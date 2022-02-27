using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAppForUcheApi.Model;
using SchoolAppForUcheApi.Model.DTO;
using SchoolAppForUcheApi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppForUcheApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly iCRUDService<Announcements> _icrud;
        private readonly iCRUDService<AnnouncementMedia> _media;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        private readonly IUtilityService _utility;
        
        public AnnouncementController(iCRUDService<Announcements> icrud, IMapper mapper, IDuplicateService duplicateService, iCRUDService<AnnouncementMedia> media, IUtilityService utility)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
            _media = media;
            _utility = utility;
        }

        [HttpPost]
        public async Task<AnnouncementsDTO> Create([FromForm]CreateAnnouncementsDTO model)
        {
            var announcement = _mapper.Map<AnnouncementsDTO>(await _icrud.Create(new Announcements() { Date = DateTime.Now,Description = model.Description,Active = true,UserId = model.UserId}));
            var links = await _utility.GetNoteUploadLink(model.Imagelinks);
            foreach(var item in links)
            {
              await  _media.Create(new AnnouncementMedia() { Active = true, AnnouncementsId = announcement.Id, Url = item });
            }
            return announcement;
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(AnnouncementsDTO model)
        {
            return await _icrud.Edit((_mapper.Map<Announcements>(model)));
        }
        [HttpGet]
        public async Task<AnnouncementsDTO> Get(int Id)
        {
            return _mapper.Map<AnnouncementsDTO>(await _icrud.GetById(Id));
        }
        [HttpGet]
        public async Task<IEnumerable<AnnouncementsDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<AnnouncementsDTO>>(await _icrud.GetAll());
        }
        [HttpPost]
        public async Task<SuccessDTO> Delete(int Id)
        {
            return await _icrud.Delete(Id);
        }
    }
}

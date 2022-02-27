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
    public class TeacherClassController : ControllerBase
    {
        private readonly iCRUDService<Teacherclass> _icrud;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public TeacherClassController(iCRUDService<Teacherclass> icrud, IMapper mapper, IDuplicateService duplicateService)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<TeacherclassDto> Create(CreateTeacherclassDto model)
        {
            return _mapper.Map<TeacherclassDto>(await _icrud.Create((_mapper.Map<Teacherclass>(model))));
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(TeacherclassDto model)
        {
            return await _icrud.Edit((_mapper.Map<Teacherclass>(model)));
        }
        [HttpGet]
        public async Task<TeacherclassDto> Get(int Id)
        {
            return _mapper.Map<TeacherclassDto>(await _icrud.GetById(Id));
        }
        [HttpGet]
        public async Task<IEnumerable<TeacherclassDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<TeacherclassDto>>(await _icrud.GetAll());
        }
        [HttpPost]
        public async Task<SuccessDTO> Delete(int Id)
        {
            return await _icrud.Delete(Id);
        }
    }
}

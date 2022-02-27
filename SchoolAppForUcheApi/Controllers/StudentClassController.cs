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
    public class StudentClassController : ControllerBase
    {
        private readonly iCRUDService<Studentclass> _icrud;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public StudentClassController(iCRUDService<Studentclass> icrud, IMapper mapper, IDuplicateService duplicateService)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<StudentclassDto> Create(CreateStudentclassDto model)
        {
            return _mapper.Map<StudentclassDto>(await _icrud.Create((_mapper.Map<Studentclass>(model))));
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(StudentclassDto model)
        {
            return await _icrud.Edit((_mapper.Map<Studentclass>(model)));
        }
        [HttpGet]
        public async Task<StudentclassDto> Get(int Id)
        {
            return _mapper.Map<StudentclassDto>(await _icrud.GetById(Id));
        }
        [HttpGet]
        public async Task<IEnumerable<StudentclassDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<StudentclassDto>>(await _icrud.GetAll());
        }
        [HttpPost]
        public async Task<SuccessDTO> Delete(int Id)
        {
            return await _icrud.Delete(Id);
        }
    }
}

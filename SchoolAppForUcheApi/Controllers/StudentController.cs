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
    public class StudentController : ControllerBase
    {
        private readonly iCRUDService<Student> _icrud;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public StudentController(iCRUDService<Student> icrud, IMapper mapper, IDuplicateService duplicateService)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<Student> Create(Student model)
        {
            return await _icrud.Create(model);
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(Student model)
        {
            return await _icrud.Edit(model);
        }
        [HttpGet]
        public async Task<Student> Get(int Id)
        {
            return await _icrud.GetById(Id);
        }
        [HttpGet]
        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _icrud.GetAll();
        }
        [HttpPost]
        public async Task<SuccessDTO> Delete(int Id)
        {
            return await _icrud.Delete(Id);
        }
    }
}

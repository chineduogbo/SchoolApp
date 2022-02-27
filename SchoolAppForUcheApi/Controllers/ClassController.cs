using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolAppForUcheApi.Model;
using SchoolAppForUcheApi.Model.DTO;
using SchoolAppForUcheApi.Services.Interface;
using AutoMapper;
namespace SchoolAppForUcheApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly iCRUDService<Class> _icrud;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public ClassController(iCRUDService<Class> icrud, IMapper mapper, IDuplicateService duplicateService)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<Class> Create(Class model)
        {
            return await  _icrud.Create(model);
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(Class model)
        {
            return await _icrud.Edit(model);
        }
        [HttpGet]
        public async Task<Class> Get(int Id)
        {
            return await _icrud.GetById(Id);
        }
        [HttpGet]
        public async Task<IEnumerable<Class>> GetAll()
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

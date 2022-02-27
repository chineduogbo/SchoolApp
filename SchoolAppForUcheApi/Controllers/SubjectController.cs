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
    public class SubjectController : ControllerBase
    {

        private readonly iCRUDService<Subjects> _icrud;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public SubjectController(iCRUDService<Subjects> icrud, IMapper mapper, IDuplicateService duplicateService)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<Subjects> Create(Subjects model)
        {
            return await _icrud.Create(model);
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(Subjects model)
        {
            return await _icrud.Edit(model);
        }
        [HttpGet]
        public async Task<Subjects> Get(int Id)
        {
            return await _icrud.GetById(Id);
        }
        [HttpGet]
        public async Task<IEnumerable<Subjects>> GetAll()
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

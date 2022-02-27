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
    public class TermController : ControllerBase
    {

        private readonly iCRUDService<Term> _icrud;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public TermController(iCRUDService<Term> icrud, IMapper mapper, IDuplicateService duplicateService)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<Term> Create(Term model)
        {
            return await _icrud.Create(model);
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(Term model)
        {
            return await _icrud.Edit(model);
        }
        [HttpGet]
        public async Task<Term> Get(int Id)
        {
            return await _icrud.GetById(Id);
        }
        [HttpGet]
        public async Task<IEnumerable<Term>> GetAll()
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

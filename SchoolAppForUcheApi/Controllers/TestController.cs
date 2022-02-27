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
    public class TestController : ControllerBase
    {
        private readonly iCRUDService<Test> _icrud;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public TestController(iCRUDService<Test> icrud, IMapper mapper, IDuplicateService duplicateService)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<TestDto> Create(CreateTestDto model)
        {
            return _mapper.Map<TestDto>(await _icrud.Create((_mapper.Map<Test>(model))));
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(CreateTestDto model)
        {
            return await _icrud.Edit((_mapper.Map<Test>(model)));
        }
        [HttpGet]
        public async Task<TestDto> Get(int Id)
        {
            return _mapper.Map<TestDto>(await _icrud.GetById(Id));
        }
        [HttpGet]
        public async Task<IEnumerable<TestDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<TestDto>>(await _icrud.GetAll());
        }
        [HttpPost]
        public async Task<SuccessDTO> Delete(int Id)
        {
            return await _icrud.Delete(Id);
        }
    }
}

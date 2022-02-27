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
    public class ClassSubGroupController : ControllerBase
    {
        private readonly iCRUDService<Classsubgroup> _icrud;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public ClassSubGroupController(iCRUDService<Classsubgroup> icrud, IMapper mapper, IDuplicateService duplicateService)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<ClasssubgroupDto> Create(CreateClasssubgroupDTO model)
        {
            return _mapper.Map<ClasssubgroupDto>(await _icrud.Create((_mapper.Map<Classsubgroup>(model))));
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(ClasssubgroupDto model)
        {
            return await _icrud.Edit((_mapper.Map<Classsubgroup>(model)));
        }
        [HttpGet]
        public async Task<ClasssubgroupDto> Get(int Id)
        {
            return _mapper.Map<ClasssubgroupDto>(await _icrud.GetById(Id));
        }
        [HttpGet]
        public async Task<IEnumerable<ClasssubgroupDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<ClasssubgroupDto>>(await _icrud.GetAll());
        }
        [HttpPost]
        public async Task<SuccessDTO> Delete(int Id)
        {
            return await _icrud.Delete(Id);
        }
    }
}

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
    public class ResultController : ControllerBase
    {
        private readonly iCRUDService<Result> _icrud;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public ResultController(iCRUDService<Result> icrud, IMapper mapper, IDuplicateService duplicateService)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<ResultDto> Create(CreateResultDto model)
        {
            return _mapper.Map<ResultDto>(await _icrud.Create((_mapper.Map<Result>(model))));
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(ResultDto model)
        {
            return await _icrud.Edit((_mapper.Map<Result>(model)));
        }
        [HttpGet]
        public async Task<ResultDto> Get(int Id)
        {
            return _mapper.Map<ResultDto>(await _icrud.GetById(Id));
        }
        [HttpGet]
        public async Task<IEnumerable<ResultDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<ResultDto>>(await _icrud.GetAll());
        }
        [HttpPost]
        public async Task<SuccessDTO> Delete(int Id)
        {
            return await _icrud.Delete(Id);
        }
    }
}

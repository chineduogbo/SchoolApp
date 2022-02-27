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
    public class ActiveTermController : ControllerBase
    {
        private readonly iCRUDService<Activeterm> _icrud;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public ActiveTermController(iCRUDService<Activeterm> icrud, IMapper mapper, IDuplicateService duplicateService)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<ActivetermDto> Create(CreateActivetermDto model)
        {
            if (!_duplicateService.CheckExistingActiveTerm(model.SessionId,model.TermId))
                return _mapper.Map<ActivetermDto>(await _icrud.Create((_mapper.Map<Activeterm>(model))));
            return null;
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(ActivetermDto model)
        {
            return await _icrud.Edit((_mapper.Map<Activeterm>(model)));
        }
        [HttpGet]
        public async Task<ActivetermDto> Get(int Id)
        {
            return _mapper.Map<ActivetermDto>(await _icrud.GetById(Id));
        }
        [HttpGet]
        public async Task<IEnumerable<ActivetermDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<ActivetermDto>>(await _icrud.GetAll());
        }
        [HttpPost]
        public async Task<SuccessDTO> Delete(int Id)
        {
            return await _icrud.Delete(Id);
        }
    }
}

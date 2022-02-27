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
    public class AttendanceController : ControllerBase
    {
        private readonly iCRUDService<Attendance> _icrud;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public AttendanceController(iCRUDService<Attendance> icrud, IMapper mapper, IDuplicateService duplicateService)
        {
            _icrud = icrud;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<AttendanceDto> Create(CreateAttendanceDto model)
        {
            return _mapper.Map<AttendanceDto>(await _icrud.Create((_mapper.Map<Attendance>(model))));
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(AttendanceDto model)
        {
            return await _icrud.Edit((_mapper.Map<Attendance>(model)));
        }
        [HttpGet]
        public async Task<AttendanceDto> Get(int Id)
        {
            return _mapper.Map<AttendanceDto>(await _icrud.GetById(Id));
        }
        [HttpGet]
        public async Task<IEnumerable<AttendanceDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<AttendanceDto>>(await _icrud.GetAll());
        }
        [HttpPost]
        public async Task<SuccessDTO> Delete(int Id)
        {
            return await _icrud.Delete(Id);
        }
    }
}

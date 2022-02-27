using SchoolAppForUcheApi.Model;
using SchoolAppForUcheApi.Model.DTO;
using SchoolAppForUcheApi.Services.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace SchoolAppForUcheApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly iCRUDService<User> _iuser;
        private readonly IDuplicateService _duplicateService;
        private readonly IMapper _mapper;
        public UserController(iCRUDService<User> iuser, IMapper mapper, IDuplicateService duplicateService)
        {
            _iuser = iuser;
            _mapper = mapper;
            _duplicateService = duplicateService;
        }

        [HttpPost]
        public async Task<UserDto> Create(CreateUserDto model)
        {
            if(!_duplicateService.CheckExistingUsername(model.Username))
                return _mapper.Map<UserDto>(await _iuser.Create(( _mapper.Map<User>(model))));
            return null;
        }
        [HttpPost]
        public async Task<SuccessDTO> Edit(UserDto model)
        {
            return await _iuser.Edit((_mapper.Map<User>(model)));
        }
        [HttpGet]
        public async Task<UserDto> Get(int Id)
        {
            return _mapper.Map<UserDto>(await _iuser.GetById(Id));
        }
        [HttpGet]
        public async Task<IEnumerable<UserDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<UserDto>>(await _iuser.GetAll());
        }
        [HttpPost]
        public async Task<SuccessDTO> Delete(int Id)
        {
            return await _iuser.Delete(Id);
        }
        [HttpPost]
        public async Task<UserDto> Login(LoginDto model)
        {
            var user =  _duplicateService.CheckUser(model.Username, model.Password);
             
            if (user != null)
            {
                var identity = new ClaimsIdentity(new[] {
                         new Claim(ClaimTypes.Name, user.Id.ToString()),
                         new Claim(ClaimTypes.Email, user.Username),

                        }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            }
            return _mapper.Map<UserDto>(user);

        }
    }
}

using AutoMapper;
using SchoolAppForUcheApi.Data;
using SchoolAppForUcheApi.Model;
using SchoolAppForUcheApi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppForUcheApi.Services.Implementation
{
    public class DuplicateService : IDuplicateService
    {
        private readonly SecSchoolContext _context;
        private readonly IMapper _mapper;

        public DuplicateService(SecSchoolContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool CheckExistingActiveTerm(int sessionId, int TermId)
        {
            return _context.Activeterm.Any(x => x.SessionId == sessionId && x.TermId == TermId && x.Active == true);
        }

        public bool CheckExistingUsername(string Username)
        {
            return _context.User.Any(x => x.Username == Username);
        }
        public User CheckUser(string Username, string Password)
        {
            return _context.User.Where(x => x.Username == Username && x.Password == Password).FirstOrDefault();
        }

    }
}

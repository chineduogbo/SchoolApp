using SchoolAppForUcheApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppForUcheApi.Services.Interface
{
   public interface IDuplicateService
    {
        bool CheckExistingUsername(string Username);
        bool CheckExistingActiveTerm(int sessionId,int TermId);
        User CheckUser(string Username, string Password);
    }
}

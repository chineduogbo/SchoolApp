using SchoolAppForUcheApi.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppForUcheApi.Services.Interface
{
   public interface iCRUDService<T> where T : class
    {
        Task<T> Create(T model);
        Task<SuccessDTO> Edit(T model);
        Task<T> GetById(int Id);
        Task<IEnumerable<T>> GetAll();
        Task<SuccessDTO> Delete(int Id);
        
    }
}

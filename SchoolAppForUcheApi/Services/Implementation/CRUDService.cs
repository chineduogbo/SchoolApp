using SchoolAppForUcheApi.Data;
using SchoolAppForUcheApi.Model.DTO;
using SchoolAppForUcheApi.Services.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppForUcheApi.Services.Implementation
{
    public class CRUDService<T> : iCRUDService<T> where T : class
    {
        private readonly SecSchoolContext _context;
        private readonly IMapper _mapper;

        public CRUDService(SecSchoolContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<T> Create(T model)
        {
            var created = await  _context.AddAsync<T>(model);
            await _context.SaveChangesAsync();
            return created.Entity;
        }

        public async Task<SuccessDTO> Delete(int Id)
        {
            var del = await _context.Set<T>().FindAsync(Id);
            _context.Remove<T>(del);
            await  _context.SaveChangesAsync();
            return (new SuccessDTO() { Id = 0, SuccessMessage = "Deleted Successfully" });
        }

        public async Task<SuccessDTO> Edit(T model)
        {
             _context.Update<T>(model);
            await _context.SaveChangesAsync();
            return (new SuccessDTO() { Id = 1, SuccessMessage = "Edited Successfully" });
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return  _context.Set<T>();
        }

        public async Task<T> GetById(int Id)
        {
            return await _context.Set<T>().FindAsync(Id);
        }

      

     

    }
}

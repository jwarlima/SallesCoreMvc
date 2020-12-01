using Microsoft.EntityFrameworkCore;
using SallesCoreMvc.Data;
using SallesCoreMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesCoreMvc.Services
{
    public class DepartmentService
    {
        private readonly SallesCoreMvcContext _context;

        public DepartmentService(SallesCoreMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            //retorna os departamentos ordenando por nome e convertido em lista ao final.
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}

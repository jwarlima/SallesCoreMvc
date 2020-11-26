using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SallesCoreMvc.Models;

namespace SallesCoreMvc.Data
{
    public class SallesCoreMvcContext : DbContext
    {
        public SallesCoreMvcContext (DbContextOptions<SallesCoreMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SallesCoreMvc.Models.Department> Department { get; set; }
    }
}

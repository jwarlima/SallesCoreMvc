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

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}

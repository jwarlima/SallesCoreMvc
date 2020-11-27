using SallesCoreMvc.Data;
using SallesCoreMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesCoreMvc.Services
{
    public class SellerService
    {
        private readonly SallesCoreMvcContext _context;

        public SellerService(SallesCoreMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            //Acessa a tabela de Vendedores e retorna os dados convertidos para lista
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

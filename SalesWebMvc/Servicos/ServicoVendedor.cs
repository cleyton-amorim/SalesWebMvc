using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Servicos
{
    public class ServicoVendedor
    {

        private readonly SalesWebMvcContext _context;


        public ServicoVendedor(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {

            return _context.Vendedor.ToList();

        }

        public void Insert(Vendedor obj)
        {
            //obj.Depart = _context.Departamento.First();
            _context.Add(obj);
            _context.SaveChanges(); 

        }


    }
}

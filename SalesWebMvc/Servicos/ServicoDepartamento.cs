using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Servicos
{
    public class ServicoDepartamento
    {

        private readonly SalesWebMvcContext _context;

        public ServicoDepartamento(SalesWebMvcContext context)
        {
            _context = context;
        }


        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }

    }
}

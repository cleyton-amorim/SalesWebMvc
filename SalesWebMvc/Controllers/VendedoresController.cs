using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Servicos;

namespace SalesWebMvc.Controllers
{
    public class VendedoresController : Controller
    {

        private readonly ServicoVendedor _servicoVendedor;

        public VendedoresController(ServicoVendedor servicoVendedor)
        {
            _servicoVendedor = servicoVendedor;
        }

        public IActionResult Index()
        {
            var list = _servicoVendedor.FindAll();
            return View(list);
        }
    }
}
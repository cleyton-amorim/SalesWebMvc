using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public double Montante { get; set; }

        public StatusVendas Status { get; set; }

        public Vendedor Vendedor { get; set; }


        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double montante, StatusVendas status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Montante = montante;
            Status = status;
            Vendedor = vendedor;
        }
    }
}

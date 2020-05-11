using System;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor v )
        {

            Vendedores.Add(v);

        }


        public void RemoveVendedor(Vendedor v)
        {

            Vendedores.Remove(v);

        }


        public double TotalVendasDepartamento(DateTime inicio, DateTime final)
        {
            return Vendedores.Sum(v => v.TotalVendas(inicio, final));
        }

    }
}

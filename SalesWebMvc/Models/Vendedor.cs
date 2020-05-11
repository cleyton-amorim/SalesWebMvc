
using System;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string email { get; set; }

        public DateTime DataNascimento { get; set; }

        public double SalarioBase { get; set; }

        public Departamento Depart { get; set; }

        public ICollection<RegistroVendas> Registrovenda { get; set; } = new List<RegistroVendas>();


        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento depart)
        {
            Id = id;
            Nome = nome;
            this.email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Depart = depart;
        }


        public void AddVendedores(RegistroVendas rv)
        {
            Registrovenda.Add(rv);
        }

        public void RemoveVendedores(RegistroVendas rv)
        {
            Registrovenda.Remove(rv);

        }
        public double TotalVendas (DateTime inicio, DateTime final)
        {
            return Registrovenda.Where(rv => rv.Data >= inicio && rv.Data <= final).Sum(sr => sr.Montante);

        }



    }





}

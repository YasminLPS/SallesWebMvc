using System;
using System.Collections.Generic;
using System.Linq;

namespace SallesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSellers(Seller sl)
        {
            Sellers.Add(sl);
        }

        public double TotalSales(DateTime initial, DateTime final) 
        {
            return Sellers.Sum(sl => sl.TotalSales(initial, final));
                          // para cada vendedo (sl) na lista, chame o TotalSales(metodo criado) no periodo (initial/final)
                                  //  e soma (Sum) desse resultado para todos os vendedores do meu departamento 
        }
    }
}

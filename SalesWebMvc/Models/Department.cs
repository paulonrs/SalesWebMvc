using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sallers { get; set; } = new List<Seller>();

        public Department() { }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSalles(Seller sl)
        {
            Sallers.Add(sl);
        }
        public void RemoveSalles(Seller sl)
        {
            Sallers.Remove(sl);
        }
        public double TotalSales(DateTime initial, DateTime ending)
        {
            return Sallers.Sum(seller => seller.TotalSales(initial, ending));
        }
    }
}

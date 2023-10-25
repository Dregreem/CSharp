using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_1_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            p.Insert("Elma", 15.5, 100);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public void Insert(string Name, double Price, int Stock)
        {
            this.Name = Name;
            this.Price = Price;
            this.Stock = Stock;
        }
    }
}

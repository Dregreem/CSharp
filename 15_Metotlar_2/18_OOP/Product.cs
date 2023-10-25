using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price  { get; set; }
        public int Stock  { get; set; }

        public static Product Insert()
        {
            Product p = new Product();
            Console.WriteLine("Name");
            p.Name = Console.ReadLine();
            Console.WriteLine("Price");
            p.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Stock");
            p.Stock = Convert.ToInt32(Console.ReadLine());

            return p;
        }

        public static void List(List<Product> list)
        {
            foreach (Product item in list)
            {
                Console.WriteLine("Ad:"+item.Name+" Fiyat:"+item.Price+" Stok:"+item.Stock);
            }
        }

        public void Print() //item.Print()
        {
            Console.WriteLine("Ad:" + Name + " Fiyat:" + Price + " Stok:" + Stock);
        }
    }
}

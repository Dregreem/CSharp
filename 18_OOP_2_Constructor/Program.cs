using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_2_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructor Method: Bir class üzerinde bir örneklem (object) yapılması durumunda otomaik çalışan bir methoddur.
            //Constructor Methodlar classla aynı isme sahiptir. Değer döndürme(return) veya döndürmeme(void) tanımları almazlar. Constructor metot public tanımlanır.
            //Constructor metot default olarak gizli bir şekilde her class açıldığında tanımlıdır. Metotun içinde bir kod bulunmaz.

            Product p = new Product("Elma",15.4,40);

            Product p2 = new Product();
            Console.ReadLine();
        }

    }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product()
        {
            Insert();
        }

        public Product(string name, double price,int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }


        public void Insert()
        {            
            Console.WriteLine("Name");
            Name = Console.ReadLine();
            Console.WriteLine("Price");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Stock");
            Stock = Convert.ToInt32(Console.ReadLine());
        }

    }
}

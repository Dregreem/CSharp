using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_3_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ETICARET :
            /*
             Product:Id,Name,Price,(*CategoryId)
             Category:Id,Name,Description,
             Customer:Id,Name,Surname,Email,Username,Password
             
             Her Entity için Kayıt,Güncelleme,Silme ve Listeleme metotları olacak

             Customer: Login, Register

             */
        }

    }
    internal class Product
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public double Price { get; set; }

        public static void Interface()
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçin \n 1- Entry \n 2- Deletion \n 3- Listing \n 4- Updating");
            string cho = Console.ReadLine();
            List<Product> list = new List<Product>();
            while (true)
            {
                if (cho == "1")
                {
                    Product.Entry(list);
                    break;
                }
                else if (cho == "2")
                {
                    Product.Deletion(list);
                    break;
                }
                else if (cho == "3")
                {
                    Product.Listing(list);
                    break;
                }
                else if (cho == "4")
                {
                    Product.Updating(list);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız tekrar deneyin");
                }
            }

        }

        public static void Entry(List<Product> liste)
        {
            Product p = new Product();
            Console.WriteLine("Name");
            p.Name = Console.ReadLine();
            Console.WriteLine("Price");
            p.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Stock");
            p.Id = Console.ReadLine();
            liste.Add(p);

        }
        public static void Deletion(List<Product> liste)
        {
            Console.WriteLine("Enter the Product Id that you want to delete");
            string Id2 = Console.ReadLine();
            foreach (Product p in liste)
            {
                if (Id2 == p.Id)
                {
                    liste.Remove(p);
                }
            }
            Console.WriteLine(" Seçtiğiniz ürün silinmiştir");

        }
        public static void Listing(List<Product> liste)
        {
            foreach (Product p in liste)
            {
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Id: " + p.Id);
                Console.WriteLine("Price: " + p.Price);
            }

        }
        public static void Updating(List<Product> liste)
        {
            Console.WriteLine("Enter the Product Id that you want to update");
            string Id2 = Console.ReadLine();
            foreach (Product p in liste)
            {
                if (Id2 == p.Id)
                {
                    while (true)
                    {
                        Console.WriteLine("Değiştirmek istediğiniz özelliği girin\n 1-Name \n 2- Id \n 3- Price");
                        string cho = Console.ReadLine();
                        if (cho == "1")
                        {
                            Console.WriteLine("Enter the new name of the product");
                            string newname = Console.ReadLine();
                            newname = p.Name;
                            Console.WriteLine("The name has been updated");
                            break;
                        }
                        else if (cho == "2")
                        {
                            Console.WriteLine("Enter the new Id of the product");
                            string newId = Console.ReadLine();
                            newId = p.Id;
                            Console.WriteLine("The Id has been updated");
                            break;

                        }
                        else if (cho == "3")
                        {
                            Console.WriteLine("Enter the new price of the product");
                            double newPrice = Convert.ToDouble(Console.ReadLine());
                            p.Price = newPrice;
                            Console.WriteLine("The price has been updated");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı giriş yaptnız lütfen tekrar deneyiniz");
                        }


                    }
                }
            }
            Console.WriteLine(" Seçtiğiniz ürün güncellenmiştir");
        }

    }
    internal class Category
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }

        public static void Interface()
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçin \n 1- Entry \n 2- Deletion \n 3- Listing \n 4- Updating");
            string cho = Console.ReadLine();
            List<Category> list = new List<Category>();
            while (true)
            {
                if (cho == "1")
                {
                    Category.Entry(list);
                    break;
                }
                else if (cho == "2")
                {
                    Category.Deletion(list);
                    break;
                }
                else if (cho == "3")
                {
                    Category.Listing(list);
                    break;
                }
                else if (cho == "4")
                {
                    Category.Updating(list);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız tekrar deneyin");
                }
            }

        }

        public static void Entry(List<Category> liste)
        {
            Category c = new Category();
            Console.WriteLine("Name");
            c.Name = Console.ReadLine();
            Console.WriteLine("Description");
            c.Description = Console.ReadLine();
            Console.WriteLine("Stock");
            c.Id = Console.ReadLine();
            liste.Add(c);

        }
        public static void Deletion(List<Category> liste)
        {
            Console.WriteLine("Enter the Product Id that you want to delete");
            string Id2 = Console.ReadLine();
            foreach (Category c in liste)
            {
                if (Id2 == c.Id)
                {
                    liste.Remove(c);
                }
            }
            Console.WriteLine(" Seçtiğiniz ürün silinmiştir");

        }
        public static void Listing(List<Category> liste)
        {
            foreach (Category c in liste)
            {
                Console.WriteLine("Name: " + c.Name);
                Console.WriteLine("Id: " + c.Id);
                Console.WriteLine("Description: " + c.Description);
            }

        }
        public static void Updating(List<Category> liste)
        {
            Console.WriteLine("Enter the Product Id that you want to update");
            string Id2 = Console.ReadLine();
            foreach (Category c in liste)
            {
                if (Id2 == c.Id)
                {
                    while (true)
                    {
                        Console.WriteLine("Değiştirmek istediğiniz özelliği girin\n 1-Name \n 2- Id \n 3- Description");
                        string cho = Console.ReadLine();
                        if (cho == "1")
                        {
                            Console.WriteLine("Enter the new name of the product");
                            string newname = Console.ReadLine();
                            newname = c.Name;
                            Console.WriteLine("The name has been updated");
                            break;
                        }
                        else if (cho == "2")
                        {
                            Console.WriteLine("Enter the new Id of the product");
                            string newId = Console.ReadLine();
                            newId = c.Id;
                            Console.WriteLine("The Id has been updated");
                            break;

                        }
                        else if (cho == "3")
                        {
                            Console.WriteLine("Enter the new description of the product");
                            string newdescription = Console.ReadLine();
                            c.Description = newdescription;
                            Console.WriteLine("The price has been updated");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı giriş yaptnız lütfen tekrar deneyiniz");
                        }


                    }
                }
            }
            Console.WriteLine(" Seçtiğiniz ürün güncellenmiştir");
        }

    }
    internal class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email {  get; set; }
        public string Username { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }

        public static void Entry(List<Customer> liste)
        {
            Customer cus = new Customer();
            Console.WriteLine("Name");
            cus.Name = Console.ReadLine();
            Console.WriteLine("Surname");
            cus.Surname = Console.ReadLine();
            Console.WriteLine("Email");
            cus.Email = Console.ReadLine();
            Console.WriteLine("Username");
            cus.Username = Console.ReadLine();
            Console.WriteLine("Id");
            cus.Id = Console.ReadLine();
            Console.WriteLine("Password");
            cus.Password = Console.ReadLine();
            
            liste.Add(cus);

        }
        public static void Deletion(List<Customer> liste)
        {
            Console.WriteLine("Enter the Customer Id that you want to delete");
            string Id2 = Console.ReadLine();
            foreach (Customer cus in liste)
            {
                if (Id2 == cus.Id)
                {
                    liste.Remove(cus);
                }
            }
            Console.WriteLine(" Seçtiğiniz Kişi silinmiştir");

        }
        public static void Listing(List<Customer> liste)
        {
            foreach (Customer cus in liste)
            {
                Console.WriteLine("Name: " + cus.Name);
                Console.WriteLine("Surname: " + cus.Surname);
                Console.WriteLine("Email: " + cus.Email);
                Console.WriteLine("Id: " + cus.Id);
                Console.WriteLine("Username: " + cus.Username);
                Console.WriteLine("Password: " + cus.Password);

            }

        }
        public static void Updating(List<Customer> liste)
        {
            Console.WriteLine("Enter the Product Id that you want to update");
            string Id2 = Console.ReadLine();
            foreach (Customer cus in liste)
            {
                if (Id2 == cus.Id)
                {
                    while (true)
                    {
                        Console.WriteLine("Değiştirmek istediğiniz özelliği girin\n 1-Name \n 2- Surname \n 3- Username \n 4-Id \n 5- Password \n 6- Email");
                        string cho = Console.ReadLine();
                        if (cho == "1")
                        {
                            Console.WriteLine("Enter the new name of the Customer");
                            string newname = Console.ReadLine();
                            newname = cus.Name;
                            Console.WriteLine("The name has been updated");
                            break;
                        }
                        else if (cho == "2")
                        {
                            Console.WriteLine("Enter the new Surname of the Customer");
                            string newId = Console.ReadLine();
                            newId = cus.Id;
                            Console.WriteLine("The Surname has been updated");
                            break;

                        }
                        else if (cho == "3")
                        {
                            Console.WriteLine("Enter the new Username of the Customer");
                            string newusername = Console.ReadLine();
                            cus.Username = newusername;
                            Console.WriteLine("The Username has been updated");
                            break;
                        }
                        else if (cho == "4")
                        {
                            Console.WriteLine("Enter the new Id of the Customer");
                            string newId = Console.ReadLine();
                            cus.Id = newId;
                            Console.WriteLine("The Id has been updated");
                            break;
                        }
                        else if (cho == "5")
                        {
                            Console.WriteLine("Enter the new Password of the Customer");
                            string newpassword = Console.ReadLine();
                            cus.Password = newpassword;
                            Console.WriteLine("The Password has been updated");
                            break;
                        }
                        else if (cho == "6")
                        {
                            Console.WriteLine("Enter the new Email of the Customer");
                            string newemail = Console.ReadLine();
                            cus.Email = newemail;
                            Console.WriteLine("The Email has been updated");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı giriş yaptnız lütfen tekrar deneyiniz");
                        }


                    }
                }
            }
            Console.WriteLine(" Seçtiğiniz ürün güncellenmiştir");
        }
        public static void Interface()
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçin \n 1- Entry \n 2- Deletion \n 3- Listing \n 4- Updating");
            string cho = Console.ReadLine();
            List<Customer> list = new List<Customer>();
            while (true)
            {
                if (cho == "1")
                {
                    Customer.Entry(list);
                    break;
                }
                else if (cho == "2")
                {
                    Customer.Deletion(list);
                    break;
                }
                else if (cho == "3")
                {
                    Customer.Listing(list);
                    break;
                }
                else if (cho == "4")
                {
                    Customer.Updating(list);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız tekrar deneyin");
                }
            }

        }

    }
}

    

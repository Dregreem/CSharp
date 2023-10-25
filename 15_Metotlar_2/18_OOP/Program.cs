using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            // User REGISTER
            #region OLD CODE
            //User user = new User(); //INSTANCE alma
            //user.Name = "Altan Emre";
            //user.Surname = "Demirci";
            //user.Username = "altanemre";
            //user.Email = "altanemre@gmail.com";
            //user.Password = "1";

            //users.Add(user);

            //User user2 = new User(); //INSTANCE alma
            //user2.Name = "Altan Emre";
            //user2.Surname = "Demirci";
            //user2.Username = "altanemre";
            //user2.Email = "altanemre@gmail.com";
            //user2.Password = "1";

            //users.Add(user2);

            //User user3 = new User(); //INSTANCE alma
            //user3.Name = "Altan Emre";
            //user3.Surname = "Demirci";
            //user3.Username = "altanemre";
            //user3.Email = "altanemre@gmail.com";
            //user3.Password = "1";

            //users.Add(user3);

            #endregion


            //User altında void tanımlı nonstatic Register metotunu kullanmak için INSTANCE alınmalıdır.

            //User user = new User();
            //user.Register();
            //users.Add(user)

            //User altında void tanımlı static RegisterStatic metotu sınıf üzeirnden kullanılır.

            //User.RegisterStatik(users);



            //users.Add(User.RegisterReturn());
            //users.Add(User.RegisterReturn());



            List<Product> products = new List<Product>();

            for (int i = 0; i < 3; i++)
            {
                products.Add(Product.Insert());
            }
                      
            //Product.List(products);

            Console.WriteLine("Seçilen ürün adı:");
            string secim = Console.ReadLine();

            foreach (Product item in products)
            {
                if (item.Name == secim)
                {
                    item.Print();
                }
            }

            Console.ReadLine();

        }
    }
  
}

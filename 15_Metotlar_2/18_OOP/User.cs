using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Method => 2'ye void, return 

        public void Register()
        {
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            Surname = Console.ReadLine();
            Console.WriteLine("Username:");
            Username = Console.ReadLine();
            Console.WriteLine("Password:");
            Password = Console.ReadLine();
            Console.WriteLine("Email:");
            Email = Console.ReadLine();
        }
        public static void RegisterStatik(List<User> liste)
        {
            User user = new User();
            Console.WriteLine("Name:");
            user.Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            user.Surname = Console.ReadLine();
            Console.WriteLine("Username:");
            user.Username = Console.ReadLine();
            Console.WriteLine("Password:");
            user.Password = Console.ReadLine();
            Console.WriteLine("Email:");
            user.Email = Console.ReadLine();
            liste.Add(user);
        }

        public static User RegisterReturn()
        {
            User user = new User();
            Console.WriteLine("Name:");
            user.Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            user.Surname = Console.ReadLine();
            Console.WriteLine("Username:");
            user.Username = Console.ReadLine();
            Console.WriteLine("Password:");
            user.Password = Console.ReadLine();
            Console.WriteLine("Email:");
            user.Email = Console.ReadLine();
            return user;
        }

        //Product: Price,Name,Stock
        //Register
    }
}

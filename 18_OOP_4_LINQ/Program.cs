using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_4_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * LINQ (İleri Sorgulama Tekniği)
             * LINQ TO SQL            
             
             */

            //List<User> users = new List<User>();

            #region 1.Yol
            //User u = new User();
            //u.Id = 1;
            //u.Username = "altanemre";
            //u.Surname = "Demirci";
            //u.Name = "Altan Emre";
            //u.Password = "1";

            //users.Add(u);
            #endregion

            #region 2.Yol
            //User u2 = new User()
            //{
            //    Id = 2,
            //    Name = "Eray",
            //    Surname="Koç",
            //    Username="eraykoc",
            //    Password="2"
            //};
            //users.Add(u2);
            #endregion


            List<int> sayilar = new List<int>() { 1, 2, 3, 4, 6 };

            List<User> users = new List<User>()
            {
                new User(){Id=1,Name="Altan Emre",Surname="Demirci",Username="altanemre",Password="1"},
                new User(){Id=2,Name="Altan Uras",Surname="Demirci",Username="altanuras",Password="2"},
                new User(){Id=3,Name="Kıvanç",Surname="Demirci",Username="kivanc",Password="3"},
                new User(){Id=4,Name="Kerem",Surname="Demirci",Username="kerem",Password="4"}
            };


            //Console.WriteLine("username:");
            //string username = Console.ReadLine();
            //Console.WriteLine("password:");
            //string pass = Console.ReadLine();

            //User user =  users.FirstOrDefault(i => i.Username == username && i.Password==pass);
            //if (user == null)
            //{
            //    Console.WriteLine("Bulunamadı.");
            //}
            //else
            //{
            //    Console.WriteLine(user.Username);
            //}

            #region SOYADI DEMİRCİ olan kayıtlar

            var list = users.Where(i => i.Surname == "Demirci").ToList().OrderByDescending(i=>i.Id);

            var user = users.Where(i => i.Username == "altanemre" && i.Password == "1").FirstOrDefault();

            
            #endregion






        }
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

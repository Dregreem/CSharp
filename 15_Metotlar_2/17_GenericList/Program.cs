using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _17_GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             GENERIC LIST (COLLECTION)
                         
            //List<T> // T .net tarafında GENERIC TYPE anlamına gelir.

            //int[] sayilar = new int[10];
            //ArrayList sayilar2 = new ArrayList();

            // Boş Liste Tanımı
            //List<int> sayilar = new List<int>();

            //Dolu Liste Tanımı
            List<string> isimler = new List<string>() { "Altan Emre", "Furkan", "Sudenaz", "Muhammed" };

             */

            #region List 
            //List<string> isimler = new List<string>() { "Altan Emre", "Furkan", "Sudenaz", "Muhammed" };


            //isimler.Add("Kerem");
            ////Çoklu eleman ekle

            //List<string> ogrenciler = new List<string> { "Şeyma","Alper"};

            //isimler.AddRange(new List<string>() { "ahmet", "mehmet" });
            //isimler.AddRange(ogrenciler);

            ////foreach (var item in isimler)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //Console.WriteLine("************");

            //isimler.ForEach(item => Console.WriteLine(item));

            #endregion


            // Bir okul sistemi yazılacak. 
            // Öğrenci: Ad,Soyad,Numarası,Sınıf
            // Altan Emre,Demirci,1,10-F
            // Alper     ,Dan    ,2,11-A
            // Ceylan    ,Demirci,3,9-B

            //List<string> ogrenciler = new List<string>();

            //ogrenciler.Add("Altan Emre");
            //ogrenciler.Add("Demirci");
            //ogrenciler.Add("1");
            //ogrenciler.Add("10-F");
            //ogrenciler.Add("Alper");
            //ogrenciler.Add("Dan");
            //ogrenciler.Add("2");
            //ogrenciler.Add("11-A");
            //ogrenciler.Add("Ceylan");
            //ogrenciler.Add("Demirci");
            //ogrenciler.Add("3");
            //ogrenciler.Add("9-B");

            //INSTANCE(ORNEKLEM)
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Altan Emre";
            ogrenci.Soyad = "Demirci";
            ogrenci.Numara = 1;
            ogrenci.Sinif = "10-F";


            //Console.WriteLine("Soyadınız:");
            //ogrenci.Soyad = Console.ReadLine();


            Ogrenci ogrenci2 = new Ogrenci()
            { 
                Ad = "Alper", 
                Soyad = "Dan", 
                Numara = 2, 
                Sinif = "11-A" 
            };


            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            ogrenciler.Add(ogrenci);
            ogrenciler.Add(ogrenci2);

            /*
             Ogrenciler Listesi
                0 -> { Ad = "Altan Emre", Soyad = "Demirci", Numara = 1, Sinif = "10-F" }
                1 -> { Ad = "Alper", Soyad = "Dan", Numara = 2, Sinif = "11-A" }
             
             */


            //foreach (Ogrenci o in ogrenciler)
            //{
            //    Console.WriteLine(o.Ad+" "+o.Soyad+" "+o.Sinif+" "+o.Numara);
            //}


            //Console.WriteLine("İstenilen öğrencinin no:");
            //int no = Convert.ToInt32(Console.ReadLine());

            //foreach (Ogrenci o in ogrenciler)
            //{
            //    if (o.Numara == no)
            //    {
            //        Console.WriteLine(o.Ad + " " + o.Soyad + " " + o.Sinif + " " + o.Numara);
            //    }
            //}



            Ogrenci o = new Ogrenci();
            o.Ad = "Şeyma";
            o.Soyad = "Hacıosmanoğlu";
            o.Numara = 101;
            o.Sinif = "C#";

            o.OzellikYazdir();







            Console.ReadLine();
        }
    }
}

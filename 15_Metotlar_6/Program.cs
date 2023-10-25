using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Metotlar_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OVERLOAD METOTLAR (Aşırı Yüklenmiş Metotlar)
            // Bir methodun aynı isimle birden fazla kez tanımlanmasına denir.
            // Aynı isimle methodları tanımlamak için METOT İMZALARI farklı olmalıdır.
            // Method imzası: Parametre sayısı ve parametre veri tipi 


            Topla();            
        }

        static void Topla()
        {
            Console.WriteLine("1.Sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi2+sayi1);
        }       

        static void Topla(int s1,int s2)
        {
            Console.WriteLine(s1+s2);
        }
        static void Topla(int s1, int s2,int s3)
        {
            Console.WriteLine(s1 + s2 + s3);
        }
        static void Topla(int s1, double s2)
        {
            Console.WriteLine(s1 + s2);
        }
        static void Topla(double s1, int s2)
        {
            Console.WriteLine(s1 + s2);
        }
    }
}

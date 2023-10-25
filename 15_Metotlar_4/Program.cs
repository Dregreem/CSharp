using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Metotlar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak bir ürün fiyatın KDV uygulayarak yeni fiyatı kullanıcıya gösteriniz
            //KDVUygula=>%18

            //Console.WriteLine(KDVHesapla());


            //Console.WriteLine("Ürün fiyatı:");
            //double urun = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(KDVHesapla2(urun));



            KDVHesapla3();


            Console.ReadLine();
        }

        //Değer Döndüren Parametresiz
        static double KDVHesapla()
        {
            Console.WriteLine("Ürün fiyatı:");
            double urun = Convert.ToDouble(Console.ReadLine());
            
            return urun*1.18;
        }

        //Değer Döndüren Parametreli 
        static double KDVHesapla2(double fiyat)
        {
            return fiyat * 1.18;
        }
        //Değer Döndürmeyen Parametresiz
        static void KDVHesapla3()
        {
            Console.WriteLine("Ürün fiyatı:");
            double urun = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(urun * 1.18);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // DataAccessModifier : public,private,internal,protected
            // void(değer döndürmeyen), return(değer döndürme)
            // parametre

            // ******** DATA ACCESS MODIFIER ***********
            
             private: Tanımlı olduğu class altında erişilebilir.

             public: Bulunduğu solution altındaki her yerden erişilebilir.

             internal:Tanımlı olduğu proje içinde PUBLIC proje dışında kalan her yapı için PRIVATE tanımlıdır.




            static:Tanımlı olduğu yerden class adı ile erişilebilr ve kullanılabilirlik sağlar.
            nonstatic: Tanımlı olduğu classtan INSTANCE alınalarak kullanılabilirlik sağlar.
          

            //public oldukları
            //Console.WriteLine(Matematik.sayi);
            //Matematik.Topla();

            ////ad değişkeni PRIVATE tanımlıdır
            ////Matematik.ad


            //// CIKARMA metodu nonstatic
            //Matematik m = new Matematik();
            //m.Cikarma();
               */
            /* *********** METOTLAR *************

            * Metot: Belirli işlemi isim vererek tanımlamımızı ve ihtiyaç duyduğumuz zamanlarda verilen isim ile ulaşarak kullanmamızı sağlar.
            * Metotlar iç içe tanımlanmazlar. 
            * Metotlar () işareti ile tanımlanırlar.
            
            
             Metotlar 2 ye ayrılır. 
            * Değer Döndürmeyen Metotlar (void)
            * Değer Döndüren Metotlar (return)
            
            */



            //iki sayı alıp toplyarak ekrana yazdıran kod

            //Console.WriteLine("1.Sayı");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("1.Sayı");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi2+sayi1);


            //Topla();
            //Matematik.Topla();

            //int t = Toplama();

            //int s = Toplama();

        }

        //static tanımlı yapılar içerisinde static metotlar çağrılabilir(zorunlu).
        //DEĞER DÖNDÜRMEYEN
        public static void Topla()
        {
            Console.WriteLine("1.Sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi2 + sayi1);
        }

        //public static int Toplama()
        //{
        //    Console.WriteLine("1.Sayı");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("1.Sayı");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    int toplam = sayi1 + sayi2;
        //    return toplam;

        //    //return sayi2 + sayi1;

        //}

    }
}

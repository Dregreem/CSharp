﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_6_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             POLYMORPHISM NEDİR? 

             Çokbiçimlilik (Polymorphism) bir nesnenin farklı amaçlar için de kullanılabileceği anlamına gelir ve statik ve dinamik olmak üzere ikiye ayrılır.

                * Statik çokbiçimlilik; metot ve operatörlerin aşırı yüklenmesi (overload) olarak belirtilir.
                * Dinamik çokbiçimlilik; özet sınıflardan miras alma yoluyla işlemlerin gerçekleştirilmesi işlemine verilen isimdir.
              
             Statik çokbiçimlilik türünden, metotların aşırı yüklenmesine yönelik bir çalışma yapacağız.
             

            //StatikPolimorphism sp = new StatikPolimorphism();

            //sp.Yaz(30, "altan");

            //Console.ReadLine();

            Dinamik çokbiçimlilik türünden, metodu override etmeliyiz.

            VIRTUAL() METODU

            *Temel sınıfa ait bir metodun bazen türemiş sınıfta farklı bir şekilde kullanılması gerekebilir. Bu durumda temel sınıfın söz konusu metodu türemiş sınıfın değiştirip kullanabileceği yönünde izin vermesi gerekir. Bu izin, metodun temel sınıfta “virtual” olarak tanımlanması sonucu verilmektedir. Diğer bir ifadeyle temel sınıfta “virtual” olarak tanımlanmış bir metodun türemiş sınıfta yeniden yazılabileceği belirtilmiş olunuyor.


            METODU OVERRIDE ETMEK, OVERRIDE NEDİR?METOTUN EZİLMESİ

            *Temel sınıfta “virtual” tanımlanmış bir metodun türemiş sınıfta yeniden yazılması için (geçersiz kılma) “override” sözcüğü kullanılır. 
             *Temel sınıfta “virtual” tanımlanmamış ya da “static” tanımlanmış olan üyeler (metot, özellik, dizinleyici ya da olay) türemiş sınıfta yeniden yazılamaz (Geçersiz kılınamaz.).
             


            /*AŞAĞIDAKİ örnekte Daire, Kure ve Silindir sınıfları Sekil temel sınıfından türetilmişlerdir.
            Hepsinde de Sekil sınıfında “virtual” tanımlanan alan metodu yeniden yazılmıştır. Bu
            yeniden yazma (geçersiz kılma) esnasında “override” sözcüğünün kullanıldığına dikkat
            ediniz. Ayrıca burada dikkat edilmesi gereken nokta “virtual” ve “override” metotların imzalarının (dönüş türleri ile birlikte parametrelerinin tür ve sayıları) aynı olması gerekliliğidir.

            Ayrıca temel sınıfta “virtual”, “abstract” ya da “override” olarak tanımlanmış
            metotlar türemiş sınıfta geçersiz kılınabilir.
            Bir diğer önemli nokta da “override” metotlar “new”, “static” ya da “virtual”
            sözcükleri ile tanımlanamaz.

            Son olarak “virtual” metodun erişim belirteci “override” sırasında değiştirilemez.
            Yani temel sınıfta metot “public” ise türemiş sınıfta da “public”, “protected” ise “protected” kalmalıdır.
            */

            Sekil s = new Sekil(5,10);
            Console.WriteLine(s.Alan());


            Daire d = new Daire(5);

            Console.ReadLine();
        }

        #region OVERLOAD = Static Polymorphism
        static void Topla(int s1,int s2)
        {
            Console.WriteLine(s2+s1);
        }
        static void Topla(double s1, int s2)
        {
            Console.WriteLine(s2 + s1);
        }
        static void Topla(int s1, int s2,int s3)
        {
            Console.WriteLine(s2 + s1+s3);
        }
        #endregion
    }
    #region Static Polymorphism
    //class Ogrenci
    //{
    //    // OVERLOAD = Static Polymorphism
    //    void Topla(int s1, int s2)
    //    {
    //        Console.WriteLine(s2 + s1);
    //    }
    //    void Topla(double s1, int s2)
    //    {
    //        Console.WriteLine(s2 + s1);
    //    }
    //    void Topla(int s1, int s2, int s3)
    //    {
    //        Console.WriteLine(s2 + s1 + s3);
    //    }
    //}
    #endregion

    #region Dinamic Polymorphism

    public class Sekil
    {
        public const double PI = Math.PI;
        public double x, y;

       

        public Sekil(double x,double y)
        {
            this.y = y;
            this.x = x;
        }

        public virtual double Alan() 
        {
            return x*y;
        }
    }

    public class Daire : Sekil
    {
        public Daire(double r):base(r,0)
        {
            
        }

        public override double Alan()
        {
            return PI * x * x;
        }
    }
    class Kure : Sekil
    {
        public Kure(double r) : base(r, 0)
        {
        }
        public override double Alan()
        {
            return 4 * PI * x * x;
        }
    }
    class Silindir : Sekil
    {
        public Silindir(double r, double h) : base(r, h)
        {

        }
        public override double Alan()
        {
            return 2 * PI * Math.Pow(x, x) + 2 * PI * x * y;
        }
    }
    #endregion
}

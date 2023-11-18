using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_7_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ABSTRACT NEDİR?*/
            /*Abstract class’lar, oluşturulması istenen class’ların sadece base class olarak davranması
             * ve üzerinden bir instance oluşturulmamasının istendiği durumlarda kullanılır. 
             * C#’da bu fonksiyonaliteyi sağlamak için abstract anahtar sözcüğünü kullanmak yeterlidir. */


            //Araba araba = new Araba(); // Abstract classdan Instance ALINAMAZ.


            /*
    ***** Abstract Sınıfların Normal Sınıflardan Farkı Nedir? *****
    Fark 1: Normal sınıflar içerisinde metot bildirimi yapılamazken, Abstract sınıflar içerisinde tıpkı arayüzler de olduğu gibi metot bildirimi yapılabilir. 
    Bildirimi yapılan metotlar, Abstract sınıftan türeyen sınıflar içerisinde tanımlanmak zorundadır.

    Fark 2: Normal sınıflardan “new()” anahtar sözcüğü ile nesneler oluşturulabilir ancak Abstract sınıflar tamamen kalıtım amaçlı geliştirildiğinden Abstract sınıflardan nesne oluşturulamaz.
    */

            Ogrenci og = new Ogrenci();

            og.

            Ogretmen ogrt = new Ogretmen();

           
            //Insan insan = new Insan();



        }
    }

    // abstract class: Base class gibi görev yapmasını sağlar. Nesne oluşturulamaz.
    abstract class Insan //Base class:projede kullanılan ortak fields bir başlık altında toplamak
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public abstract void Kayit();
        public void Yaz() {
            Console.WriteLine("Abstract class altında normal ve abstract field lar bulunabilir ve bir özellik abstract keyword alırsa class abstract olmak zorundadır.");
        }
    }

    class Ogrenci:Insan
    {      
        public string Sinif { get; set; }

        public override void Kayit()
        {
            Console.WriteLine("ID");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("AD:");
            Ad = Console.ReadLine();

            Console.WriteLine("SOYAD:");
            Soyad = Console.ReadLine();

            Console.WriteLine("Sinif:");
            Sinif = Console.ReadLine();
        }
    }
    class Ogretmen:Insan
    {       
        public string Maas { get; set; }

        public override void Kayit()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_5_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // NameHiding için "new" keyword kullanılır.

            //Ogrenci:TC,Ad,Soyad,Telefon,bolum
            //Ogretmen:TC,Ad,Soyad,Telefon,Brans
            //Mudur:TC,Ad,Soyad,Telefon,Maas
            //Veli: TC,Ad,Soyad,Telefon,Adres

            //Kayit,Sil,Güncelle,Listele


            //List<Ogrenci> ogrenciler = new List<Ogrenci>();
            //List<Ogretmen> ogretmenler = new List<Ogretmen>();

            //Ogrenci ogr = new Ogrenci();
            //ogr.Kayit();
            //ogrenciler.Add(ogr);


            //Ogretmen og = new Ogretmen();
            //og.Kayit();
            //ogretmenler.Add(og);

            C c = new C();


            Console.ReadLine();
        }
    }

    class Insan
    {
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public void Kayit()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
            Console.WriteLine("TC:");
            TC = Console.ReadLine();
            Console.WriteLine("Telefon:");
            Telefon = Console.ReadLine();
        }
    }

    class Ogrenci:Insan
    {
        public string Bolum { get; set; }

        public new void Kayit()
        {
            base.Kayit();
            Console.WriteLine("Bölüm:");
            Bolum = Console.ReadLine();
        }
    }

    class Ogretmen : Insan
    {
        public string Brans { get; set; }

        public void Kayit()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
            Console.WriteLine("TC:");
            TC = Console.ReadLine();
            Console.WriteLine("Telefon:");
            Telefon = Console.ReadLine();
            Console.WriteLine("Branş:");
            Brans = Console.ReadLine();
        }
    }

    class Mudur : Insan
    {
        public double Maas { get; set; }
    }
    class Veli : Insan
    {
        public string Brans { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_5_Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci og = new Ogrenci("1","ali","veli","123","Yazılım");
        }
    }

    class Insan
    {
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public Insan(string tc,string ad,string soyad,string telefon)
        {
            TC = tc;
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
        }
    }

    class Ogrenci : Insan
    {
        public Ogrenci(string tcKimlik, string isim, string soyisim, string phone,string bolum) : base(tcKimlik, isim, soyisim, phone)
        {
            Bolum = bolum;
        }

        public string Bolum { get; set; }
    }

}

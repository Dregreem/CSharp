using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_5_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  KALITIM - INHERITANCE
             
             * Ortak özelliklere sahip birden fazla classın ortak özelliklerini base tanımlı bir class a yazarak her classta bu ortak olan özellikleri tekrar  tekrar yazmaktan kurtulabiliriz.
             * 
             * 
             
             */

            //Şirket : Muhasebe,Insan Kaynaklari,Satınalma
            //Muh: TC,İsim,Soyisim,İşeGirişTarihi,DefterSayisi
            //IK: TC,İsim,Soyisim,İşeGiriştarihi,PersonelSayisi
            //Satınalma:TC,İsim,Soyisim,İşeGiriştarihi,TeklifSayisi

            Console.WriteLine(DateTime.Now);
        }
    }
    class Personel
    {
        public int TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public int Maas { get; set; }

        public void Register()
        {

        }
    }
    class MUH:Personel
    {      
        public int DefterSayisi { get; set; }
    }
    class IK : Personel
    {
        public int PersonelSayisi{ get; set; }
        public void IsCikisi()
        {

        }
    }
    class Satinalma : Personel
    {      
        public int TeklifSayisi { get; set; }
    }
}

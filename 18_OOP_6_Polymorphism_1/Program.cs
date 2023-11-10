using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_6_Polymorphism_1
{
    internal class Program
    {
        static void Main(string[] args)
        {  /*
             Otomobil : Agırlık,renk,motorhacmi,                OzellikYaz()
             Spor: Agirlik,renk,motorhacmi,kapiSayisi,          OzellikYaz()
             Kamyonet:Agirlik,renk,motorhacmi,TasimaKapasitesi  OzellikYaz()                
             */
        }
    }
    class Araba
    {
        public int Agirlik { get; set; }
        public string Renk { get; set; }
        public int MotorHacmi { get; set; }

        public virtual void OzellikYaz()
        {
            Console.WriteLine(Renk);
            Console.WriteLine(Agirlik);
            Console.WriteLine(MotorHacmi);
        }
    }
    class Otomobil : Araba { }
    class Spor : Araba
    {
        public int KapiSayisi { get; set; }

        public override void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine(KapiSayisi);
        }
    }
    class Kamyonet : Araba
    {
        public int TasimaKapasitesi { get; set; }
        public override void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine(TasimaKapasitesi);
        }
    }
}

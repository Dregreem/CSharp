using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_6_Polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            E-Ticaret sitemiz: 
                Tekstil: Adi,Fiyat,Kumasturu,Beden,UreticiFirma, KDVUygula()  1.20
                CepTelefon:Adi,Fiyat,Marka,Özellikler KDVUygula()  1.20
                Ekmek:Adi,Fiyat,Gramaj KDVUygula()  1.08

            Sepet: Sepetteki urunlerın fiyatlarına KDVUygulayarak toplayacak bir TOPLAMTUTAR() ve sepete ürün ekleyecek EKLE() metotları yazılsın.
             */


            Sepet sepet = new Sepet();

            Ekmek ek = new Ekmek() { Fiyat = 10.0, UrunAdi = "Çavdar", Gramaj = 340 };

            sepet.Ekle(ek);

            Ceptelefon tel = new Ceptelefon() { UrunAdi = "Huawei", Fiyat = 15000.00, Marka = "PLite30", Ozellikler = "Bluetooth" };
            sepet.Ekle(tel);

            Tekstil gomlek = new Tekstil() { Fiyat = 300, UrunAdi = "Tudors", KumasTuru = "Cotton",Beden=44,UreticiFirma="Koton" };

            sepet.Ekle(gomlek);

            Console.WriteLine(sepet.ToplamTutar());

        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public virtual double KDVUygula()
        {
            return Fiyat * 1.2;
        }
    }
    class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public int Beden { get; set; }
        public string UreticiFirma { get; set; }
        //KDVUygula metodu yazılmadı. Çünkü Tekstilde 1.2 kdv uygulanır buda baseden geliyor.
    }
    class Ceptelefon : Urun
    {
        public string Marka { get; set; }
        public string Ozellikler { get; set; }
        //KDVUygula metodu yazılmadı. Çünkü Ceptelefonunda 1.2 kdv uygulanır buda baseden geliyor.
    }
    class Ekmek : Urun
    {
        public int Gramaj { get; set; }

        public override double KDVUygula()
        {
            return Fiyat * 1.08;
        }
    }

    class Sepet
    {
        private List<Urun> urunler = new List<Urun>();

        public double ToplamTutar()
        {
            double toplam = 0;
            foreach (Urun item in urunler)
            {
                toplam += item.KDVUygula();
            }

            return toplam;
        }
        
        public void Ekle(Urun urun)
        {
            urunler.Add(urun);
        }
    }

}

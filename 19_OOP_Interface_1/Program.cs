using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Interface_1
{
    internal class Program
    {
        static void Main(string[] args)
        {  /*Çoklu İmplementasyon 
             
             * Bir sınıfa birden fazla arayüz implement edilebilir. 
             * Örnek bir senaryo üzerinden konuyu anlatacak olursak; 
             * Bir fabrika için otomasyon programı yazdığımızı düşünelim. 
             * Fabrikada 3 farklı çalışan türü olsun, bunlar yönetici, işçi ve robot. 
             * Her bir çalışanın ID, ad-soyad, adres, maaş, departman ve toplam çalışma saati bilgisi olsun. 
             */
        }
    }
    interface IKisi
    {     
        string AdSoyad { get; set; }
        string Adres { get; set; }       
        decimal Maas { get; set; }       
    }

    class Calisan
    {
        int Id { get; set; }
        string Departman { get; set; }
        int Mesai { get; set; }
    }

    class Isci : Calisan, IKisi
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public decimal Maas { get; set; }
    }

    class Yonetici : Calisan,IKisi
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public decimal Maas { get; set; }      
    }

    class Robot : Calisan
    {
        public string model { get; set; }
    }

}

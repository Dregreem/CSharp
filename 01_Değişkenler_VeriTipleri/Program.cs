using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Değişkenler_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region TANIMLAR
            //Tek satır açıklama - yorum(comment) yazmak için // kullanılır.



            // Birden fazla
            //            satır

            //                Yorum satırı yazılır.             
            // */


            //Kodları düzenlemek için kullanılan kod: Ctrl + K + D


            // * ******* .NET FRAMEWORK*********

            //* FRAMEWORK : yazılımcılar tarafından geliştirilen hazır kod kütüphanesidir.
            //* .NET      : ortak çalışma platform



            // DERLEYİCİ(Compiler) - Visual Studio 2022
            // Yazılan her kodun yazım hatasını ve ilişkilerini denetler.
            // Optimize: sistem çalıştırmaya uygunmu ? (Donanımsal)
            // Compile : Kod mac diline çevirir.
            // Execute: Kod çalışır
            // Result: Sonuç getirilir.



            //Bütün kodlamalar static void Main() içine yapılacak. 


            //Proje Açma => File => New Project => Console App(C# .Net Framework olmasına dikkat ediyoruz.)
            //Solution => Birden fazla projeyi altında barındırabilen yapıdır.

            //           Kapsadığı projelerin birbirlerini tanımasını ve senkronize olarak iletişim kurmasını sağlar.



            // **** Yazılım Dillerinde KÜÇÜK harf BÜYÜk harf DUYARLILIĞI VAR.
            #endregion

            #region DEĞİŞKENLER
            /*  ******** DEĞİŞKENLER(VARIABLES) VE VERİTİPLERİ(DATATYPE) ********

            Proje içerisinde tanımlı, dışarıdan alınacak veya bir işlem sonucunu ortaya çıkan verileri tutmak için değişkenler kullanılır. Değişkenler TEK DATA tutabilirler.


            Değişken İsimlendirme Kuralları(Case_sensitive)
            Yanlışlar: 2sayi, ?sayi, sayi!, ad soyad
            Doğrular:  sayi2, _sayi, sayi_, adsoyad, ad_soyad 

             ** Özel karakter olarak bütün yazılım dillerinde kabul edilen tek karakter '_' dir.
             
             
             * Değişkenler TEK DATA tutarlar.
              
              
             Camel Case = adSoyad
             Kebab Case = ad-soyad
             Upper Case = ADSOYAD
             Lower Case = adsoyad
             Snake Case = ad_soyad

             */


            //int sayi = 1;
            ////sayi=12;
            //int Sayi = 12;

            //Console.WriteLine(Sayi+15);


            // İki sayının toplam işlemi (2,33)

            //int sayi1 = 2;
            //int _sayi = 33;

            //Console.WriteLine(sayi);

            //string ad = "altan emre";

            //Console.WriteLine(ad.ToUpper());
            #endregion


            //string yas = "33";
            //string yas2 = "21";

            //Console.WriteLine(yas+yas2);

            #region VERİ TİPLERİ 

            //**** Sayısal Veri Tipleri (INTEGER):
            //  Tam sayi veri tipleri: byte,sbyte,short,ushort,int,uint,long,ulong
            //  Ondalıklı sayı veri tipleri: float,double
            //  Decimal
            //int sayi = 1234567890;

            //float floatsayi = 123.45f;
            //double doublesayi = 123.45;

            //decimal sayi = 12.5m;


            // Üç sayı(1. tam sayı 2.3. ondalıklı olsun) tanımlayarak toplamlarını ekrana yazdırınız

            //int sayi = 12;
            //double sayi2 = 12.5;
            //float sayi3 = 12.5f;

            //double toplam = sayi + sayi2 + sayi3;
            //Console.WriteLine("Toplam:"+ toplam);


            //**** Sözel Veri Tipleri (STRING):
            // char : tek bir karakter tutar. char harf ='a';  char sayi='1'; char i='?';
            // string : kapasitesi ram boyutu kadardır. string ad = "Altan Emre Demirci";


            // Kullanıcıdan adını,soyadını alıp ekrana yazdırınız.
            //Console.WriteLine("Adınız:");            
            //string ad = Console.ReadLine();

            //Console.WriteLine("Soyadınız:");
            //string soyad = Console.ReadLine();

            //Console.WriteLine("Ad Soyad:"+ad+" "+soyad);


            //***** Mantıksal Veri Tipleri (BOOLEAN) *****
            // bool = true,false değelerinden birini alır.

            //bool cevap = 5 < 3;
            //Console.WriteLine(cevap);

            #endregion

            #region String Kaçış Karakterleri

            //    \n: alt satıra geç.
            //    \t: 4 boşluk bırakır.
            //Console.WriteLine("Altan\nEmre\t\tDemirci\n");

            #endregion

            //Console.WriteLine("Altan\n\n\nEmre");
            //Console.WriteLine("Demirci");
            #region KAPSAM GEÇERLİLİĞİ

            //{
            //    int a = 5;
            //    Console.WriteLine(a + 8);
            //}
            //{
            //    int a = 3;
            //}
            //Console.WriteLine(a);





            //int a = 4;
            //{
            //    int a = 7;
            //    {
            //        int a = 5;
            //        Console.WriteLine(a + 8);
            //    }
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine(a + 7);


            //{
            //    int a = 5;
            //    int b;
            //    {
            //        Console.WriteLine(a);
            //        b = 8;
            //    }

            //    Console.WriteLine(a + b);
            //}



            //*****SABİT DEĞİŞKEN TANIMLAMA (Constant)

            //const int sayi = 5;

            //sayi = 7;
            

            //Console.WriteLine(sayi);



            #endregion


            Console.ReadLine();
        }
    }
}

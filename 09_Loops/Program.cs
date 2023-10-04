using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// ********* DÖNGÜLER -  LOOPS *******************


            // WHILE, FOR, DO WHILE, FOREACH 





            // 1-10 arasındaki sayıları ekrana yazıdırınız
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);



            #region ************** WHILE DÖNGÜSÜ *****************

            /*
            while(koşul){

               koşul true olduğu sürece while döngü bloğu tekrar tekrar çalışır.
           }

            */


            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            #region 1.Örnek

            // 1 ile 100 arasındaki 3'ün katları olan sayıları ekrana yazdırınız.

            //int s = 1;

            //while (s < 100)
            //{
            //    if (s % 3 == 0)
            //    {
            //        Console.WriteLine(s);
            //    }
            //    s++;
            //}

            ////
            //int s = 3;

            //while (s < 100)
            //{
            //    Console.WriteLine(s);

            //    s += 3;
            //}

            #endregion

            #region 2.Örnek

            //1-100 arasındaki sayılardan 3'ün katları olanların toplamını ekrana yazdırınız.

            //int i = 1;
            //int toplam = 0;

            //while (i < 100)
            //{
            //    if (i % 3 == 0)
            //    {
            //        toplam += i; // toplam=toplam+i;
            //    }
            //    i++;
            //}
            //Console.WriteLine(i);
            //Console.WriteLine("Toplam:"+toplam);

            #endregion

            #region 3.Örnek
            // Kullanıcıya kaç adet ürün aldığını soralım. Girilen adet kadar kullanıcıya fiyat girmesini isteyelim ve toplam ödemesini ekrana yazdıralım.

            //Console.WriteLine("Ürün sayısı:");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //double toplam = 0;

            //while (adet > 0)
            //{
            //    Console.WriteLine("Ürün Fiyatı:");
            //    double fiyat = Convert.ToDouble(Console.ReadLine());

            //    toplam += fiyat; // toplam=toplam+fiyat
            //    adet--;
            //}

            //Console.WriteLine("Ödemeniz:"+toplam);

            // 2. Yöntem
            //Console.WriteLine("Ürün sayısı:");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //double toplam = 0;
            //int i = 1;
            //while (i<=adet)
            //{
            //    Console.WriteLine($"{i}.Ürün Fiyatı:");
            //    double fiyat = Convert.ToDouble(Console.ReadLine());

            //    toplam += fiyat; // toplam=toplam+fiyat
            //    i++;
            //}


            //Console.WriteLine("Ödemeniz:" + toplam);


            #endregion

            #region BREAK -  CONTINUE KOMUTLARI
            //break: Döngüyü istenilne satırdan bitirmek(kırmak) için kullanılır.
            //continnue: Okunduğu satırdan döngünün koşuluna geri dönmeyi sağlar.

            // 1-10 sayıları ekrana yazdırırken 4 sayısını atlayın ve 7 sayısında döngüyü bitirin.

            //int i = 1;
            //while (i < 11)
            //{
            //    if (i == 4)
            //    {
            //        i++;
            //        continue;                   
            //    }

            //    if (i == 7)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //    i++;
            //}



            #endregion

            #region 4.Örnek
            // Kullanıcıya önceden tanımlı kullanıcıadı ve şifre ile 3 hak vererek giriş yapmasını isteyeceğiz.

            //string username = "altanemre";
            //string sifre = "1";
            //int hak = 1;

            //while (hak < 4)
            //{
            //    Console.WriteLine($"{hak}. hakkınız");
            //    Console.WriteLine("Kullanıcı Adı:");
            //    string kadi = Console.ReadLine();

            //    Console.WriteLine("Şifreniz:");
            //    string ksifre = Console.ReadLine();

            //    if(username==kadi && sifre == ksifre)
            //    {
            //        Console.WriteLine("Tebrikler");
            //        break;
            //    }
            //    else if(hak<3)
            //    {
            //        Console.WriteLine("Tekrar Deneyiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hakkınız Bitti");
            //    }
            //    hak++;
            //}




            #endregion

            #region 5.Örnek

            // Kullanıcıdan 5 adet tek sayı alıp ekrana yazdırınız.

            //int i = 1;
            //while (i<6) //1,2,3,4,5
            //{

            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi % 2 == 1)
            //    {
            //        Console.WriteLine(sayi);
            //        i++;
            //    }               
            //}



            #endregion

            #region While True

            //while (true)
            //{
            //    Console.WriteLine("ALTAN EMRE HARİKA BİR ÖĞRETMENDİR.");
            //}

            // Kullanıcı 0 değerini girene kadar girilen bütün sayıları toplayan döngü yapısını kodlayınız.

            //int toplam = 0;

            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi= Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //    {
            //        Console.WriteLine("Toplam:"+toplam);
            //        break;
            //    }

            //    toplam += sayi;
            //}

            #endregion

            #endregion


            #region RANDOM KÜTÜPHANESİ

            // Rastgele sayı ürettir.

            //Instance(Örneklem)
            //Random r = new Random();

            //while (true)
            //{              
            //    Console.WriteLine(r.Next(1,10));
            //    Thread.Sleep(500);
            //}

            //int rastgelesayi = r.Next(1, 100);


            // Bilgisayar 1 100 arasında bir rastgele değer tutsun ve kullanıcının 5 hak da tahmin etmesini isteyin. tahminleri büyültün küçültün gibi yönlendirin.

            //Random r = new Random();
            //int rast = r.Next(1, 100);
            //int hak = 1;

            //while (hak < 6)
            //{
            //    Console.WriteLine($"{hak}. tahmininiz:");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == rast)
            //    {
            //        Console.WriteLine("Tebrikler");
            //        break;
            //    }
            //    else if (hak == 5)
            //    {
            //        Console.WriteLine("Hakkınız Bitti");
            //    }
            //    else if (tahmin > rast)
            //    {
            //        Console.WriteLine("Tahmininizi küçültünüz");
            //    }
            //    else if(tahmin<rast)
            //    {
            //        Console.WriteLine("Tahmininizi büyültünüz");
            //    }

            //    hak++;
            //}




            #endregion


            #region ************** FOR DÖNGÜSÜ ***************

            //int i = 1;
            //while (i<11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            /*
             1-değişken tanımla
             2-koşul ver
             3-Yapılacak kod
             4-değişken manipüle
             5-koşul
             6-Yapılacak kod
             7-değişken manipüle..
             */


            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #region 1.Örnek

            // For loop ile 1 - 100 arasındaki çift sayıları yazdırınız

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);

            //}
            #region 2.Örnek

            // For loop ile 1 - 100 arasında 3'ün katı sayıların adetini ve toplamını yazdırınız

            //int toplam = 0;
            //int adet = 0;
            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        adet++;
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("Toplam:"+toplam+"Adet:"+adet);
            //Console.WriteLine($"Toplam:{toplam}Adet:{adet}");
            //Console.WriteLine("Toplam:{0}Adet:{1}",toplam,adet);


            #endregion



            #endregion

            #region 2.Örnek
            // 5 => 1*2*3*4*5 =>

            //kullanıcıdan alınacak bir sayının faktöriyelini bulan hesaplamayı  for ile yapınız


            #endregion
            #endregion

            Console.ReadLine();
        }
    }
}

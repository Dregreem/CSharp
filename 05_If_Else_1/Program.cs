using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_If_Else_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // AKIŞ KONTROL - KOŞUL İFADELERİ - KARAR YAPILARI - IF ELSE IF ELSE

            /*
             Bir kod akışında bazı durumlar kontrol edilerek, kontrol sonucuna göre kodun yönlendirilmesi gerekiyor ise if else yapısı kullanılır.
            her zaman ilk durum kontrolü IF ile yapılır veif bir kez kullanılır.
            alternatif durumlar için ELSE IF kullanılır.
            Kontrol dışında kalan durumlar için ise ELSE(KOŞUL VERİLMEZ.) kullanılır.

             */



            #region Kullanıcıdan bir sayı alınız. Alınan sayının pozitif mi negatif mi olduğunu ekran yazdırınız.
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            ////Eğer sayi>0 ise ekrana "pozitif" yaz.
            ////Değilse ekrana "negatif" yaz.

            //if (sayi > 0) //True olması durumunda içindeki kodlar çalışır.
            //{
            //    Console.WriteLine("Pozitif");
            //}
            //else if (sayi == 0)
            //{
            //    Console.WriteLine("Sıfır");
            //}
            //else
            //{
            //    Console.WriteLine("Negatif");
            //}


            // Kullanıcıdan haftanın kaçıncı gününde olduğumuzu öğrenip gün adını ekrana yazdırınız

            //Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta 7 günden oluşur. 1-7 aralığında giriniz");
            //}

            #region 2.Yol
            //Console.WriteLine("Haftanın gününü yazınız?"); //pazartesi
            //string gun = Console.ReadLine().ToLower(); // .ToLower(); string data küçük harfe çevrilir.
            //                                           // .ToUpper(); string data BÜYÜK harfe çevrilir. 

            //if (gun == "pazartesi")
            //{
            //    Console.WriteLine("Birinci gün");
            //}
            //else if (gun == "salı")
            //{
            //    Console.WriteLine("İkinci gün");
            //}
            //else if (gun == "çarşamba")
            //{
            //    Console.WriteLine("Üçüncü gün");
            //}
            //else if (gun == "perşembe")
            //{
            //    Console.WriteLine("Dördüncü gün");
            //}
            //else if (gun == "cuma")
            //{
            //    Console.WriteLine("Beşinci gün");
            //}
            //else if (gun == "cumartesi")
            //{
            //    Console.WriteLine("Altıncı gün");
            //}
            //else if (gun == "pazar")
            //{
            //    Console.WriteLine("Yedinci gün");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta 7 günden oluşur.");
            //}
            #endregion

            //Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if (gun< 1 || gun>7)
            //{
            //    Console.WriteLine("Hafta 7 günden oluşur. 1-7 aralığında giriniz");
            //}
            //else if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else
            //{
            //    Console.WriteLine("Pazar");
            //}

            #endregion


            #region kullanıcıdan alınacak yaş değerine göre
            /*  
             0-3 arasında ise bebek
             4-10 arasında çocuk
             11-18 ergen
             19-28 genç
             29-35 orta yaş
             36-45 olgun
             46-55 emekli adayı
             56 ve üstü ise emekliliğin tadını çıkarın
             */



            //Console.WriteLine("Yaş giriniz:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //if (yas >= 0 && yas < 4) // yas=350
            //{
            //    Console.WriteLine("bebek");
            //}
            //else if (yas > 3 && yas < 11)
            //{
            //    Console.WriteLine("çocuk");
            //}
            //else if (yas > 10 && yas < 19)
            //{
            //    Console.WriteLine("ergen");
            //}
            //else if (yas > 18 && yas < 29)
            //{
            //    Console.WriteLine("Genç");
            //}
            //else if (yas > 28 && yas < 36)
            //{
            //    Console.WriteLine("orta yaş");
            //}
            //else if (yas > 35 && yas < 46)
            //{
            //    Console.WriteLine("olgun");
            //}
            //else if (yas > 45 && yas < 56)
            //{
            //    Console.WriteLine("Emekli adayı");
            //}
            //else if (yas > 55 && yas < 150)
            //{
            //    Console.WriteLine("Emekli");
            //}
            //else
            //{
            //    Console.WriteLine("yaş aralığı hatalı");
            //}



            //Console.WriteLine("Yaş giriniz:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //if (yas >= 0 && yas < 4) //yas=4
            //{
            //    Console.WriteLine("bebek");
            //}
            //else if (yas < 11)
            //{
            //    Console.WriteLine("çocuk");
            //}
            //else if (yas < 19)
            //{
            //    Console.WriteLine("ergen");
            //}
            //else if (yas < 29)
            //{
            //    Console.WriteLine("Genç");
            //}
            //else if (yas < 36)
            //{
            //    Console.WriteLine("orta yaş");
            //}
            //else if (yas < 46)
            //{
            //    Console.WriteLine("olgun");
            //}
            //else if (yas < 56)
            //{
            //    Console.WriteLine("Emekli adayı");
            //}
            //else if (yas < 150)
            //{
            //    Console.WriteLine("Emekli");
            //}
            //else
            //{
            //    Console.WriteLine("yaş aralığı hatalı");
            //}
            #endregion


            #region Öğrenciden
            // Öğrenciden vize ve final adlarında 2 not alınız. Alınan bu notların ortalamasına
            // vize %40 finali %60 alın
            // 50 sınır geçti kaldı yazdırın 


            //Console.WriteLine("Vize:");
            //double vize = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Final:");
            //double final = Convert.ToDouble(Console.ReadLine());

            //if (vize >= 0 && vize <= 100 && final >= 0 && final <= 100)
            //{
            //    //double ort = (vize * 40) / 100 + (final * 60) / 100;
            //    double ort = vize * 0.4 + final * 0.6;

            //    if (ort >= 50)
            //        Console.WriteLine("Geçti");
            //    else
            //    {
            //        Console.WriteLine("Kaldı");
            //    }
            //}

            //else
            //{
            //    Console.WriteLine("Vize Final Not aralığı hatalı!!!");
            //}


            //Console.WriteLine("Vize:");
            //double vize = Convert.ToDouble(Console.ReadLine());

            //if (vize >= 0 && vize <= 100)
            //{
            //    Console.WriteLine("Final:");
            //    double final = Convert.ToDouble(Console.ReadLine());

            //    if (final >= 0 && final <= 100)
            //    {
            //        double ort = vize * 0.4 + final * 0.6;

            //        if (ort >= 50)
            //            Console.WriteLine("Geçti");
            //        else
            //        {
            //            Console.WriteLine("Kaldı");
            //        }
            //    }

            //    else
            //    {
            //        Console.WriteLine("Final Not aralığı hatalı!!!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Vize Not aralığı hatalı!!!");
            //}




            // **** GOTO KOMUTU ****

            //DON:
            //    Console.WriteLine("Vize:");
            //    double vize = Convert.ToDouble(Console.ReadLine());

            //    if (vize >= 0 && vize <= 100)
            //    {
            //        Console.WriteLine("Not Doğru");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not hatalı!!!");
            //        goto DON;
            //    }




            #endregion


            #region kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 2500 tl
            //geçerse ucuz ürüne  %25 indirim uygulayınız

            //Console.WriteLine("1.ürün fiyatı:");
            //double f1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2.ürün fiyatı:");
            //double f2 = Convert.ToDouble(Console.ReadLine());

            //if ((f1 + f2) > 2500)
            //{
            //    if (f1 > f2)
            //    {
            //        f2 = f2 * 0.75;
            //    }
            //    else
            //    {
            //        f1 = f1 * 0.75;
            //    }

            //}

            //Console.WriteLine("Toplam Ödeme:" + (f1 + f2));

            #endregion


            #region Kullanıcıdan 4 adet sayı alacaksınız ve bu sayılardan 2'nin katı olanları toplayınız.

            //Console.WriteLine("1. Sayı:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. Sayı:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3. Sayı:");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("4. Sayı:");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //if (sayi1 % 2 == 0) //4
            //{
            //    toplam = toplam + sayi1;  //4
            //}
            //if (sayi2 % 2 == 0) //6
            //{
            //    toplam = toplam + sayi2; //10
            //}
            //if (sayi3 % 2 == 0)//7
            //{
            //    toplam = toplam + sayi3;
            //}
            //if (sayi4 % 2 == 0)//2
            //{
            //    toplam = toplam + sayi4;
            //}

            //Console.WriteLine("Toplam=" + toplam);
            #endregion


            #region  kullanıcıdan aylık gelirini isteyin. 
            // Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
            // 40000 ve altında ise %9 vergi kesimi yapılarak 
            // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteriniz

            Console.WriteLine("Aylık Gelir:");
            double gelir = Convert.ToDouble(Console.ReadLine());

            if (gelir > 40000)
            {
                gelir = gelir * 0.88; // gelir*=0.88
            }
            else
            {
                gelir = gelir * 0.91;
            }
            Console.WriteLine("Gelir:" + gelir);


            #endregion



            Console.ReadLine();
        }
    }
}

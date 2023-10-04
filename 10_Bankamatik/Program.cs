using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisteme Hoşgeldiniz");
            Console.WriteLine("Kartlı İşlem için 1 Kartsız işlem için 2 ye basınız");
            int işleminitial = Convert.ToInt32(Console.ReadLine());
            int Money = 2500;

            if (işleminitial == 1)
            {

                int guess = 3;
                while (guess > 0)
                {
                    Console.WriteLine("Lütfen şifrenizi giriniz");
                    string şifre = Console.ReadLine();
                    if (şifre == "ab18")
                    {
                        Console.WriteLine("Ana Menüye hoşgeldiniz");
                        goto ANAMEN;
                    }
                    else
                    {
                        Console.WriteLine("Lürfen tekrar deneyiniz");
                        guess--;
                    }
                }

            }
            else if (işleminitial == 2)
            {

            }
            else
            {
                Console.WriteLine("hatalı işlem sistemi tekrar çalıştırın");
            }



        FİN:
            Console.WriteLine("Ana Menü        9\r\n             Çıkmak için     0");
            int cho5 = Convert.ToInt32(Console.ReadLine());
            if (cho5 == 0)
            {
                Console.WriteLine("You have finish the program");
                return;
            }
            else
            {
                goto ANAMEN;
            }



        ANAMEN:
            Console.WriteLine("*******************Ana Menü \r\n             Para Çekmek için    1\r\n             Para yatırmak için  2\r\n             Para Transferleri   3\r\n             Eğitim Ödemeleri    4\r\n             Ödemeler            5\r\n             Bilgi Güncelleme    6");
            int cho = Convert.ToInt32(Console.ReadLine());
            int cho2 = 0;
            if (cho == 1)
            {

                Console.WriteLine("İstediğiniz bakiyeyi giriniz");
                int bakiye = Convert.ToInt32(Console.ReadLine());
                if (bakiye > Money)
                {
                    Console.WriteLine("Yeterli Bakiyeniz bulunmamakta");
                    goto FİN;
                }
                else
                {
                    Console.WriteLine("İşleminiz gerçekleştiriliyor");
                    Money = Money - bakiye;
                    Console.WriteLine("Bakiyeniz: " + Money);
                    goto FİN;


                }
            }
            if (cho == 2)
            {
                Console.WriteLine("Para yatımak istediğiniz hesabı seçin");
                Console.WriteLine("Kredi Kartına   1\r\n             Kendi Hesabınıza yatırmak için  2\r\n             Ana Menü        9\r\n             Çıkmak için     0");
                cho2 = Convert.ToInt32(Console.ReadLine());
                if (cho2 == 9)
                {
                    goto ANAMEN;
                }
                else if (cho2 == 1)
                {
                    int digicount = 0;
                    while (digicount != 12)
                    {
                        Console.WriteLine("Kredi Kartı Numaranızı giriniz");
                        int num = Convert.ToInt32(Console.ReadLine());
                        int digitCount = num.ToString().Length;
                    }
                    Console.WriteLine("Kartınız Geçerli");
                    int bakiye = Convert.ToInt32(Console.ReadLine());
                    if (bakiye <= Money)
                    {
                        Console.WriteLine("İşleminiz gerçekleştiriliyor");
                        Money = Money - bakiye;
                        Console.WriteLine("Bakiyeniz: " + Money);
                        Console.WriteLine("Yatırılan Tutar: " + bakiye);
                        Console.WriteLine("İşlem Tamamlandı");

                    }
                    else
                    {
                        Console.WriteLine("Yeterli Bakiyeniz bulunmamakta");
                        goto FİN;
                    }

                }
                else if (cho2 == 2)
                {

                }
                else
                {
                    goto FİN;
                }
                }

            

            }
        }
    } 

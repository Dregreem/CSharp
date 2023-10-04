using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ODEV
{
    internal class Program
    {
        static void Main(string[] args)
        {  /*
            * ÖDEV:
             kullanıcıdan alınan cinsiyet bilgisine göre
             ==> ERKEK ise
                yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, 
                yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
             ==> KADIN ise
                yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 4500 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 4500 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
             ==> cinsiyet bilgisi switch-case ile sorgulanacak
             */

            Console.WriteLine("Cinsiyetiniz(E/K):");
            char cinsiyet = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (cinsiyet)
            {
                case 'E':                    
                    Console.WriteLine("Yaş:");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    if (yas > 59)
                    {
                        Console.WriteLine("Maaş:");
                        double maas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Emekli ikramiyeniz:"+(maas*10));
                    }
                    else
                    {
                        Console.WriteLine("Prim günü:");
                        int prim = Convert.ToInt32(Console.ReadLine());

                        if (prim >= 6000)
                        {
                            Console.WriteLine("Maaş:");
                            double maas = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Emekli ikramiyeniz:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik hayal çalışmaya devam..");
                        }

                    }


                    break;
                case 'K':
                    Console.WriteLine("Yaş:");
                    int yas1 = Convert.ToInt32(Console.ReadLine());
                    if (yas1 > 57)
                    {
                        Console.WriteLine("Maaş:");
                        double maas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Emekli ikramiyeniz:" + (maas * 10));
                    }
                    else
                    {
                        Console.WriteLine("Prim günü:");
                        int prim = Convert.ToInt32(Console.ReadLine());

                        if (prim >= 4500)
                        {
                            Console.WriteLine("Maaş:");
                            double maas = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Emekli ikramiyeniz:" + (maas * 15));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik hayal çalışmaya devam..");
                        }

                    }

                    break;
                default:
                    Console.WriteLine("Cinsiyet bilgisi hatalı!!!");
                    break;
            }

            Console.ReadLine();
        }
    }
}

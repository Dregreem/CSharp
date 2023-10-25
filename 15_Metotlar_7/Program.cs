using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Metotlar_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kendisine gönderilen int tipindeki dizinin içindeki tek sayıları toplayarak ekrana yazdıran method.

            int[] sayilar = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };

            TekYaz(sayilar);


            Console.WriteLine(TekYaz2(sayilar));

            Console.ReadLine();
        }

        static void TekYaz(int[] dizi)
        {
            int toplam = 0;
            foreach (int item in dizi)
            {
                if (item % 2 == 1)
                    toplam += item;
            }
            Console.WriteLine(toplam);
        }

        static int TekYaz2(int[] dizi)
        {
            int toplam = 0;
            foreach (int item in dizi)
            {
                if (item % 2 == 1)
                    toplam += item;
            }
            return toplam;
        }
    }
}

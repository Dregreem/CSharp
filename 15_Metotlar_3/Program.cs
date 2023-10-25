using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Metotlar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toplama();

            //ToplamaParametreli(12,13);
            Console.WriteLine("1.Sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("+,-,*,/ işleminizi seçiniz:");
            string islem = Console.ReadLine();

            if (islem == "+")
                Toplama(sayi1, sayi2);
            else if (islem == "-")
                Cikarma(sayi1, sayi2);
            else if (islem == "*")
                Carpma(sayi1, sayi2);
            else if (islem == "-/")
                Bolme(sayi1, sayi2);

            Console.ReadLine();

        }

        //******* PARAMETRESİZ METOT *********
        public static void Toplam()
        {
            Console.WriteLine("1.Sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi2 + sayi1);
        }
        //******* PARAMETRELİ METOT *********
        public static void Toplama(int s1,int s2)
        {
            Console.WriteLine(s1 + s2);
        }
        public static void Cikarma(int s1, int s2)
        {
            Console.WriteLine(s1 - s2);
        }
        public static void Carpma(int s1, int s2)
        {
            Console.WriteLine(s1 * s2);
        }
        public static void Bolme(int s1, int s2)
        {
            Console.WriteLine(s1 / s2);
        }
    }
}

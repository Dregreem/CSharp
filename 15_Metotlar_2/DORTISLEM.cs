using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Metotlar_2
{
    internal class DORTISLEM
    {
        internal static void Toplama()
        {
            Console.WriteLine("1.Sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi2 + sayi1);
        }
        internal static void Cikarma()
        {
            Console.WriteLine("1.Sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi1 - sayi2);
        }
        internal static void Carpma()
        {
            Console.WriteLine("1.Sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi1 * sayi2);
        }
        internal static void Bolme()
        {
            Console.WriteLine("1.Sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi1 / sayi2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Metotlar_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcnın girmiş oluduğu iki vize bir final notunun oratalamasını geri döndüren ortalamaya methodu ve ort göre geçme notu yazdıran programı kodlayınız.

            //ortalama = vize%30  final%40

            double ortalama = Ortalama();
            if (ortalama > 50)
            {
                Console.WriteLine("Geçti,"+ortalama);
            }
            else
            {
                Console.WriteLine("Kaldı,"+ortalama);
            }

            Console.ReadLine();
        }

        static double Ortalama()
        {
            Console.WriteLine("1.Vize:");
            double vize1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Vize:");
            double vize2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final:");
            double final = Convert.ToDouble(Console.ReadLine());

            double ort= vize1 * 0.3 + vize2 * 0.3 + final * 0.4;
            return ort;

        }
    }
}

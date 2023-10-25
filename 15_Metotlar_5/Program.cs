using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Metotlar_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot 
            //ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız

            double odeme=Indirim2();

            Console.WriteLine("Ödemeniz:"+odeme);
            Console.ReadLine();
        }

        static double Indirim2()
        {
            Console.WriteLine("1.Ürün:");
            double f1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün:");
            double f2 = Convert.ToDouble(Console.ReadLine());

            if (f1 > f2)
            {
                f1 = f1 * 0.7;
            }
            else
            {
                f2 = f2 * 0.7;
            }

            Console.WriteLine("3.ürün ister misiniz?(E/H)");
            string cevap = Console.ReadLine().ToLower();

            if (cevap == "e")
            {
                double fiyat3 = Indirim3();

                return f1 + f2 + fiyat3;
            }
            else
            {
                return f1 + f2;
            }

        }

        static double Indirim3()
        {
            Console.WriteLine("3.Ürün:");
            double f3 = Convert.ToDouble(Console.ReadLine());

            return f3 / 2;
        }

    }
}

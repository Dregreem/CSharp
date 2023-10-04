using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Tip_Dönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan iki sayıyı toplama işlemi

            //Console.WriteLine("1.sayı:");
            //string s1 = Console.ReadLine();
            //int sayi1 = Convert.ToInt32(s1);

            //Console.WriteLine("2.sayı:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine(sayi1+sayi2);


            //Kullanıcıdan 2 yaş bilgisini alınız ve ekrana toplamlarını yazdırınız.
            //Console.WriteLine("1.yaş:");
            //int yas1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.yaş:");
            //int yas2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Yaşlar Toplamı:" + (yas1 + yas2));


            //int toplam = yas1 + yas2;

            //Console.WriteLine("toplam:"+toplam);


            // BOXING

            double sayi = 5125312635162;

            int sayi2 = (int)sayi;

            Console.WriteLine(sayi2);

            //int s = 56766878;
            //double a = s;



            // INTEGER TO STRING

            //int a = 5;
            //string b = a.ToString();


            Console.ReadLine();
        }
    }
}

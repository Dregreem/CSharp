using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DON:
            //    try
            //    {
            //        Console.WriteLine("Sayı giriniz:");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Bölen giriniz:");
            //        int bolen = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine(sayi / bolen);
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("sayı RAKAMLARDAN oluşur.");
            //        goto DON;
            //    }

            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("Sıfıra Bölme HATASI!!!");
            //        goto DON;
            //    }




            // İki kardeşin yaşarını alın ve toplayarak ekrana yazdırınız.
            //** hataları önleyin...

            sbyte yas1, yas2; //neden sbyte

            DON:
            try
            {
                Console.WriteLine("1.yaş:");
                yas1 = Convert.ToSByte(Console.ReadLine()); // Max 2 basamak tutar.               
            }
            catch (FormatException)
            {
                Console.WriteLine("yaş bilgisi RAKAM ile girilecek.");
                goto DON;
            }

            catch (OverflowException)
            {
                Console.WriteLine("Yaş bilgisi uzun girildi");
                goto DON;
            }


            //2.Yaş kontrolü
            BASLA:
            try
            {
                Console.WriteLine("2.yaş:");
                yas2 = Convert.ToSByte(Console.ReadLine());

                Console.WriteLine("Yaş Toplamı:"+(yas1+yas2));
            }
            catch (FormatException)
            {
                Console.WriteLine("yaş bilgisi RAKAM ile girilecek.");
                goto BASLA;
            }

            catch (OverflowException)
            {
                Console.WriteLine("Yaş bilgisi uzun girildi");
                goto BASLA;
            }



            Console.ReadLine();
        }
    }
}

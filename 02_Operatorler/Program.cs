using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ***** OPERATORLER *****
          **** Aritmetik Operatörler(+,-,*,/,%)
          

            //int s1 = 13;
            //int s2 = 2;

            //int sonuc = s1 + s2;
            //int sonuc2 = s1 - s2;
            //int sonuc3 = s1 * s2;
            //int sonuc4 = s1 / s2;
            //int sonuc5 = s1 % s2; // Mod alma 10%3 => 1 kalanını verir.

            //Console.WriteLine(sonuc5);




            //int s1 = 12;
            //double s2 = 2.5;

            //double sonuc = s1 - s2;
            //Console.WriteLine(sonuc);




            //double s1 = 12.0;
            //double s2 = 2.0;

            //double sonuc = s1 / s2;
            //Console.WriteLine(sonuc);

            ****Atama Operatörler(=)
              int sayi = 5;

             **** İşlemli Atama
            int sayi = 12;
            
            sayi += 8; //sayi = sayi + 8;
            sayi -= 8; //sayi = sayi - 8;
            sayi *= 8; //sayi = sayi * 8;
            sayi /= 8; //sayi = sayi / 8;


             *** Artırma Operatörü ( ++ --)
            int sayi = 12;

            sayi = sayi + 1; // sayi++;
            sayi = sayi - 1; // sayi--;
         
            */
            //int a = 5;
            ////int b = a++;
            //int b = ++a;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            /*
            **KARŞILAŞTIRMA OPERATÖRLER * *

             <,>,<=,>=

             == Eşitler mi ?

             != Eşit Değiller mi?
 */
            //int a = 5;
            //int b = 6;

            //Console.WriteLine(a>b);
            //Console.WriteLine(a<b);
            //Console.WriteLine(a>=b);
            //Console.WriteLine(a<=b);
            //Console.WriteLine(a==b);
            //Console.WriteLine(a!=b);
            /*

          *** MANTIKSAL OPERATÖRLER(AND, OR, NOT) ***
          *
           AND Operatörü: birden fazla karşılaştırma durumunda sonucun TRUE olması için her durumun doğru olması gerekiyor ise AND && kullanılır.


          1.durum  && 2.durum = sonuc
             F          F         F
             F          T         F
             T          F         F
             T          T         T

          string username = "altanemre";
          string password = "123";
*/

            //int s1 = 5;

            //Console.WriteLine(s1>0 && s1<10);

            /*

            Console.WriteLine("Kullanıcı adınız:");
            string kullaniciadi = Console.ReadLine();

            Console.WriteLine("Şifreniz:");
            string sifre = Console.ReadLine();

            bool sonuc = username == kullaniciadi && password==sifre;
            Console.WriteLine(sonuc);




             OR Operatörü: birden fazla karşılaştırma durumunda sonucun TRUE olması için herhangi bir durumun doğru olması gerekiyor ise OR || kullanılır.
            
            
            1.durum  || 2.durum = sonuc
               F          F         F
               F          T         T
               T          F         T
               T          T         T

            */
            //string username = "altanemre";
            //string email = "altanemre@gmail.com";

            //Console.WriteLine(username=="altanemre" || email=="altanemre@gmail.com");


            /*
            string username = "altanemre";
            string email = "altanemre@gmail.com";
            string password = "123";


            Console.WriteLine("Kullanıcıadı/Email:");
            string kullanici = Console.ReadLine();

            Console.WriteLine("Şifreniz:");
            string sifre = Console.ReadLine();

            bool sonuc = (username == kullanici || email==kullanici ) && password==sifre;
            Console.WriteLine(sonuc);


            ** NOT - DEĞİL (!)
            * True  -> False 
            * False -> True

              bool s = 5 == 4;
            Console.WriteLine(s);
            Console.WriteLine(!s);


            ** KIYAS OPERATÖRÜ ? **
            */
            int yas = 16;

            //string sonuc = yas > 17 ? "genç" : "çocuk";
            //int sonuc = yas > 17 ? 1 : 0;

            //Console.WriteLine(sonuc);
            



            Console.ReadLine();
        }
    }
}

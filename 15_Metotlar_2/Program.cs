using System;

namespace _15_Metotlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            *****DEĞER DÖNDÜRMEYEN METOTLAR(void) *****
            Metodun yapmış olduğu işlemin sonucunu çağrıldığı yere geri getirmemesi anlamına gelir.
            Metotlar parametre alan ve almayan olmak üzere 2 farklı şekilde tanımlanabilir.

            **Metot Tanımlama**

            erişimbelirteci: public: Bütün solution tarafında erişibilir.,
                             private,protected,internal
            void : metotun değer döndürmeyeceğini belirtir.
            static: Bir yapının direk erişilebilir(kullanılabilir) olduğunu belirtir. static bir tanımın içinde yine static yapı kullanılması zorunludur.

            public void Toplama()
        {
            //Metot İşlem komutları
        }             

            ** Metot Çağırma **
            metotName();
            */

            Console.WriteLine("+,-,*,/ işleminizi seçiniz:");
            string islem = Console.ReadLine();

            if (islem == "+") { DORTISLEM.Toplama(); }
            else if (islem == "-") { DORTISLEM.Cikarma(); }
            else if (islem == "*") { DORTISLEM.Carpma(); }
            else if (islem == "/") { DORTISLEM.Bolme(); }

            Console.ReadLine();

        }

      
    }
}

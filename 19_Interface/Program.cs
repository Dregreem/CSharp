using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanım
            /*
          INTERFACE(ARAYUZ) NEDİR?

          * Bir sınıftan kalıtımla almak güçlü bir mekanizmadır, asıl kalıtımın gücü bir arayüzden kalıtımla almasında yatar. 
          Bir sınıf kalıtımla sadece bir sınıftan türetilebilir ancak bu kısıtlama kalıtımla arayüzden türetme söz konusu olduğunda ortadan kalkar
          yani bir sınıf birden çok arayüzden kalıtımla türeyebilir. 

          !!!!Arayüzler sınıflar gibi kod ve veri içermez,sadece tanım içerir. 
          !!!!Aslında soyut sınıflar arabirimlere benzerler ancak soyut sınıflar kod ve veri içerebildikleri için arayüzlerden ayrılır. 
          Ancak çoğu zaman arayüzler soyut sınıflarla beraber kullanılarak güçlü uygulamalar geliştirilir. 

          INTERFACE NEDEN KULLANILIR, VE FAYDALARI NELERDİR
          * Arayüz uygulamasının kullanım amacı büyük çaplı ve çok sayıda geliştiricinin çalıştığı projelerde belirli kurallar tanımlayıp bu kurallar yardımı
           ile sınıfların hangi özellikleri barındırması gerektiğini belirterek geliştiricilere yol göstermektedir. 
           Küçük çaplı ve bireysel olarak geliştirilen projelerde geliştirici hangi sınıfta hangi metotları kullanması 
           gerektiğini kendisi belirlediği için arayüz kullanmak gerekmemektedir. Büyük projelerde ise yazılım mimarı altında çalışan 
           geliştiricilere !!!!yol göstermek için arayüz tanımlayabilir.

          Arayüz tanımlamak için class ya da struct sözcükleri yerine “interface” (interfeys) sözcüğü kullanılır. 
          Arayüz içinde metotları aynen bir sınıf (class) ya da yapı (struct) içerisinde olduğu gibi bildirilir.
          !!!!Farklı olarak herhangi bir erişim belirteci (public) , private  ya da protected kullanılmaz ve metot gövdesi noktalı virgülle ayrılır. 
          Örneğin,

          !!!!Arayüz isminin başında I harfi kullanıldığına dikkat edilmelidir. 
          Bu kullanılan sınıfın bir arayüz olduğunu anlamamıza yarayan bir isim kullanma tekniğidir. 
          Bu sayede, sınıfların kalıtımsal olarak aldığı elemanların arayüz olup olmadığı daha kolayca anlaşılabilir.ör: IArayuz


          Bir arayüzün hiçbir zaman bir uygulama (tanımlama dışında deyim ve ifadeler)
          içermeyeceği unutulmamalıdır. Bu durumun doğal sonucu olarak aşağıdaki kısıtlamalar
          ortaya çıkar:

           -Bir arayüz için herhangi bir alan (field) tanımlanamaz (statik olsa bile). Çünkü
           alan bir sınıf ya da bir yapının uygulama detayıdır.

           -Bir arayüz içinde kurucu (constructor) tanımlamaya da izin verilmez. Bu da
           uygulama detayı kabul edilir.

           -Bir arayüz içinde bir yıkıcı (destructor) da tanımlanamaz.

           -Bir metot için bir erişim belirteci de belirtilemez. Çünkü bir arayüzdeki tüm
           metotlar dolaylı olarak ortaktır (public).

           -Bir arayüz içerisinde hiçbir türü yuvarlanamaz. Bir başka deyişle arayüzler
           sınıf, yapı ya da numaralandırma içeremez.

           !!!!-Bir arayüzü bir sınıf ya da yapıdan kalıtımla alamazsınız yani türetemezsiniz.

           -Arayüzler ,arayüzlerden türeyebilir. Yapılar ve sınıflar uygulama içerdikleri için
           bu kısıtlama olmasaydı üstteki bazı kısıtlamalar ihlal edilirdi.



          Bir Arayüz Uygulamak

          Bir arayüzü uygulamak için arayüzden kalıtımla alan ve arayüzde belirtilen tüm  yöntemleri sağlayan bir sınıf ya da yapı bildirilir. Öğrenme faaliyeti -1 içinde temel sınıf olan insan hatırlanmalıdır. Bu sınıfın içerisinde Buyu adında bir metot kullanılmıştı. Insan sınıfı IInsan adında bir arayüzü uyguluyor olsun. Bu arayüz de aşağıdaki gibi tanımlanmış olsun. */

            /*INTERFACE KULLANIMININ IMPLEMENTASYON KURALLARI*/

            /*Bir arayüzü uygulandığında her metodun kendine uygun bir arayüz metoduyla tam
              olarak eşleşmesi garantiye alınmalıdır.

             Metot adları ve dönüş türleri kesin olarak eşleşmelidir.
             Parametreler (ref ve out anahtar sözcükleri dahil) tam olarak eşleşmelidir.
             Arayüz tanımı ve arayüz uygulaması arasında bir fark varsa uygulama
            derlenmez.
             Arayüzden türetilen sınıf içerisinde oluşturulan arayüze ait metotlar mutlaka
            public olarak tanımlanmalıdır*/


            /*BİR SINIFIN HEM SINIFTAN HEMDE INTERFACE DEN MIRAS ALMASI*/

            /* Bir sınıf hem bir sınıftan devralıyor hem de bir arayüzü uyguluyorsa aşağıdaki gibi
             kodlanır: C# dilinde, bir sınıfın hem bir başka sınıftan (class) hem de bir arayüzden (interface) 
            miras alması mümkündür. Bu durum, bir sınıfın başka bir sınıfın özelliklerini ve davranışlarını kalıtım alırken aynı 
            zamanda bir arayüzün de belirli kontratları sağlamasını sağlar.*/


            /*
             using System;

                // Bir arayüz tanımı
                interface IDrawable
                {
                    void Draw();
                }

                // Bir sınıf tanımı
                class Shape
                {
                    public void Display()
                    {
                        Console.WriteLine("Displaying shape");
                    }
                }

                // İki farklı miras alma örneği
                class Circle : Shape, IDrawable
                {
                    public void Draw()
                    {
                        Console.WriteLine("Drawing circle");
                    }
                }

                class Program
                {
                    static void Main()
                    {
                        // Circle sınıfından bir nesne oluşturma
                        Circle circle = new Circle();

                        // Shape sınıfından miras aldığı metodun kullanımı
                        circle.Display();

                        // IDrawable arayüzünden miras aldığı metodun kullanımı
                        circle.Draw();
                    }
                }

             
             
             */


            #endregion

            //IInsan insan = new IInsan();

            Ogrenci ogr = new Ogrenci();
            
        }
    }

    interface IInsan
    {
        int Id { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }


        void Yaz();

    }

   class Insan
    {
        public int Id { get; set; }
        public string Ad = "Ahmet";
        public string Soyad { get; set; }

    }
    interface IVatandas
    {
        int TC { get; set; }
    }


    class Ogrenci : Insan, IVatandas,IInsan
    {
        public int TC { get; set; }
        string IInsan.Ad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Yaz()
        {
            throw new NotImplementedException();
        }
    }
    // abstractta sadece bizim yazdıklarımızı almalı ama interface kullanımında tüm değişkenleri ve fonksiyonların tanımlanması gerekiyor 
    //abstract sadece 1 tane alınabilir ama interfacete birden fazla da alınabilir
    //
}

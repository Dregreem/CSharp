using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 kişilik bir ailedeki üyeleri isimleri
           
                //* Değişken bir data tutabilir.
            //string isim1 = "Altan";
            //string isim2 = "Ceylan";
            //string isim3 = "Uras";
            //string isim4 = "Kıvanç";
            //string isim5 = "Kerem";

            //************** ARRAY(DİZİ) *****************

            // Diziler veritipleri ve uzunlukları tanımlanan koleksiyon yapılarıdır. Diziler kendileri verilen değerleri INDEX adı verilen ve 0 dan başlayarak 1'er 1'er artan numaralandırma yapısıyla tutarlar.

            // Boş Dizi Tanımı
            //string[] isimler = new string[10];

            //Dolu Bir Dizi Tanımı
            //string[] isimler = { "Altan", "Ceylan", "Uras", "Kerem", "Kıvanç" };
            //isimler[5] = "Emre"; //dolu dizi tanımında 5 elemanlı boyut verildi. eleman eklenemez.


            // *********** Diziye Eleman Ekleme ************
            //string[] isimler = new string[10];
            //isimler[0] = "Ali";
            //isimler[5] = "Veli";
            //isimler[3] = isim1;

            //isimler[10] = "Mahmut";

            //double[] sayilar = { 12, 14.5, 23.4f };

            //for (int i = 0; i < sayilar.Length; i++) //012
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //int i = 0;
            //while (i < sayilar.Length)
            //{
            //    Console.WriteLine(sayilar[i]);
            //    i++;
            //}

            //object[] karisik = { 12, "Altan", 12.5,34.5f, 35m };


            #region 1.Örnek  
            //ÖRNEK: Kullanıcıdan kaç isim alınacağını öğrenip isimleri alarak bir diziye ekleyiniz ve ekrana yazdırınız.

            //Console.WriteLine("Kaç personelin var?");
            //int boyut = Convert.ToInt32(Console.ReadLine());

            //string[] personeller = new string[boyut];

            //for (int i = 0; i < personeller.Length; i++)
            //{
            //    Console.WriteLine("İsim:");
            //    personeller[i] = Console.ReadLine();
            //}

            //foreach (string item in personeller)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region 2.Örnek

            // Aşağıdaki dizide tanımlı sayılardan çiftleri ayrı tekleri ayrı toplayarak sonucunu ekrana yazdırınız.

            //int[] sayilar = { 11, 22, 33, 44, 55, 66, 77};

            //int tektoplam = 0;
            //int cifttoplam = 0;
            //int teksayac = 0;
            //int ciftsayac = 0;


            #region Foreach
            //foreach (int item in sayilar)
            //{
            //    if (item % 2 == 0)
            //    {
            //        cifttoplam += item;
            //        ciftsayac++;
            //    }

            //    else
            //    {
            //        tektoplam += item;
            //        teksayac++;
            //    }

            //}

            //int[] teksayilar = new int[teksayac];
            //int[] ciftsayilar = new int[ciftsayac];

            //int t = 0;
            //int c = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        ciftsayilar[c] = sayilar[i];
            //        c++;
            //    }
            //    else
            //    {
            //        teksayilar[t] = sayilar[i];
            //        t++;
            //    }
            //}


            #endregion

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //        cifttoplam += sayilar[i];
            //    else
            //        tektoplam += sayilar[i];
            //}

            //Console.WriteLine("Tek Toplam:"+tektoplam);
            //Console.WriteLine("Çift Toplam:"+cifttoplam);


            #endregion


            #region ARRAY SINIFI ÖZELLİKLERİ VE METOTLARI

            #region CLEAR()
            // Verilen dizi içerisinde belirtilen index den başlayarak belirtilen uzunluk kadar data siler.
            //string[] isimler = { "Altan", "Ceylan", "Uras", "Kıvanç", "Kerem" };

            //Array.Clear(isimler, 1, 2);

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}


            //FOREACH DÖNGÜ

            //foreach(var item in karisik)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region COPY()
            //string[] isimler = { "Altan", "Ceylan", "Uras", "Kıvanç", "Kerem" };
            //string[] adlar = new string[10];


            //1.Yol
            //Array.Copy(isimler, adlar, 3);


            //KaynakArray,StartIndex,HedefArray,StartIndex,Length
            //Array.Copy(isimler, 1, adlar, 3, 4);

            //foreach (string item in adlar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region INDEX OF()
            //IndexOf:Verilen dizideki istenilen elemanın ilk görüldüğü indexi

            int[] sayilar = { 11, 22, 11, 33, 44, 11, 55, 66, 11, 77 };

            Console.WriteLine(Array.IndexOf(sayilar, 11));

            int indexNo = Array.IndexOf(sayilar, 11);

            int secondIndex = Array.IndexOf(sayilar, 11, 1);

            Console.WriteLine(indexNo);
            Console.WriteLine(secondIndex);


            Console.WriteLine(Array.IndexOf(sayilar, 44, 0, 4));

            #endregion

            #region LASTINDEX OF
            //LastIndexOf:Verilen dizideki istenilen elemanın son görüldüğü indexi
            //int[] sayilar = { 11, 22, 11, 33, 44, 11, 55, 66, 11, 77 };

            //Console.WriteLine(Array.LastIndexOf(sayilar,11));


            #endregion

            #endregion



            #region ODEVLER

            /*Aşağıdaki Şekilleri for ile ayrı ayrı oluşturunuz. 
             
             *
             **
             ***
             ****
             *****
             
             *****
             ****
             ***
             **
             *
             
             
                *
               ***
              *****
             *******
            *********
             
            
             
             
             

            //adınızın harflerini for döngüsü ile alt alta sıralayın 



            //kullanıcıdan alınacak ürün sayısına göre ürün isimleri istenerek bir diziye atılacak ve sonrasında her bir ürün adı yazılarak karşısında fiyatı istendikten sonra bütün ürünlerin isimleri karşısında fiyatlarını listeleyiniz




            //Aşağıdaki dizideki tekrar eden dataların indexleri ekrana yazdırınız.
            string[] isimler = { "Ali", "Veli", "Ali", "Ahmet", "Mehmet", "Ali", "Zehra", "Fatma", "Ayşe", "Ali" };
             */
            #endregion



            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading;
=======
>>>>>>> ab0eefa35e59cb6256e16d8b32120e03205f6063
using System.Threading.Tasks;

namespace _12_Otomat_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**************************** ÖDEV **********************//
            // Giriş alanında admin girişi yapılırsa ürün ve fiyat bilgileri girilsin
            // Giriş alanında member girişi yapılırsa 
            // dizi ürünler[Kola,bisküvi,çikolata]
            // dizi fiyat[7,3,2]
            // Ürünler ekrana yazdırın. Müşteri ürün adını girerek ürün almak istesin. İstenilen ürün fiyatını ekrana yazdırarak kullanıcıdan para alın ve para üstünü verin
            //  
<<<<<<< HEAD

            #region OTOMAT
            /*
               string[] urunler = new string[10];
            urunler[0] = "Bisküvi";
            urunler[1] = "Kola";
            urunler[2] = "Çikolata";
            urunler[3] = "Gofret";
            urunler[4] = "Kek";

            double[] fiyat = new double[10];
            fiyat[0] = 5;
            fiyat[1] = 5.75;
            fiyat[2] = 2.35;
            fiyat[3] = 4.25;
            fiyat[4] = 1.15;

            string admin = "altan";
            string pass = "123";

            Console.WriteLine("OTOMATA HOŞGELDİNİZ...");
            Console.WriteLine("Ürün almak için 1\nTeknik giriş için 2");
            string giris = Console.ReadLine();
            switch (giris)
            {
                case "1":
                    break;
                case "2":
                    int hak = 3;
                    while (hak > 0)
                    {
                        hak--;
                        Console.WriteLine("Kullanıcı adı:");
                        string user = Console.ReadLine();
                        Console.WriteLine("Şifre:");
                        string sfr = Console.ReadLine();
                        if (user == admin && sfr == pass)
                        {
                            Console.WriteLine("Giriş başarılı\n");
                            Console.WriteLine("Ürün Ekleme için 1\nÜrün Çıkarma için 2\nÜrün Güncellemek için 3");
                            string cvp = Console.ReadLine();
                            if (cvp == "1")
                            {
                                while (true)
                                {
                                    int j = 0;
                                    for (int i = 0; i < urunler.Length; i++)
                                    {
                                        if (!string.IsNullOrEmpty(urunler[i]))
                                        {
                                            Console.WriteLine(urunler[i] + ": " + fiyat[i]);
                                            j++;
                                        }
                                    }
                                    Console.WriteLine("\nYeni Ürün Adı:");
                                    urunler[j] = Console.ReadLine();
                                    Console.WriteLine("Yeni Ürün Fiyatı:");
                                    fiyat[j] = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Yeni ürün eklemeye devam edecek misiniz?(E/H)");
                                    string cevap = Console.ReadLine().ToUpper();
                                    if (cevap == "H")
                                    {
                                        Console.WriteLine("Ürün eklemeden çıkılıyor.");
                                        Thread.Sleep(3000);
                                        break;
                                    }
                                }
                            }
                            else if (cvp == "2")
                            {
                                int j = 0;
                                for (int i = 0; i < urunler.Length; i++)
                                {
                                    if (!string.IsNullOrEmpty(urunler[i]))
                                    {
                                        Console.WriteLine(urunler[i] + ": " + fiyat[i]);
                                        j++;
                                    }
                                }
                                Console.WriteLine("Silinecek ürün adını giriniz:");
                                string urunadi = Console.ReadLine();
                                if (urunler.Contains(urunadi))
                                {
                                    int indx = Array.IndexOf(urunler, urunadi);
                                    Array.Clear(urunler, indx, 1); //RemoveAt metodu da kullanılabilir.
                                    Array.Clear(fiyat, indx, 1);
                                    for (int i = 0; i < urunler.Length; i++)
                                    {
                                        if (!string.IsNullOrEmpty(urunler[i]))
                                        {
                                            Console.WriteLine(urunler[i] + ": " + fiyat[i]);
                                        }
                                    }
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Ürün Adı Hatalı!!!");
                                }

                            }
                            else if (cvp == "3")
                            {
                                int j = 0;
                                for (int i = 0; i < urunler.Length; i++)
                                {
                                    if (!string.IsNullOrEmpty(urunler[i]))
                                    {
                                        Console.WriteLine(j + "-" + urunler[i] + ": " + fiyat[i]);
                                        j++;
                                    }
                                }
                                Console.WriteLine("Güncellenecek ürün numarasını giriniz");
                                int no = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ürün adını giriniz");
                                string urunadi = Console.ReadLine();
                                Console.WriteLine("ürün fiyatını giriniz");
                                double fyt = Convert.ToDouble(Console.ReadLine());
                                urunler[no] = urunadi;
                                fiyat[no] = fyt;
                                for (int i = 0; i < urunler.Length; i++)
                                {
                                    if (!string.IsNullOrEmpty(urunler[i]))
                                    {
                                        Console.WriteLine(urunler[i] + ": " + fiyat[i]);
                                    }
                                }
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim!!");
                                break;
                            }


                            break;


                        }
                        else
                        {
                            Console.WriteLine("HATALI GİRİŞ");
                        }
                    }

                    Console.WriteLine("Hakkınız bitti");
                    break;
             
             */
            #endregion

            //string[] urunler = new string[10];
            string[] urunler = new string[5];
            urunler[0] = "Bisküvi";
            urunler[1] = "Kola";
            urunler[2] = "Çikolata";
            urunler[3] = "Gofret";
            urunler[4] = "Kek";

            double[] fiyatlar = new double[5];
            fiyatlar[0] = 5;
            fiyatlar[1] = 5.75;
            fiyatlar[2] = 2.35;
            fiyatlar[3] = 4.25;
            fiyatlar[4] = 1.15;

            string pass = "123";
            while (true)
            {
                Console.WriteLine("1-Yönetici\n2-Müşteri\n\tSeçiminiz:");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Şifre:");
                    string sifre = Console.ReadLine();

                    if (sifre == pass)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Silme\n4-Çıkış\nSeçiminiz:");
                                int menu = Convert.ToInt32(Console.ReadLine());

                                if (menu == 1)
                                {
                                    if (urunler.Length < 10)
                                    {
                                        Console.WriteLine("Ürün Adı:");
                                        string urunAd = Console.ReadLine();
                                        Console.WriteLine("Ürün Fiyatı:");
                                        double urunFiyat = Convert.ToDouble(Console.ReadLine());

                                        Array.Resize(ref urunler, urunler.Length + 1);
                                        Array.Resize(ref fiyatlar, urunler.Length + 1);
                                        urunler[urunler.Length - 1] = urunAd;
                                        fiyatlar[fiyatlar.Length - 1] = urunFiyat;


                                        #region 10 Indexli çözüm
                                        //int index = 0;
                                        //for (int i = 0; i < urunler.Length; i++)
                                        //{
                                        //    if (string.IsNullOrEmpty(urunler[i])) //Empty=""; Null=veri atanmamış(string boş hali null'dur)
                                        //    {
                                        //        index = i;
                                        //        break;
                                        //    }
                                        //}

                                        //urunler[index] = urunAd;
                                        //fiyatlar[index] = urunFiyat;

                                        #endregion
                                    }

                                    else
                                    {
                                        Console.WriteLine("Ürün eklenemez. Max. kapasitedeyiz. Ürün sildikten sonra tekrar deneyiniz.");
                                    }
                                }
                                else if (menu == 2) 
                                {
                                    for (int i = 0; i < urunler.Length; i++)
                                    {
                                        Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");                                       
                                    }
                                    Console.WriteLine("Güncelenecek ürün numarası:");
                                    int urunNo = Convert.ToInt32(Console.ReadLine());

                                    if (0 <= urunNo && urunNo < urunler.Length)
                                    {
                                        Console.WriteLine("Ürün Adı:");
                                        string urunAd = Console.ReadLine();
                                        Console.WriteLine("Ürün Fiyatı:");
                                        double urunFiyat = Convert.ToDouble(Console.ReadLine());

                                        urunler[urunNo] = urunAd;
                                        fiyatlar[urunNo] = urunFiyat;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Ürün Numarası!!");
                                    }
                                }
                                else if (menu == 3) 
                                {
                                    for (int i = 0; i < urunler.Length; i++)
                                    {
                                        if (string.IsNullOrEmpty(urunler[i])==false) //if (!string.IsNullOrEmpty(urunler[i]))
                                        {
                                            Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                                        }
                                      
                                    }
                                    Console.WriteLine("Silinecek ürün numarası:");
                                    int urunNo = Convert.ToInt32(Console.ReadLine());

                                    if (0 <= urunNo && urunNo < urunler.Length)
                                    {
                                        Array.Clear(urunler, urunNo, 1);
                                        Array.Clear(fiyatlar, urunNo, 1);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Ürün Numarası!!");
                                    }

                                }
                                else if (menu == 4) { Console.WriteLine("Çıkış Yapıldı."); break; }
                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama!!");
                                }
                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Seçiminizi RAKAM ile giriniz.");
                            }

                        }


                    }
                    else
                    {
                        Console.WriteLine("Hatalı Şifre!!");
                        continue;
                    }


                    //break;

                }
                else if (secim == "2")
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        if (string.IsNullOrEmpty(urunler[i]) == false) //if (!string.IsNullOrEmpty(urunler[i]))
                        {
                            Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                        }

                    }
                    Console.WriteLine("Ürün numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    if (0 <= urunNo && urunNo < urunler.Length)
                    {
                        Console.WriteLine("Para girişi:");
                        double para = Convert.ToDouble(Console.ReadLine());

                        DON:
                        if (para >= fiyatlar[urunNo])
                        {
                            Console.WriteLine("Afiyet Olsun. Para üstü:" + (para - fiyatlar[urunNo]));
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye.\n1-Para Ekle\n2-Para İade");
                            string secimPara = Console.ReadLine();

                           if(secimPara=="1")
                            {
                                Console.WriteLine("Para girişi:");
                                double bakiye = Convert.ToDouble(Console.ReadLine());
                                para += bakiye;
                                goto DON;
                            }
                            else
                            {
                                Console.WriteLine("Paranızı iade bölümün alınız");
                                para = 0;
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Hatalı Ürün Numarası!!");
                    }

                    //break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                    //Thread.Sleep(3000);
                    Console.Clear();
                }
            }

            Console.ReadLine();
=======
>>>>>>> ab0eefa35e59cb6256e16d8b32120e03205f6063
        }
    }
}

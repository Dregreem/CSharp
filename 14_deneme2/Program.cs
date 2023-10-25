using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_deneme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList manavMeyve = new ArrayList() { "elma", "armut", "karpuz", "kavun", "şeftali", "çilek" };
            ArrayList manavSebze = new ArrayList() { "domates", "biber", "patlıcan", "soğan", "havuç", "salatalık" };

            List<string> alınanmeyve = new List<string>();
            List<int> alınanmeyvefiyat = new List<int>();
            List<int> alınansebzefiyat = new List<int>();
            List<string> alınansebze = new List<string>();
            
            while (true)
            {
                Console.WriteLine("Manav mısınız müşteri misiniz? Manav için -1 Müşteri için -2 Çıkış için -3");
                string cho1 = Console.ReadLine();

                if (cho1 == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("Manav sistemine Hoşgeldiniz ");
                        Console.WriteLine("Meyve için M sebze için S yazınız");

                        string cho2 = Console.ReadLine().ToUpper();

                        if (cho2 == "M")
                        {
                            Console.WriteLine("Meyveler: ");
                            foreach (string meyve in manavMeyve)
                            {
                                Console.WriteLine(meyve);
                            }
                            while (true)
                            {
                                Console.WriteLine("Almak istediğiniz ürünü yazın");
                                string seçim = Console.ReadLine().Trim().ToLower();
                                if (manavMeyve.Contains(seçim)&&!alınanmeyve.Contains(seçim))
                                {
                                    
                                    Console.WriteLine("Kaç kilo istiyorsunuz");
                                    int kilo = Convert.ToInt32(Console.ReadLine());
                                    alınanmeyve.Add(seçim);
                                    alınanmeyvefiyat.Add(kilo);
                                    
                                }
                                else if (manavMeyve.Contains(seçim) && alınanmeyve.Contains(seçim))
                                {
                                    Console.WriteLine("Kaç kilo istiyorsunuz");
                                    int kilo = Convert.ToInt32(Console.ReadLine());
                                    int index=alınanmeyve.IndexOf(seçim);
                                    alınanmeyvefiyat[index] += kilo;
                                   
                                }
                                else
                                {
                                    Console.WriteLine("Ürünü bulamadık, tekrar deneyin.");
                                }
                                break;
                            }
                            break;
                        }
                        else if (cho2 == "S")
                        {
                            Console.WriteLine("Sebzeler: ");
                            foreach (string sebze in manavSebze)
                            {
                                Console.WriteLine(sebze);
                            }
                            while (true)
                            {
                                Console.WriteLine("Almak istediğiniz ürünü yazın");
                                string seçim = Console.ReadLine().Trim().ToLower();
                                if (manavSebze.Contains(seçim) && !alınansebze.Contains(seçim))
                                {

                                    Console.WriteLine("Kaç kilo istiyorsunuz");
                                    int kilo = Convert.ToInt32(Console.ReadLine());
                                    alınansebze.Add(seçim);
                                    alınansebzefiyat.Add(kilo);

                                }
                                else if (manavSebze.Contains(seçim) && alınansebze.Contains(seçim))
                                {
                                    Console.WriteLine("Kaç kilo istiyorsunuz");
                                    int kilo = Convert.ToInt32(Console.ReadLine());
                                    int index = alınanmeyve.IndexOf(seçim);
                                    alınansebzefiyat[index] += kilo;

                                }
                                else
                                {
                                    Console.WriteLine("Ürünü bulamadık, tekrar deneyin.");
                                }
                                break;
                            }
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Hatalı seçim yaptınız. Tekrar deneyin.");
                            Console.Clear();
                        }
                    }
                    Console.Clear();

                }
                else if (cho1 == "2")
                {
                    Console.WriteLine("Müşteri sistemine Hoşgeldiniz ");
                    Console.WriteLine("Meyve için M sebze için S yazınız");
                    string cho2 = Console.ReadLine().ToUpper();

                    if (cho2 == "M")
                    {
                        while (true)
                        {
                            Console.WriteLine("Meyveler: ");
                            for (int i = 0; i < alınanmeyve.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". ürün-" + alınanmeyve[i] + "  --" + alınanmeyvefiyat[i]);
                            }
                            Console.WriteLine("Ürün numarasını girin:");
                            int urunNo = int.Parse(Console.ReadLine()) - 1;

                            if (urunNo >= 0 && urunNo < alınanmeyve.Count)
                            {
                                while (true)
                                {
                                    Console.WriteLine("Kaç kilo istiyorsunuz:");
                                    int kilo = Convert.ToInt32(Console.ReadLine());

                                    if (kilo >= 0 && alınanmeyvefiyat[urunNo] >= kilo)
                                    {
                                        alınanmeyvefiyat[urunNo] -= kilo;
                                        Console.WriteLine($"{alınanmeyve[urunNo]} - {kilo} kg alındı.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Geçersiz miktarda kilo girdiniz");
                                    }
                                    Console.WriteLine("Çıkmak için q kalmak için enter yapınız");
                                    string cho3 = Console.ReadLine();
                                    if (cho3 == "q")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Görüşmek üzere");
                                        break; // Sonsuz döngüyü kır
                                    }
                                }
                             break;
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz ürün numarası.");
                            }

                        }

                    }
                    else if (cho2 == "S")
                    {
                        while (true)
                        {
                            Console.WriteLine("Sebzeler: ");
                            for (int i = 0; i < alınansebze.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". ürün-" + alınansebze[i] + "  --" + alınansebzefiyat[i]);
                            }
                            Console.WriteLine("Ürün numarasını girin:");
                            int urunNo = int.Parse(Console.ReadLine()) - 1;

                            if (urunNo >= 0 && urunNo < alınansebze.Count)
                            {
                                while (true)
                                {
                                    Console.WriteLine("Kaç kilo istiyorsunuz:");
                                    int kilo = Convert.ToInt32(Console.ReadLine());

                                    if (kilo >= 0 && alınansebzefiyat[urunNo] >= kilo)
                                    {
                                        alınansebzefiyat[urunNo] -= kilo;
                                        Console.WriteLine($"{alınansebze[urunNo]} - {kilo} kg alındı.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Geçersiz miktarda kilo girdiniz");
                                    }
                                    Console.WriteLine("Çıkmak için q kalmak için enter yapınız");
                                    string cho3 = Console.ReadLine();
                                    if (cho3 == "q")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Görüşmek üzere");
                                        
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz ürün numarası.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim yaptınız. Tekrar deneyin.");
                        Console.Clear();
                    }
                }
                else if (cho1 == "3")
                {
                    Console.WriteLine("BYE byE");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız");
                    Console.Clear();
                }

            }


        }
    }
}
        
    


using System;
using System.Collections;

namespace _14_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList manavMeyve = new ArrayList() { "elma", "armut", "karpuz", "kavun", "şeftali", "çilek" };
            ArrayList manavSebze = new ArrayList() { "domates", "biber", "patlıcan", "soğan", "havuç", "salatalık" };

            ArrayList alınanManavMeyve = new ArrayList();
            ArrayList alınanManavSebze = new ArrayList();

            while (true)
            {
                Console.WriteLine("Manav mısınız müşteri misiniz? Manav için -1 Müşteri için -2 Çıkış için -3");
                string cho1 = Console.ReadLine();
                bool cond = true;
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

                            while (cond)
                            {
                                Console.WriteLine("Almak istediğiniz ürünü yazın");
                                string seçim = Console.ReadLine().Trim().ToLower();
                                if (manavMeyve.Contains(seçim))
                                {
                                    Console.WriteLine("Kaç kilo istiyorsunuz");
                                    int kilo = Convert.ToInt32(Console.ReadLine());
                                    alınanManavMeyve.Add(seçim);
                                    alınanManavMeyve.Add(kilo);
                                    cond=false;
                                }
                                else
                                {
                                    Console.WriteLine("Ürünü bulamadık, tekrar deneyin.");
                                }
                            }
                        }
                        else if (cho2 == "S")
                        {
                            Console.WriteLine("Sebzeler: ");
                            foreach (string sebze in manavSebze)
                            {
                                Console.WriteLine(sebze);
                            }
                            
                            while (cond)
                            {
                                Console.WriteLine("Almak istediğiniz ürünü yazın");
                                string seçim = Console.ReadLine().Trim().ToLower();

                                if (manavSebze.Contains(seçim))
                                {
                                    Console.WriteLine("Kaç kilo istiyorsunuz");
                                    int kilo = Convert.ToInt32(Console.ReadLine());
                                    alınanManavSebze.Add(seçim);
                                    alınanManavSebze.Add(kilo);
                                    cond= false;
                                }
                                else
                                {
                                    Console.WriteLine("Ürünü bulamadık, tekrar deneyin.");
                                }
                                
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı seçim yaptınız. Tekrar deneyin.");
                        }
                    }
                }
                else if (cho1 == "2")
                {
                    Console.WriteLine("Müşteri sistemine Hoşgeldiniz ");
                    Console.WriteLine("Meyve için M sebze için S yazınız");
                    string cho2 = Console.ReadLine().ToUpper();

                    if (cho2 == "M")
                    {
                        Console.WriteLine("Meyveler: ");
                        for (int i = 0; i < manavMeyve.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {manavMeyve[i]}");
                        }

                        Console.WriteLine("Ürün numarasını girin:");
                        int urunNo = int.Parse(Console.ReadLine()) - 1;

                        if (urunNo >= 0 && urunNo < manavMeyve.Count)
                        {
                            Console.WriteLine("Kaç kilo istiyorsunuz:");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            alınanManavMeyve.Add(manavMeyve[urunNo]);
                            alınanManavMeyve.Add(kilo);
                            Console.WriteLine($"{manavMeyve[urunNo]} - {kilo} kg alındı.");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz ürün numarası.");
                        }
                    }
                    else if (cho2 == "S")
                    {
                        Console.WriteLine("Sebzeler: ");
                        for (int i = 0; i < manavSebze.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {manavSebze[i]}");
                        }

                        Console.WriteLine("Ürün numarasını girin:");
                        int urunNo = int.Parse(Console.ReadLine()) - 1;

                        if (urunNo >= 0 && urunNo < manavSebze.Count)
                        {
                            Console.WriteLine("Kaç kilo istiyorsunuz:");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            alınanManavSebze.Add(manavSebze[urunNo]);
                            alınanManavSebze.Add(kilo);
                            Console.WriteLine($"{manavSebze[urunNo]} - {kilo} kg alındı.");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz ürün numarası.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız. Tekrar deneyin.");
                    }
                    }
                
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız. Tekrar deneyin.");
                }
            }
        }
    }
}

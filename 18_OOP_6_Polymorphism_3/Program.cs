using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_6_Polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ****** EMLAK SİTESİ *******
            *Arsa : Id,Fiyat,Satılık/Kiralık,Metrekare,İmar(tarla,konut)
            *Konut:Id,Fiyat,Satılık/Kiralık,Metrekare,Yaşı,Kat
            *Araba:Id,Fiyat,0/2.El,KM,YakitTipi,VitesTipi
            *Laptop:Id,Fiyat,0/2.El,Özellikler(İşlemci,Bellek,Ram,Ekran kartı)

            Customer:Id,AD,Soyad,TC,Adres

            Sepet:Ekle,ToplamTutar           
             */

            Customer customer = new Customer();
            customer.TC = "1111";
            customer.Ad = "Altan";
            customer.Soyad = "Demirci";
            customer.Adres = "İstanbul";
            customer.sepet = new Sepet(); // Sepet s = new Sepet();

            Laptop laptop = new Laptop();
            laptop.Durum = true;
            laptop.Fiyat = 45000;
            laptop.Id = 1;

            Ozellikler ozl = new Ozellikler() { Bellek = 512, Islemci = "i9 9.Nesil", Ram = 32, EkranKartı = 2 };
            laptop.ozellik = ozl;

            customer.sepet.Ekle(laptop);


            Konut konut = new Konut() { Id = 1, Fiyat = 3500000, MetreKare = 135, Durum = false, Yas = 0, Kat = 3 };

            customer.sepet.Ekle(konut);

            customer.sepet.Ekle(new Arsa() { Id = 2, Fiyat = 2000000, Durum = true, MetreKare = 300, ImarDurumu = true });

            Console.WriteLine(customer.sepet.ToplamTutar());
            Console.ReadLine();



            Console.Write("Enter your credit card number: ");
            string cardNumber = Console.ReadLine();

            Console.Write("Enter initial balance: ");
            double initialBalance;
            while (!double.TryParse(Console.ReadLine(), out initialBalance) || initialBalance < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid initial balance.");
            }

            CreditCard myCreditCard = new CreditCard(cardNumber, initialBalance);


            while (true)
            {
                Console.WriteLine("\n1. Make a purchase");
                Console.WriteLine("2. Make a payment");
                Console.WriteLine("3. Check balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            // Make a purchase
                            Console.Write("Enter the purchase amount: ");
                            double purchaseAmount;
                            while (!double.TryParse(Console.ReadLine(), out purchaseAmount) || purchaseAmount < 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid purchase amount.");
                            }
                            myCreditCard.MakePurchase(purchaseAmount);
                            break;
                        case 2:
                            // Make a payment
                            Console.Write("Enter the payment amount: ");
                            double paymentAmount;
                            while (!double.TryParse(Console.ReadLine(), out paymentAmount) || paymentAmount < 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid payment amount.");
                            }
                            myCreditCard.MakePayment(paymentAmount);
                            break;
                        case 3:
                            // Check balance
                            myCreditCard.CheckBalance();
                            break;
                        case 4:
                            // Exit program
                            Console.WriteLine("Exiting program. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

            }
        }
        class Urun
        {
            public int Id { get; set; }
            public double Fiyat { get; set; }

            public virtual double KDVUygula()
            {
                return Fiyat * 1.18;
            }
        }
        class Emlak : Urun
        {
            public bool Durum { get; set; }
            public int MetreKare { get; set; }
        }
        class Arsa : Emlak
        {
            public bool ImarDurumu { get; set; }
        }
        class Konut : Emlak
        {
            public int Yas { get; set; }
            public int Kat { get; set; }
        }
        class Araba : Urun
        {
            public bool Durum { get; set; }
            public int KM { get; set; }
            public string YakitTipi { get; set; }
            public string VitesTipi { get; set; }

            public override double KDVUygula()
            {
                return Fiyat * 1.28;
            }
        }
        class Laptop : Urun
        {
            public bool Durum { get; set; }
            public Ozellikler ozellik { get; set; }
            public override double KDVUygula()
            {
                return Fiyat * 1.48;
            }
        }
        class Ozellikler
        {
            public string Islemci { get; set; }
            public int Bellek { get; set; }
            public int Ram { get; set; }
            public int EkranKartı { get; set; }
        }

        //Id,AD,Soyad,TC,Adres
        class Customer
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string TC { get; set; }
            public string Adres { get; set; }

            public Sepet sepet { get; set; }
        }

        class Sepet
        {
            private List<Urun> urunler = new List<Urun>();

            public double ToplamTutar()
            {
                double toplam = 0;
                foreach (Urun item in urunler)
                {
                    toplam += item.KDVUygula();
                }
                return toplam;
            }

            public void Ekle(Urun urun)
            {
                urunler.Add(urun);
            }
        }



        class CreditCard
        {
            private string cardNumber;
            private double balance;

            public CreditCard(string cardNumber, double initialBalance)
            {
                this.cardNumber = cardNumber;
                this.balance = initialBalance;
            }

            public void MakePurchase(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Purchase successful! Remaining balance: {balance:C}");
                }
                else
                {
                    Console.WriteLine("Invalid amount or insufficient balance.");
                }
            }

            public void MakePayment(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Payment received! Updated balance: {balance:C}");
                }
                else
                {
                    Console.WriteLine("Invalid payment amount.");
                }
            }

            public void CheckBalance()
            {
                Console.WriteLine($"Current balance: {balance:C}");
            }
        }


    }
}

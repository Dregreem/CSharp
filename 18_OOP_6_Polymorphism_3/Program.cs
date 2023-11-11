using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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

            customer.sepet.Shoppingchoice(customer,myCreditCard,initialBalance);
            
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
            public void Delete()
            {
               urunler.Clear();
            }

            public void Shoppingchoice(Customer custom, CreditCard card, double num)
            {
                while (true)
                {
                    Console.WriteLine("\n1. Make a purchase");
                    Console.WriteLine("2. Make a payment");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");

                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        double top = custom.sepet.ToplamTutar();
                        Console.WriteLine("Sepet tutarınız: " + top);
                        Console.WriteLine("Sahip olduğunuz bakiye: " + num);
                        Thread.Sleep(3000);

                        switch (choice)
                        {
                            case 1:
                                if (custom.sepet.urunler.Count == 0)
                                {
                                    Console.WriteLine("Invalid input. Please add something to Sepet.");
                                }
                                else if (num < top)
                                {
                                    Console.WriteLine("Yetersiz Bakiye");
                                    card.MakePurchase(top, num);
                                }
                                else
                                {
                                    card.MakePurchase(top,num);
                                    
                                    custom.sepet.Delete();
                                    Console.WriteLine("Ürünler Silindi, Sepetiniz boşaltıldı");
                                }
                                break;

                            case 2:
                                Console.Write("Enter the payment amount: ");
                                double paymentAmount;
                                while (!double.TryParse(Console.ReadLine(), out paymentAmount) || paymentAmount < 0)
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid payment amount.");
                                }
                                card.MakePayment(paymentAmount);
                                num += paymentAmount; // Update the balance using the 'num' parameter
                                break;

                            case 3:
                                Console.WriteLine("Exiting program. Goodbye!");
                                return;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
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

            public void MakePurchase(double amount,double num)
            {
                num = this.balance;
                if (amount > 0 && amount <= num)
                {
                    num -= amount;
                    balance = num;
                    Console.WriteLine($"Purchase successful! Remaining balance: {balance:C}");
                }
                else
                {
                    Console.WriteLine("Invalid amount or insufficient balance.");
                    Installements(amount);
                }


            }
            public void Installements(double tutar)
            {
                Console.WriteLine("Would you like to make installements?");
                Console.WriteLine("1- For 3-Month: 0.00 interest rate");
                Console.WriteLine("2- For 6-Month: 0.20 interest rate");
                Console.WriteLine("3- For 9-Month: 0.40 interest rate");
                Console.WriteLine("4- For 12-Month: 0.60 interest rate");
                Console.WriteLine("5- For Exit and installements");

                int InterestMonth;
                while (!int.TryParse(Console.ReadLine(), out InterestMonth) || InterestMonth < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid annual interest rate.");
                }
                double interestrate;
                
                switch (InterestMonth)
                {
                    case 1:
                        Console.WriteLine("Seçtiğiniz interest rate 0.10 , 3 ayda ödemek istediniz");
                        interestrate = 0.10;
                        InterestMonth = 3;

                        Console.WriteLine("Aylık ödemeniz gereken tutar: " + CalculateMonthlyPayment(tutar,interestrate,InterestMonth));
                        Console.WriteLine("Ödemeniz gereken süre : " + InterestMonth + "Ay");
                        Thread.Sleep(3000);

                        break;
                    case 2:
                        Console.WriteLine("Seçtiğiniz interest rate 0.20 , 6 ayda ödemek istediniz");
                        interestrate = 0.20;
                        InterestMonth = 6;

                        Console.WriteLine("Aylık ödemeniz gereken tutar: " + CalculateMonthlyPayment(tutar, interestrate, InterestMonth));
                        Console.WriteLine("Ödemeniz gereken süre : " + InterestMonth + "Ay");
                        Thread.Sleep(3000);
                        break;
                    case 3:
                        Console.WriteLine("Seçtiğiniz interest rate 0.40 , 9 ayda ödemek istediniz");
                        interestrate = 0.40;
                        InterestMonth = 9;

                        Console.WriteLine("Aylık ödemeniz gereken tutar: " + CalculateMonthlyPayment(tutar, interestrate, InterestMonth));
                        Console.WriteLine("Ödemeniz gereken süre : " + InterestMonth + "Ay");
                        Thread.Sleep(3000);
                        break;
                    case 4:
                        Console.WriteLine("Seçtiğiniz interest rate 0.40 , 9 ayda ödemek istediniz");
                        interestrate = 0.60;
                        InterestMonth = 12;

                        Console.WriteLine("Aylık ödemeniz gereken tutar: " + CalculateMonthlyPayment(tutar, interestrate, InterestMonth));
                        Console.WriteLine("Ödemeniz gereken süre : " + InterestMonth + "Ay");
                        Thread.Sleep(3000);
                        break;
                    case 5:
                        Console.WriteLine("Ödeme yapmak istemediniz sistemden çıkartılıyorsunuz");
                        Thread.Sleep(3000);
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız");
                        break;


                }

            }
            public double CalculateMonthlyPayment(double totalAmount, double interestRate, int numberOfInstallments)
            {
                double monthlyInterestRate = interestRate / 12;
                double denominator = Math.Pow(1 + monthlyInterestRate, numberOfInstallments) - 1;
                return totalAmount * (monthlyInterestRate + (monthlyInterestRate / denominator));
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SORTEDLIST
            //SortedList sozluk = new SortedList() {
            //    {"Bugun","Today"},
            //    {"Yarin","Tommorrow"},
            //    {"Hava","Wheather" },
            //    {"Gokyuzu","Sky" },
            //    {"Karli","Snowy" },
            //    {"Gunesli","Sunny" },
            //    {"Bulutlu","Cloudy" },
            //    {"Acik","Clear" },
            //    {"Kapali","Cloudy"},
            //    {"1","One" }
            //};



            //sozluk.Add("Araba", "Car");
            //sozluk.Clear();
            //Console.WriteLine(sozluk.Count);
            //Console.WriteLine(sozluk.Contains("Araba"));
            //Console.WriteLine(sozluk.ContainsKey("Araba"));
            //Console.WriteLine(sozluk.ContainsValue("Araba"));

            //foreach (DictionaryEntry item in sozluk)
            //{
            //    Console.WriteLine(item.Key + ":" + item.Value);
            //}

            //foreach (var k in sozluk.Keys)
            //{
            //    Console.WriteLine(k);
            //}
            //Console.WriteLine("*****************");
            //foreach (string v in sozluk.Values)
            //{
            //    Console.WriteLine(v);
            //}
            #endregion


            #region HASHTABLE

            //LIFO:Last In First Out

            Hashtable htable = new Hashtable();
            Console.WriteLine($"Count :{htable.Count}");

            //Add metodu
            htable.Add(1, "Bir");
            htable.Add(2, "İki");
            htable.Add(3, "Üç");
            htable.Add(4, "Dört");
            htable.Add("Beş", "5");
            #endregion

            foreach (DictionaryEntry item in htable)
            {
                Console.WriteLine(item.Key + "     " + item.Value);
                //Console.WriteLine(((DictionaryEntry)item).);
            }

            Console.ReadLine();
        }
    }
}

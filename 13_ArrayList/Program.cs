using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi: veritipi ve boyutu sabit olması gereklidir.

            //int[] sayilar = new int[5];

            //********** ARRAYLIST ***********


            //ArrayList arraylist = new ArrayList();
            //arraylist.Add(1);
            //arraylist.Add(12.5);
            //arraylist.Add(13.5f);
            //arraylist.Add("Altan Emre");
            //arraylist.Add(45m);
            //arraylist.Add('?');

            //for (int i = 0; i < arraylist.Count; i++)
            //{
            //    Console.WriteLine(arraylist[i]);
            //}

            //foreach (var item in arraylist)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arraylist = new ArrayList() { 11, 666,44,"Altan","Emre",1,2,3,4,5,6,7,8,9,0,1,2};
            //Console.WriteLine("Capacity:"+arrayList.Capacity);
            //Console.WriteLine("Count:"+arrayList.Count);


            //arraylist.Clear(); //Bütün elemanları siler.
            //arraylist.Remove("Altan"); //belirtilen değer silinir.
            //arraylist.RemoveAt(2); // belirtilen index silinir.
            //arraylist.RemoveRange(1, 3); //belirtilen indexten verilen uzunluk kadar değer silinir.


            //if (arraylist.Contains("Emre"))
            //{
            //    Console.WriteLine("VAR");
            //}


            //arraylist.Insert(2, "Eray"); //Belirtilen indexe verilen değer eklenir. Eklenen index de değer varsa bir sağa kayar.

            //arraylist.Sort(); //Kolekisyon 0->9   A->Z sıralama yapar. 
            //arraylist.Reverse(); // Koleksiyon ters çevirilir.

            //foreach (var item in arraylist)
            //{
            //    Console.WriteLine(item);
            //}


            //ArrayList arrayList2 = (ArrayList)arraylist.Clone();

            //foreach (var item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}

            #region ALIŞTIRMALAR

            ////0 girilene kadar girilen değerleri ArrayListe atan ve sonunda bu listeyi büyükten küçüğe sıralayan ve listedeki en büyük en küçük ve ortalama değerleri bulan program

            ArrayList sayilar = new ArrayList();
            int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0) break;
            //    sayilar.Add(sayi);
            //    toplam += sayi;
            //}

            int sayi;
            do
            {
                Console.WriteLine("Sayı:");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                if (sayi != 0) 
                    sayilar.Add(sayi);
            } while (sayi!=0);


            sayilar.Sort();
            sayilar.Reverse();
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ortalama:"+(toplam/sayilar.Count));
            Console.WriteLine("En Büyük Değer:" + (sayilar[0]));
            Console.WriteLine("En Küçük Değer:" + sayilar[sayilar.Count-1]);

            #endregion


            Console.ReadLine();
        }
    }
}

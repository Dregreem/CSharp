using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_GenericList
{
    internal class Ogrenci
    {
        //Properties
        public string Ad;
        public string Soyad;
        public int Numara;
        public string Sinif;

        public void OzellikYazdir()
        {
            Console.WriteLine(Ad+" "+Soyad+" "+Numara+" "+Sinif );
        }


    }
}

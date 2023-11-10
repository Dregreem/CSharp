using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_6_Polymorphism
{
    internal class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        //virtual: sanallaştırma yapar. İstenildiği durumlarda bu method ezilebilir.
        public virtual void Yaz()
        {
            Console.WriteLine(Ad+" "+Soyad);
        }
    }
}

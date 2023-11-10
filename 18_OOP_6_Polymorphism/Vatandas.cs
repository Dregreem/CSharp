using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_6_Polymorphism
{
    internal class Vatandas:Insan
    {
        public string TC { get; set; }

        //Dinamik Polymorphism
        public override void Yaz()
        {         
            Console.WriteLine(Ad+" "+Soyad+" "+TC);
        }
    }
}

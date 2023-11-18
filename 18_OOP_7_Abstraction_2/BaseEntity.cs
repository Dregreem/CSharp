using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_7_Abstraction_2
{
    internal abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }

        public abstract void Insert();
        public abstract void Update();
        public abstract void Delete();
        public abstract void List();
        public abstract void GetById();
    }
}

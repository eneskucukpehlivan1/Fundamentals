using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Personel : Worker
    {
        private int _salesCount;

        public int SalesCount
        {
            get { return _salesCount; }
            set { _salesCount = value; }
        }
    }
}

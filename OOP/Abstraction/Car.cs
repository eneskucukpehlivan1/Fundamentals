using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    class Car : Vehicle
    {
        public override double GetFuel()
        {
            return 300;
        }
    }
}

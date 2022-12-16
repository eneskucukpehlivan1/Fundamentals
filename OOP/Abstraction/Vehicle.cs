using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    abstract class Vehicle
    {
        public abstract double GetFuel();
        public void Stop()
        {
            Console.WriteLine("Durduruldu");
        }
    }
}

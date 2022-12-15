using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Manager2 : Worker2
    {
        private double _departmentProfit;

        public double DepartmentProfit
        {
            get { return _departmentProfit; }
            set { _departmentProfit = value; }
        }
        public override void Raise(double raiseValue)
        {
            if (DepartmentProfit > 50000) 
                raiseValue += 2000;
            base.Raise(raiseValue);
        }
    }
}

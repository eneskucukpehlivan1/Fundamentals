using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Manager : Worker
    {
        private double _departmentProfit;

        public double DepartmentProfit
        {
            get { return _departmentProfit; }
            set { _departmentProfit = value; }
        }
    }
}

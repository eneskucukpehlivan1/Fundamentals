using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Worker
    {
        private int _workerNo;
        private string _workerName;
        private double _workerSalary;

        public int WorkerNo
        {
            get { return _workerNo; }
            set { _workerNo = value; }
        }

        public string WorkerName
        {
            get { return _workerName; }
            set { _workerName = value; }
        }
        public double WorkerSalary
        {
            get { return _workerSalary; }
            set { _workerSalary = value; }
        }
    }
}

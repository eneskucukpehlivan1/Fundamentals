using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    internal interface IDatabase
    {
        int login(string userName, string password);
        void close();
        void addValue(string value);
        void deleteValue();
        void getValue();
    }
}

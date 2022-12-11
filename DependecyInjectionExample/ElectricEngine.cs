using System;
namespace DependecyInjectionExample
{
	public class ElectricEngine : Engine
	{
		public ElectricEngine()
		{
		}

        public string start()
        {
            return "Elektrik motoru çalıştı";

        }
    }
}


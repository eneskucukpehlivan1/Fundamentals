using System;
namespace DependecyInjectionExample
{
	public class DieselEngine : Engine
	{
		public DieselEngine()
		{
		}

        public string start()
        {
            return "Dizel motor çalıştı";
        }
    }
}


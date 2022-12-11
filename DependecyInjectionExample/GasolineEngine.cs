using System;
namespace DependecyInjectionExample
{
	public class GasolineEngine : Engine
	{
        private static GasolineEngine _gasolineEngine;
        private GasolineEngine()
		{

		}

        public static GasolineEngine CreateAsSingleton()
        {
            //if (_gasolineEngine == null)
            //    _gasolineEngine = new GasolineEngine();
            //return _gasolineEngine;
            return _gasolineEngine ?? (_gasolineEngine = new GasolineEngine());

        }

        public string start()
        {
            return "Benzin motoru çalıştı";
        }
    }
}


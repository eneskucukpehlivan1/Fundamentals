using System;
namespace DependecyInjectionExample
{
	public class AutoCar : Car
	{
        Engine _engine;
		public AutoCar(Engine engine)
		{
            _engine = engine;
		}

        public void drive()
        {
            string engineStart = _engine.start();
            Console.WriteLine(engineStart);
        }
    }
}


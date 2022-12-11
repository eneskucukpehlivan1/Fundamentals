using System;
namespace SolidPrinciples.InterfaceSegregation
{
	public class Manager : IWork,IEat
	{
        private static Manager _manager;
		public Manager()
		{
		}
        public static Manager CreateAsSingleton()
        {
            return _manager ?? (_manager = new Manager());
        }

        public void Eat()
        {
            Console.WriteLine("Müdür: Yemek yer.");
        }

        public void Work()
        {
            Console.WriteLine("Müdür: Çalışır.");
        }
    }
}


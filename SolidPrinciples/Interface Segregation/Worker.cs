using System;
namespace SolidPrinciples.InterfaceSegregation
{
	public class Worker : IEat,IWork,ISalary
	{
        private static Worker _worker;
		public Worker()
		{
		}
        public static Worker CreateAsSingleton()
        {
            return _worker ?? (_worker = new Worker());
        }
        public void Eat()
        {
            Console.WriteLine("İşçi: Yemek yer.");
        }

        public void GetSalary()
        {
            Console.WriteLine("İşçi: Maaş alır.");
        }

        public void Work()
        {
            Console.WriteLine("İşçi: Çalışır.");
        }
    }
}


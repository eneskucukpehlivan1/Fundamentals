using System;
namespace SolidPrinciples.InterfaceSegregation
{
	public class Robot : IWork
	{
        private static Robot _robot;
		public Robot()
		{
		}
        public static Robot CreateAsSingleton()
        {
            return _robot ?? (_robot = new Robot());
        }

        public void Work()
        {
            Console.WriteLine("Robot: Çalışır.");
        }
    }
}


using System;
namespace SolidPrinciples.DependencyInversion
{
	public class DBLog : ILogger
	{
		public DBLog()
		{
		}

        public void Log()
        {
            Console.WriteLine("DBLog loglandi.");
        }
    }
}


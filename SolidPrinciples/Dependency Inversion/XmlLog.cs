using System;
namespace SolidPrinciples.DependencyInversion
{
	public class XmlLog : ILogger
	{
		public XmlLog()
		{
		}

        public void Log()
        {
            Console.WriteLine("XmlLog loglandi.");
        }
    }
}


using System;
namespace SolidPrinciples.DependencyInversion
{
	public class Logger
	{
        private readonly ILogger _Ilogger;
		public Logger(ILogger Ilogger)
		{
			_Ilogger = Ilogger;
		}
		public void Log()
		{
			_Ilogger.Log();
		}
	}
}


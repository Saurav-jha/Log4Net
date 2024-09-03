using System;
using log4net;
using log4net.Config;
using System.Reflection;

namespace Log4Net.ConsoleApp
{
	public class LogUtility
	{
        public static void ConfigureLog4Net()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository);
        }
    }
}


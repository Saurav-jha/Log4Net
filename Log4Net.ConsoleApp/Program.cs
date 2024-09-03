using System;
using System.Reflection;

namespace Log4Net.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LogUtility.ConfigureLog4Net(); // Call the configuration method

            ILogger logger = new Logger(); // Instantiate the Logger class

            logger.Info("Starting the console application");

            try
            {
                logger.Debug($"Starting {MethodBase.GetCurrentMethod()?.DeclaringType}");
                throw new Exception("Sample Error inside the try catch block code");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex.InnerException);
            }

            Console.ReadLine();

            logger.Info("Ending application");
        }
    }
}

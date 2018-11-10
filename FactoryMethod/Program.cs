using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LoggerFactory factory = new LoggerFactory();
            ILogger logger = factory.GetLogger();
            logger.Log("A Message to Log");
        }
    }
}

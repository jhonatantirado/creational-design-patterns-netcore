using System;
namespace FactoryMethod
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("File: " + message);
        }
    }
}

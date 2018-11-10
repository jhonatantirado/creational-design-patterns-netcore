namespace FactoryMethod
{
    public class LoggerFactory
    {
        public bool IsFileLoggingEnabled()
        {
            return true;
        }

        public ILogger GetLogger()
        {
            if (IsFileLoggingEnabled())
            {
                return new FileLogger();
            }
            else
            {
                return new ConsoleLogger();
            }
        }
    }
}

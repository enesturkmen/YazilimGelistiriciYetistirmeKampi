using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void LoggerService()
        {
            Console.WriteLine("Logged to file");
        }
    }
}

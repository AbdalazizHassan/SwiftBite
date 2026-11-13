using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftBite.Business.Logging
{
    public class ConsoleLogger : ILogger
    {
       
        public void Info(string message)
        {
            Write("Info", message);
        }

        public void Warning(string message)
        {
            Write("Warning", message);
        }

        public void Error(string message, Exception exception)
        {
            Write("ERROR", $"{message} -> {exception.Message}");
        }

        private static void Write(string level , string message)
        {
            Console.WriteLine($"{DateTime.Now:HH:mm:ss} [{level}] {message}");
        }
    }
}

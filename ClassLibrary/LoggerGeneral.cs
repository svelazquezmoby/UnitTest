using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface ILoggerGeneral
    {
        void Message(string message);
    }
    public class LoggerFalso : ILoggerGeneral
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class LoggeFalso : ILoggerGeneral
    {
        public void Message(string message)
        {
        }
    }
}

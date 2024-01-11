using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine(  "veri tabanına loglandı");
        }
    }
}

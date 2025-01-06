using Day8.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class ConsoleLogger : ILogger
    {
       public void Log() 
       {
            Console.WriteLine("ConsoleLogger method");
       }
    }
}

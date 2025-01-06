using Day8.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("class fun");
        }

        void IWalkable.Walk()
        {
            Console.WriteLine("interface fun");
        }
    }
}

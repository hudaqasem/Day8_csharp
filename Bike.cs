using Day8.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike start");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike stop");
        }
    }
}

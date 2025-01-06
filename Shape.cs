using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal abstract class Shape
    {
        #region properties
        public double Dim1 { get; set; }
        public double Dim2 { get; set; }
        #endregion

        #region Methods
        public abstract double GetArea(); 
        public void Display()
        {
            Console.WriteLine("Display Shape");
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal abstract class GeometricShape
    {
        #region  properties
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }
        public abstract double Perimeter { get; }
        #endregion
        #region Method
        public abstract double CalculateArea();

        #endregion
    }
}

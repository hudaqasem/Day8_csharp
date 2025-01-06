using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class Triangle : GeometricShape
    {
        #region  properties
        public override double Perimeter { get { return Dimension1 + Dimension2; } }

        #endregion

        #region constructor
        public Triangle(double dim1, double dim2)
        {
            Dimension1 = dim1;
            Dimension2 = dim2;
        } 
        #endregion
        #region Methods
        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }
        public override string ToString()
        {
            return $"Triangle area = {CalculateArea()} , perimeter = {Perimeter} ";
        }
        #endregion
    }
}

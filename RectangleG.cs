using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class RectangleG : GeometricShape
    {
        #region  properties
        public override double Perimeter { get { return 2 * (Dimension1 + Dimension2); } }

        #endregion

        #region constr
        public RectangleG(double dim1, double dim2)
        {
            Dimension1 = dim1;
            Dimension2 = dim2;
        }
        #endregion
        #region Mehods
        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }
        public override string ToString()
        {
            return $"Rectangle area = {CalculateArea()} , perimeter = {Perimeter} ";
        }
        #endregion
    }
}

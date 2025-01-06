using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class Rectangle : Shape
    {
        #region constructors
        public Rectangle(double width, double height)
        {
            Dim1 = width;
            Dim2 = height;
        }
        #endregion

        #region Methods
        public override double GetArea()
        {
            return Dim1 * Dim2;
        } 
        #endregion
    }
}

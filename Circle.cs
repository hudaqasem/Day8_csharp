using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class Circle : Shape
    {
        #region constructors
        public Circle(double radius)
        {
            Dim1 = radius;
        }
        #endregion

        #region Methods
        public override double GetArea()
        {
            return 3.14 * Dim1 * Dim1;
        } 
        #endregion
    }
}

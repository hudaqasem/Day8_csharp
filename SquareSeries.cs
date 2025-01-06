using Day8.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class SquareSeries : IShapeSeries
    {
        #region  properties
        public int Dim { get; set; }
        public int CurrentShapeArea { get; set; }
        #endregion

        #region Method
        public void GetNextArea()
        {
            Dim++;
            CurrentShapeArea = Dim * Dim;
        } 
        #endregion
    }
}

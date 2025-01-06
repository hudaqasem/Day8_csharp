using Day8.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class CircleSeries : IShapeSeries
    {
        #region  properties
        public int Radius { get; set; }
        public int CurrentShapeArea { get; set; }
        #endregion

        #region Method
        public void GetNextArea()
        {
            Radius++;
            CurrentShapeArea = (int)(Math.PI * Radius * Radius);
        } 
        #endregion


    }
}

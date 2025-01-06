using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Interfces
{
    internal interface IShapeSeries
    {
        #region  properties
        public int CurrentShapeArea { get; set; }
        #endregion

        #region Method
        void GetNextArea();
        void ResetSeries()
        {
            CurrentShapeArea = 0;
        } 
        #endregion

    }
}

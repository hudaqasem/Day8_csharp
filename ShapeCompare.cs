using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class ShapeCompare : IComparable
    {
        #region  properties
        public string Name { get; set; }
        public double Area { get; set; }
        #endregion

        #region constructor
        public ShapeCompare(double area)
        {
            Area = area;
        }
        public ShapeCompare(string name , double area):this(area)
        {
            Name = name;   
        }
        #endregion

        #region Method
        public int CompareTo(object? obj)
        {
            ShapeCompare sh = (ShapeCompare)obj;
            if (this.Area > sh.Area)
                return 1;
            else if(this.Area < sh.Area)
                return -1;
            else 
                return 0;
        }

        public override string ToString()
        {
            return $"{Name} , Area = {Area} ";
        }
        #endregion
    }
}

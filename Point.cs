using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class Point
    {
        #region properties
        public int X { get; }
        public int Y { get; }
        #endregion

        #region constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region operator overloading
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        public static Point operator ++(Point p1)
        {
            return new Point(p1.X+1, p1.Y+1);
        }
        #endregion

        public override string ToString()
        {
            return $"({X} , {Y})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classses
{
    internal class ShapeFactory
    {
        public static GeometricShape CreateShape(string shapeType,double dim1, double dim2)
        {
            switch (shapeType.ToLower())
            {
                case "rectangle":
                    return new RectangleG(dim1, dim2);
                case "triangle":
                    return new Triangle(dim1, dim2);
                
                default:
                    throw new($"Shape type '{shapeType}' is not founded");
            }

        }
    }
}

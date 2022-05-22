using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class FactoryShape
    {
        public Shape GetShape(string shapeName, Color color, float penWidth )
        {
            switch (shapeName)
            {
                case "Circle":
                    return new Circle(color,penWidth);
                case "Square":
                    return new Square(color, penWidth);
                case "Star":
                    return new Adapter(color, penWidth);
                case "Triangle":
                    return new RightTriangle(color, penWidth);
                case "Rectangle":
                    return new Rectangle(color, penWidth);
                case "IsoscelesTriangle":
                    return new IsoscelesTriangle(color, penWidth);
                default:
                    throw new Exception($"Sorry this shape ({shapeName}) is not yet implemented");
            }
        }
    }
}

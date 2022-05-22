using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    [Serializable]
    public class Circle : Shape
    {

        public Circle(Color color, float penWidth) : base(color, penWidth)
        {
           
        }

        public Circle(Point start, Point end, Color color, float penWidth) : base(color, penWidth)
        {
            Point startPoint = new Point(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y));
            Point endPoint = new Point(Math.Max(start.X, end.X), Math.Max(start.Y, end.Y));

            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public Circle(int x1, int y1, int x2, int y2, Color color, float penWidth) : base(color, penWidth)
        {
            Point startPoint = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            Point endPoint = new Point(Math.Max(x1, x2), Math.Max(y1, y2));

            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override void Draw(Graphics graphics)
        {
            Pen Pen = new Pen(color, penWidth);
            graphics.DrawEllipse(Pen, StartPoint.X, StartPoint.Y, EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);
        }

        public override Shape Clone()
        {
            return new Circle(color,penWidth)
            {
                StartPoint = StartPoint,
                EndPoint = EndPoint
            };
        }
    }
}

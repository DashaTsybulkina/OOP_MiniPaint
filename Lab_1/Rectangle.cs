using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    [Serializable]
    public class Rectangle : Shape
    {
        public Rectangle(Point start, Point end, Color color, float penWidth) : base(color, penWidth)
        {
            Point startPoint = new Point(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y));
            Point endPoint = new Point(Math.Max(start.X, end.X), Math.Max(start.Y, end.Y));

            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public Rectangle(Color color, float penWidth) : base(color, penWidth)
        {
        }

        public Rectangle(int x1, int y1, int x2, int y2, Color color, float penWidth) : base(color, penWidth)
        {
            Point startPoint = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            Point endPoint = new Point(Math.Max(x1, x2), Math.Max(y1, y2));

            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override void Draw(Graphics graphics)
        {
            Pen Pen = new Pen(color, penWidth);
            Point leftCorner = new Point(Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y));
            Point rightCorner = new Point(Math.Max(StartPoint.X, EndPoint.X), Math.Max(StartPoint.Y, EndPoint.Y));
            graphics.DrawRectangle(Pen, leftCorner.X, leftCorner.Y, rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);
        }
        public override Shape Clone()
        {
            return new Rectangle(color, penWidth)
            {
                StartPoint = StartPoint,
                EndPoint = EndPoint
            };
        }
    }
}

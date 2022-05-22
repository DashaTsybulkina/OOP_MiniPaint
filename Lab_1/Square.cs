using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    [Serializable]
    public class Square : Rectangle
    {
        public Square(Color color, float penWidth) : base(color, penWidth) { }

        public Square(Point start, Point end, Color color, float penWidth)
            : base(start, end, color, penWidth) { }

        public Square(int x1, int y1, int x2, int y2, Color color, float penWidth)
            : base(x1, y1, x2, y2, color, penWidth) { }

        public override void Draw(Graphics graphics)
        {
            Pen Pen = new Pen(color, penWidth);
            Point startPoint = new Point(Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y));
            Point endPoint = new Point(Math.Max(StartPoint.X, EndPoint.X), Math.Max(StartPoint.Y, EndPoint.Y));

            StartPoint = startPoint;
            EndPoint = endPoint;

            float width = Math.Max(EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);
            graphics.DrawRectangle(Pen, StartPoint.X, StartPoint.Y, width, width);
        }

        public override Shape Clone()
        {
            return new Square(color, penWidth)
            {
                StartPoint = StartPoint,
                EndPoint = EndPoint
            };
        }
    }
}

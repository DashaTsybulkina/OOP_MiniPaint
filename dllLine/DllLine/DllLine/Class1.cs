using System;
using System.Drawing;
using BaseClass;

namespace LineClass
{
    [Serializable]
    public class Line : ShapePlugin
    {
        public Line(Color color, float penWidth) : base(color, penWidth) { }

        public Line(Point startPoint, Point endPoint, Color color, float penWidth) : base(color, penWidth)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public Line(int x1, int y1, int x2, int y2, Color color, float penWidth) : base(color, penWidth)
        {
            Point startPoint = new Point(x1, y1);
            Point endPoint = new Point(x2, y2);

            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override void Draw(Graphics graphics)
        {
            Pen Pen = new Pen(color, penWidth);
            graphics.DrawLine(Pen, StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y);
        }
    }
}

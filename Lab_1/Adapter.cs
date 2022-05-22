using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Star_Plugin;

namespace Lab_1
{
    [Serializable]
    public class Adapter:Shape
    {

        private readonly Star star;

        public Adapter(Star adaptee, Color color, float penWidth) : base(color, penWidth)
        {
            this.star = adaptee;
        }


        public Adapter(Color color, float penWidth) : base(color, penWidth)
        {
            this.star = new Star();
        }
        public Adapter(Point start, Point end, Color color, float penWidth) : base(color, penWidth)
        {
            this.star.X1 = start.X;
            this.star.Y1 = start.Y;
            this.star.X2 = end.X;
            this.star.Y2 = end.Y;
            this.star.BorderWidth = (int)penWidth;
            this.star.FigureColor = color;

            StartPoint = start;
            EndPoint = end;
        }

        public Adapter(int x1, int y1, int x2, int y2, Color color, float penWidth) : base(color, penWidth)
        {
            this.star.X1 = x1;
            this.star.Y1 = y1;
            this.star.X2 = x2;
            this.star.Y2 = y2;
            this.star.BorderWidth = (int)penWidth;
            this.star.FigureColor = color;
            Point startPoint = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            Point endPoint = new Point(Math.Max(x1, x2), Math.Max(y1, y2));
            StartPoint = startPoint;
            EndPoint = endPoint;
        }


        public override void Draw(Graphics graphics)
        {
            this.star.X1 = this.StartPoint.X;
            this.star.Y1= this.StartPoint.Y;
            this.star.X2 = this.EndPoint.X;
            this.star.Y2 = this.EndPoint.Y;
            this.star.BorderWidth = (int)penWidth;
            this.star.FigureColor = color;
            this.star.Draw(graphics);
        }

        public override Shape Clone()
        {
            return new Adapter(color, penWidth)
            {
                StartPoint = StartPoint,
                EndPoint = EndPoint
            };
        }
    }
}

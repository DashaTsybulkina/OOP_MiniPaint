using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1
{
    [Serializable]
    public class RightTriangle : Triangle
    {
        public override Point StartPoint
        {
            set
            {
                _startPoint = value;

                Point vertex1 = new Point(_startPoint.X, _startPoint.Y);
                Point vertex2 = new Point(_endPoint.X, _endPoint.Y);
                Point vertex3 = new Point(_startPoint.X, _endPoint.Y);

                Vertices = new Point[3] { vertex1, vertex2, vertex3 };
            }

            get { return _startPoint; }
        }

        public override Point EndPoint
        {
            set
            {
                _endPoint = value;

                Point vertex1 = new Point(_startPoint.X, _startPoint.Y);
                Point vertex2 = new Point(_endPoint.X, _endPoint.Y);
                Point vertex3 = new Point(_startPoint.X, _endPoint.Y);

                Vertices = new Point[3] { vertex1, vertex2, vertex3 };
            }

            get { return _endPoint; }
        }

        public RightTriangle(Point start, Point end, Color color, float penWidth) : base(color, penWidth)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public RightTriangle(int x1, int y1, int x2, int y2, Color color, float penWidth) : base(color, penWidth)
        {
            StartPoint = new Point(x1, y1);
            EndPoint = new Point(x2, y2);
        }

        public RightTriangle(Color color, float penWidth) : base(color, penWidth)
        {
            StartPoint = new Point(0, 0);
            EndPoint = new Point(0, 0);
        }

        public override Shape Clone()
        {
            return new RightTriangle(color, penWidth)
            {
                StartPoint = StartPoint,
                EndPoint = EndPoint
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    [Serializable]
    public class IsoscelesTriangle : Triangle
    {
        public override Point StartPoint
        {
            set
            {
                _startPoint = value;

                Point vertex1 = new Point(_startPoint.X, _startPoint.Y);
                Point vertex2 = new Point(_endPoint.X, _endPoint.Y);
                Point vertex3 = new Point(_startPoint.X + (_endPoint.X - _startPoint.X) * 2, _startPoint.Y);

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
                Point vertex3 = new Point(_startPoint.X + (_endPoint.X - _startPoint.X) * 2, _startPoint.Y);

                Vertices = new Point[3] { vertex1, vertex2, vertex3 };
            }

            get { return _endPoint; }
        }

        public IsoscelesTriangle(Color color, float penWidth) : base(color, penWidth)
        {
            StartPoint = new Point(0, 0);
            EndPoint = new Point(0, 0);
        }

        public override Shape Clone()
        {
            return new IsoscelesTriangle(color, penWidth)
            {
                StartPoint = StartPoint,
                EndPoint = EndPoint
            };
        }
    }
}

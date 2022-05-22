using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;

namespace HexagonClass
{

    [Serializable]
    public class Hexagon : ShapePlugin
    {

        protected Point _startPoint;
        protected Point _endPoint;

        public Point[] Vertices { get; set; }

        public override Point StartPoint
        {
            set
            {
                _startPoint = value;


                Point vertex1 = new Point((_startPoint.X+ _endPoint.X)/2, _startPoint.Y);
                Point vertex2 = new Point(_startPoint.X, _startPoint.Y+ ((_endPoint.Y- _startPoint.Y)/4));
                Point vertex3 = new Point(_startPoint.X, _endPoint.Y - ((_endPoint.Y - _startPoint.Y) / 4));
                Point vertex4 = new Point((_startPoint.X + _endPoint.X) / 2, _endPoint.Y);
                Point vertex5 = new Point(_endPoint.X, _endPoint.Y - ((_endPoint.Y - _startPoint.Y) / 4));
                Point vertex6 = new Point(_endPoint.X, _startPoint.Y + ((_endPoint.Y - _startPoint.Y) / 4));

                Vertices = new Point[6] { vertex1, vertex2, vertex3, vertex4, vertex5, vertex6 };
            }

            get { return _startPoint; }
        }

        public override Point EndPoint
        {
            set
            {
                _endPoint = value;


                Point vertex1 = new Point((_startPoint.X + _endPoint.X) / 2, _startPoint.Y);
                Point vertex2 = new Point(_startPoint.X, _startPoint.Y + ((_endPoint.Y - _startPoint.Y) / 4));
                Point vertex3 = new Point(_startPoint.X, _endPoint.Y - ((_endPoint.Y - _startPoint.Y) / 4));
                Point vertex4 = new Point((_startPoint.X + _endPoint.X) / 2, _endPoint.Y);
                Point vertex5 = new Point(_endPoint.X, _endPoint.Y - ((_endPoint.Y - _startPoint.Y) / 4));
                Point vertex6 = new Point(_endPoint.X, _startPoint.Y + ((_endPoint.Y - _startPoint.Y) / 4));

                Vertices = new Point[6] { vertex1, vertex2, vertex3, vertex4, vertex5, vertex6 };
            }

            get { return _endPoint; }
        }

        public Hexagon(Color color, float penWidth) : base(color, penWidth)
        {
            StartPoint = new Point(0, 0);
            EndPoint = new Point(0, 0);
        }

        public Hexagon(Point start, Point end, Color color, float penWidth) : base(color, penWidth)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public override void Draw(Graphics graphics)
        {
            Pen Pen = new Pen(color, penWidth);
            graphics.DrawPolygon(Pen, Vertices);
        }
    }
}

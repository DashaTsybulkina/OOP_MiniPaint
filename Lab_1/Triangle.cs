using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    [Serializable]

    public abstract class Triangle : Shape
    {
        protected Point _startPoint;
        protected Point _endPoint;

        public Point[] Vertices { get; set; }

        public Triangle(Color color, float penWidth) : base(color, penWidth)
        {
        }

        public override void Draw(Graphics graphics)
        {
            Pen Pen = new Pen(color, penWidth);
            graphics.DrawPolygon(Pen, Vertices);
        }

    }
}

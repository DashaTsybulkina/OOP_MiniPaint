using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1
{
    [Serializable]
    public abstract class Shape
    {
    //    public Pen Pen { get; set; }
        public Color color { get; set; }
        public float penWidth { get; set; }

        public virtual Point StartPoint { get; set; }
        public virtual Point EndPoint { get; set; }

        public Shape(Color color, float penWidth)
        {
            this.color = color;
            this.penWidth = penWidth;
        }

        public abstract void Draw(Graphics graphics);

        public abstract Shape Clone();
    }
}

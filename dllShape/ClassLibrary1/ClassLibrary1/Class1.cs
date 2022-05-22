using System;
using System.Collections.Generic;
using System.Drawing;


namespace BaseClass
{
    [Serializable]
    public abstract class ShapePlugin
    {
        //    public Pen Pen { get; set; }
        public Color color { get; set; }
        public float penWidth { get; set; }

        public virtual Point StartPoint { get; set; }
        public virtual Point EndPoint { get; set; }

        public ShapePlugin(Color color, float penWidth)
        {
            this.color = color;
            this.penWidth = penWidth;
        }

        public abstract void Draw(Graphics graphics);
    }
}

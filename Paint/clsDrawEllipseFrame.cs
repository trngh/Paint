using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class clsDrawEllipseFrame : clsDrawObject
    {
        public override void Draw(Graphics gp, Pen myPen, Brush myBrush)
        {
            gp.DrawEllipse(new Pen(maunet, size), this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
        }
    }
}

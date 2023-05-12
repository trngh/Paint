using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class clsDrawRecFrameDash : clsDrawObject
    {
        public override void Draw(Graphics gp, Pen myPen, Brush myBrush)
        {
            Pen pen = new Pen(maunet, 2);
            pen.DashPattern = new float[] { 2, 2 };
            gp.DrawRectangle(pen, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
        }
    };
}

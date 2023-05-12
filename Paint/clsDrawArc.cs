using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class clsDrawArc : clsDrawObject
    {
        public override void Draw(Graphics gp, Pen myPen, Brush myBrush)
        {
            gp.DrawCurve(new Pen(maunet, size), points_Arc);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class clsDrawLine : clsDrawObject
    {
        public override void Draw(Graphics gp, Pen myPen, Brush myBrush)
        {
            gp.DrawLine(new Pen(maunet, size), p1, p2);
        }
    }
}

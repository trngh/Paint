using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class clsDrawPolygon : clsDrawObject
    {

        public override void Draw(Graphics gp, Pen myPen, Brush myBrush)
        {
            if (pentagonVertices != null && pentagonVertices.Length == 5)
            {
                gp.DrawPolygon(new Pen(maunet, size), pentagonVertices);
            }
        }
    }
}

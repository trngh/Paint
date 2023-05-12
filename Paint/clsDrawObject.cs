using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public abstract class clsDrawObject
    {
        public Point p1;
        public Point p2;
        public Color maunet, maunen;
        public int size;
        public PointF[] pentagonVertices = new PointF[5]; //ngu giac can
        public Point[] points_Arc = new Point[3];
        public int index; //chỉ số tìm hình để xóa
        public abstract void Draw(Graphics gp, Pen myPen, Brush myBrush);
    }
}

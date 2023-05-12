using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics gp;
        Pen myPen;
        Brush myBrush;
        ColorDialog cdPen = new ColorDialog();
        ColorDialog cdBrush = new ColorDialog();
        Color new_colorPen = new Color();
        Color new_colorBrush = new Color();
        bool bLine = false, bRecFrame = false, bRec = false, bEllipseFrame = false,
            bEllipse = false, bSelect = false, bMove = false, bResize = false, isPress = false,
            bS_Remove = false, bS_Ctrl = false, bARC = false, bPolygon = false, bPolygonFilled = false;
        int k = -1; //vi tri obj duoc chon
        int k_Selects = -1; //vi tri select duoc chon
        Point pos, p1_select, p2_select; //vi tri chuot tai obj duoc chon
        int conner = -1; //goc
        public int count_Arc = 0;
        List<clsDrawObject> lstObjects = new List<clsDrawObject>();
        List<clsDrawObject> lstSelects = new List<clsDrawObject>();

        public Form1()
        {
            InitializeComponent();
            gp = pnl_main.CreateGraphics();
        }
        public void no_tool() //bo chon het tat ca
        {
            this.bLine = false;
            this.bRecFrame = false;
            this.bRec = false;
            this.bEllipseFrame = false;
            this.bEllipse = false;
            this.bSelect = false;
            this.bMove = false;
            this.bResize = false;
            this.bS_Remove = false;
            this.bS_Ctrl = false;
            this.bARC = false;
            this.bPolygon = false;
            this.bPolygonFilled = false;
        }
        //xu ly cac nut
        private void btn_line_Click(object sender, EventArgs e)
        {
            no_tool();
            bLine = true;
        }
        private void btn_Ellipframe_Click(object sender, EventArgs e)
        {
            no_tool();
            bEllipseFrame = true;
        }
        private void btn_Ellip_Click(object sender, EventArgs e)
        {
            no_tool();
            bEllipse = true;
        }
        private void btn_Recframe_Click(object sender, EventArgs e)
        {
            no_tool();
            bRecFrame = true;
        }
        private void btn_Rec_Click(object sender, EventArgs e)
        {
            no_tool();
            bRec = true;
        }

        private void btn_Arc_Click(object sender, EventArgs e)
        {
            no_tool();
            bARC = true;
        }
        private void btn_Polygon_Click(object sender, EventArgs e)
        {
            no_tool();
            bPolygon = true;
        }
        private void btn_PolygonFilled_Click(object sender, EventArgs e)
        {
            no_tool();
            bPolygonFilled = true;
        }
        private void btnSelects_Ctrl_Click(object sender, EventArgs e)
        {
            no_tool();
            bS_Ctrl = true;
        }
        private void btnS_Remove_Click(object sender, EventArgs e)
        {
            no_tool();
            bS_Remove = true;
        }
        private void btn_ColorPen_Click(object sender, EventArgs e)
        {
            cdPen.ShowDialog();
            new_colorPen = cdPen.Color;
        }
        private void btn_ColorBrush_Click(object sender, EventArgs e)
        {
            cdBrush.ShowDialog();
            new_colorBrush = cdBrush.Color;
        }

        // lay mau net ve, mau co ve, do day net ve
        public Color Maunet()
        {

            Color color_pen = new_colorPen;
            return color_pen;
        }
        public Color Maunen()
        {
            Color color_brush = new_colorBrush;
            return color_brush;
        }
        public int Size()
        {
            int size = 3;
            if (cmb_size.Text.ToString() == "1 px")
            {
                size = 1;
            }
            else if (cmb_size.Text.ToString() == "5 px")
            {
                size = 5;
            }
            else if (cmb_size.Text.ToString() == "10 px")
            {
                size = 10;
            }
            return size;
        }

        private void pnl_main_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = lstSelects.Count - 1; i >= 0; i--)
                {
                    lstObjects.RemoveAt(lstSelects[i].index);
                }
                lstSelects.Clear();
                pnl_main.Refresh();
            }
        } // bat su kien nhan phim ctrl
        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {
            pnl_main.Focus();
            for (int i = 0; i < lstObjects.Count; i++)
            {
                this.lstObjects[i].Draw(this.gp, myPen, myBrush);
            }
            for (int i = 0; i < lstSelects.Count; i++)
            {
                this.lstSelects[i].Draw(this.gp, myPen, myBrush);
            }
        } // ve lai toan bo 
        private void pnl_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (bLine == true)
            {
                isPress = true;
                clsDrawObject obj;
                obj = new clsDrawLine();
                obj.p1 = e.Location;
                obj.p2 = e.Location;
                obj.maunet = Maunet();
                obj.size = Size();
                this.lstObjects.Add(obj);
            }
            else if (bRecFrame == true)
            {
                isPress = true;
                clsDrawObject obj;
                obj = new clsDrawRecFrame();
                obj.p1 = e.Location;
                obj.p2 = e.Location;
                obj.maunet = Maunet();
                obj.size = Size();
                this.lstObjects.Add(obj);
            }
            else if (bRec == true)
            {
                isPress = true;
                clsDrawObject obj;
                obj = new clsDrawRec();
                obj.p1 = e.Location;
                obj.p2 = e.Location;
                obj.maunet = Maunet();
                obj.size = Size();
                obj.maunen = Maunen();
                this.lstObjects.Add(obj);
            }
            else if (bEllipseFrame == true)
            {
                isPress = true;
                clsDrawObject obj;
                obj = new clsDrawEllipseFrame();
                obj.p1 = e.Location;
                obj.p2 = e.Location;
                obj.maunet = Maunet();
                obj.size = Size();
                this.lstObjects.Add(obj);
            }
            else if (bEllipse == true)
            {
                isPress = true;
                clsDrawObject obj;
                obj = new clsDrawEllipse();
                obj.p1 = e.Location;
                obj.p2 = e.Location;
                obj.maunet = Maunet();
                obj.size = Size();
                obj.maunen = Maunen();
                this.lstObjects.Add(obj);
            }
            else if (bARC == true)
            {
                if (count_Arc == 0)
                {
                    isPress = true;
                    clsDrawObject obj;
                    obj = new clsDrawArc();
                    obj.p1 = e.Location;
                    obj.p2 = e.Location;
                    obj.maunet = Maunet();
                    obj.size = Size();
                    obj.maunen = Maunen();
                    obj.points_Arc[0] = obj.p1;
                    obj.points_Arc[2] = obj.p2;
                    obj.points_Arc[1] = new Point((obj.p1.X + obj.p2.X) / 2, (obj.p1.Y + obj.p2.Y) / 2);
                    this.lstObjects.Add(obj);
                }
                else
                {
                    isPress = true;
                    lstObjects[lstObjects.Count - 1].points_Arc[1] = e.Location;
                    pnl_main.Refresh();
                }
            }
            else if (bPolygon == true)
            {
                isPress = true;
                clsDrawObject obj;
                obj = new clsDrawPolygon();
                obj.p1 = e.Location;
                obj.p2 = e.Location;
                obj.maunet = Maunet();
                obj.size = Size();
                obj.maunen = Maunen();

                float distance = (float)Math.Sqrt(Math.Pow(obj.p2.X - obj.p1.X, 2) + Math.Pow(obj.p2.Y - obj.p1.Y, 2));
                float angle = (float)Math.Atan2(obj.p2.Y - obj.p1.Y, obj.p2.X - obj.p1.X);
                for (int i = 0; i < 5; i++)
                {
                    float x = (float)(obj.p1.X + distance * Math.Cos(angle + i * 2 * Math.PI / 5));
                    float y = (float)(obj.p1.Y + distance * Math.Sin(angle + i * 2 * Math.PI / 5));
                    obj.pentagonVertices[i] = new PointF(x, y);
                }

                this.lstObjects.Add(obj);
            }
            else if (bPolygonFilled == true)
            {
                isPress = true;
                clsDrawObject obj;
                obj = new clsDrawPolygonFilled();
                obj.p1 = e.Location;
                obj.p2 = e.Location;
                obj.maunet = Maunet();
                obj.size = Size();
                obj.maunen = Maunen();

                float distance = (float)Math.Sqrt(Math.Pow(obj.p2.X - obj.p1.X, 2) + Math.Pow(obj.p2.Y - obj.p1.Y, 2));
                float angle = (float)Math.Atan2(obj.p2.Y - obj.p1.Y, obj.p2.X - obj.p1.X);
                for (int i = 0; i < 5; i++)
                {
                    float x = (float)(obj.p1.X + distance * Math.Cos(angle + i * 2 * Math.PI / 5));
                    float y = (float)(obj.p1.Y + distance * Math.Sin(angle + i * 2 * Math.PI / 5));
                    obj.pentagonVertices[i] = new PointF(x, y);
                }

                this.lstObjects.Add(obj);
            }
            else if (bSelect == true)
            {
                lstSelects.Clear();
                pnl_main.Refresh();
                for (int i = 0; i < lstObjects.Count(); i++)
                {
                    if (lstObjects[i].p1.X + 3 < e.X && lstObjects[i].p1.Y + 3 < e.Y && lstObjects[i].p2.X - 3 > e.X && lstObjects[i].p2.Y - 3 > e.Y && k == -1)
                    {
                        k = i;
                        bMove = true;
                        bResize = false;
                        pos = e.Location;
                        p1_select = lstObjects[i].p1;
                        p2_select = lstObjects[i].p2;
                        this.Cursor = Cursors.SizeAll;
                    }
                    else if (e.X >= lstObjects[i].p1.X && e.X <= lstObjects[i].p1.X + 3 && e.Y >= lstObjects[i].p1.Y && e.Y <= lstObjects[i].p1.Y + 3
                        || e.X >= lstObjects[i].p2.X - 3 && e.X <= lstObjects[i].p2.X && e.Y >= lstObjects[i].p2.Y - 3 && e.Y <= lstObjects[i].p2.Y)
                    {
                        if (e.X >= lstObjects[i].p2.X - 3 && e.X <= lstObjects[i].p2.X && e.Y >= lstObjects[i].p2.Y - 3 && e.Y <= lstObjects[i].p2.Y)
                        {
                            conner = 4;
                        }
                        else conner = 1;
                        bResize = true;
                        bMove = false;
                        k = i;
                        pos = e.Location;
                        p1_select = lstObjects[i].p1;
                        p2_select = lstObjects[i].p2;
                        this.Cursor = Cursors.Cross;
                    }
                    else if (e.X >= lstObjects[i].p2.X - 3 && e.X <= lstObjects[i].p2.X && e.Y >= lstObjects[i].p1.Y && e.Y <= lstObjects[i].p1.Y + 3
                        || e.X >= lstObjects[i].p1.X && e.X <= lstObjects[i].p1.X + 3 && e.Y >= lstObjects[i].p2.Y - 3 && e.Y <= lstObjects[i].p2.Y)
                    {
                        if (e.X >= lstObjects[i].p2.X - 3 && e.X <= lstObjects[i].p2.X && e.Y >= lstObjects[i].p1.Y && e.Y <= lstObjects[i].p1.Y + 3) conner = 2;
                        else conner = 3;
                        bResize = true;
                        bMove = false;
                        k = i;
                        pos = e.Location;
                        p1_select = lstObjects[i].p1;
                        p2_select = lstObjects[i].p2;
                        this.Cursor = Cursors.Cross;
                    }
                }
                for (int i = 0; i < lstSelects.Count; i++)
                {
                    if (lstSelects[i].p1.X + 3 < e.X && lstSelects[i].p1.Y + 3 < e.Y && lstSelects[i].p2.X - 3 > e.X && lstSelects[i].p2.Y - 3 > e.Y && k_Selects == -1)
                    {
                        k_Selects = i;
                        bMove = true;
                        pos = e.Location;
                        p1_select = lstSelects[i].p1;
                        p2_select = lstSelects[i].p2;
                        this.Cursor = Cursors.SizeAll;
                    }
                    else if (e.X >= lstSelects[i].p1.X && e.X <= lstSelects[i].p1.X + 3 && e.Y >= lstSelects[i].p1.Y && e.Y <= lstSelects[i].p1.Y + 3
                        || e.X >= lstSelects[i].p2.X - 3 && e.X <= lstSelects[i].p2.X && e.Y >= lstSelects[i].p2.Y - 3 && e.Y <= lstSelects[i].p2.Y)
                    {
                        if (e.X >= lstSelects[i].p2.X - 3 && e.X <= lstSelects[i].p2.X && e.Y >= lstSelects[i].p2.Y - 3 && e.Y <= lstSelects[i].p2.Y)
                        {
                            conner = 4;
                        }
                        else conner = 1;
                        bResize = true;
                        k_Selects = i;
                        pos = e.Location;
                        p1_select = lstSelects[i].p1;
                        p2_select = lstSelects[i].p2;
                        this.Cursor = Cursors.Cross;
                    }
                    else if (e.X >= lstSelects[i].p2.X - 3 && e.X <= lstSelects[i].p2.X && e.Y >= lstSelects[i].p1.Y && e.Y <= lstSelects[i].p1.Y + 3
                        || e.X >= lstSelects[i].p1.X && e.X <= lstSelects[i].p1.X + 3 && e.Y >= lstSelects[i].p2.Y - 3 && e.Y <= lstSelects[i].p2.Y)
                    {
                        if (e.X >= lstSelects[i].p2.X - 3 && e.X <= lstSelects[i].p2.X && e.Y >= lstSelects[i].p1.Y && e.Y <= lstSelects[i].p1.Y + 3) conner = 2;
                        else conner = 3;
                        bResize = true;
                        k_Selects = i;
                        pos = e.Location;
                        p1_select = lstSelects[i].p1;
                        p2_select = lstSelects[i].p2;
                        this.Cursor = Cursors.Cross;
                    }
                }
            }
            else if (bS_Remove == true)
            {
                isPress = true;
                clsDrawObject obj;
                obj = new clsDrawRecFrameDash();
                obj.p1 = e.Location;
                obj.p2 = e.Location;
                obj.maunet = Maunet();
                obj.size = Size();
                this.lstObjects.Add(obj);
            }
            else if (bS_Ctrl == true)
            {
                bool check = true;
                if (Control.ModifierKeys == Keys.Control)
                {
                    for (int i = 0; i < lstObjects.Count; i++)
                    {
                        if (lstObjects[i].p1.X <= e.Location.X && lstObjects[i].p1.Y <= e.Location.Y &&
                            lstObjects[i].p2.X >= e.Location.X && lstObjects[i].p2.Y >= e.Location.Y)
                        {
                            for (int j = 0; j < lstSelects.Count; j++)
                            {
                                if (lstSelects[j].index == i)
                                {
                                    check = false;
                                }
                            }
                            if (check == true)
                            {
                                clsDrawObject obj;
                                obj = new clsDrawRecFrameDash();
                                obj.p1 = lstObjects[i].p1;
                                obj.p2 = lstObjects[i].p2;
                                obj.maunet = Color.Black;
                                if (lstObjects[i] is clsDrawRecFrame || lstObjects[i] is clsDrawRec)
                                {
                                    obj.maunet = Color.White;
                                    obj.maunet = Color.White;
                                }
                                obj.size = Size();
                                obj.index = i;
                                this.lstSelects.Add(obj);
                                pnl_main.Refresh();
                            }
                        }
                    }
                }
                else
                {
                    lstSelects.Clear();
                    pnl_main.Refresh();
                }

            }
        }
        private void pnl_main_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < lstObjects.Count(); i++)
            {
                if (e.X >= lstObjects[i].p1.X && e.X <= lstObjects[i].p1.X + 3 && e.Y >= lstObjects[i].p1.Y && e.Y <= lstObjects[i].p1.Y + 3
                    || e.X >= lstObjects[i].p2.X - 3 && e.X <= lstObjects[i].p2.X && e.Y >= lstObjects[i].p2.Y - 3 && e.Y <= lstObjects[i].p2.Y
                    || e.X >= lstObjects[i].p2.X - 3 && e.X <= lstObjects[i].p2.X && e.Y >= lstObjects[i].p1.Y && e.Y <= lstObjects[i].p1.Y + 3
                    || e.X >= lstObjects[i].p1.X && e.X <= lstObjects[i].p1.X + 3 && e.Y >= lstObjects[i].p2.Y - 3 && e.Y <= lstObjects[i].p2.Y)
                {
                    this.Cursor = Cursors.Cross;
                }
                else this.Cursor = Cursors.Default;
            } // zoom in/out
            if (isPress == true)
            {

                if (lstObjects[lstObjects.Count - 1] is clsDrawArc)
                {
                    if (count_Arc == 0)
                    {
                        lstObjects[lstObjects.Count - 1].p2 = e.Location;
                        lstObjects[lstObjects.Count - 1].points_Arc[2] = lstObjects[lstObjects.Count - 1].p2;
                        lstObjects[lstObjects.Count - 1].points_Arc[1] = new Point((lstObjects[lstObjects.Count - 1].p1.X + lstObjects[lstObjects.Count - 1].p2.X) / 2,
                            (lstObjects[lstObjects.Count - 1].p1.Y + lstObjects[lstObjects.Count - 1].p2.Y) / 2);
                    }
                    else
                    {
                        lstObjects[lstObjects.Count - 1].points_Arc[1] = e.Location;
                        pnl_main.Refresh();
                    }
                }
                else
                {
                    lstObjects[lstObjects.Count - 1].p2 = e.Location;
                    if (lstObjects[lstObjects.Count - 1] is clsDrawPolygon || lstObjects[lstObjects.Count - 1] is clsDrawPolygonFilled)
                    {
                        float distance = (float)Math.Sqrt(Math.Pow(lstObjects[lstObjects.Count - 1].p2.X - lstObjects[lstObjects.Count - 1].p1.X, 2) 
                            + Math.Pow(lstObjects[lstObjects.Count - 1].p2.Y - lstObjects[lstObjects.Count - 1].p1.Y, 2));
                        float angle = (float)Math.Atan2(lstObjects[lstObjects.Count - 1].p2.Y - lstObjects[lstObjects.Count - 1].p1.Y,
                            lstObjects[lstObjects.Count - 1].p2.X - lstObjects[lstObjects.Count - 1].p1.X);
                        for (int i = 0; i < 5; i++)
                        {
                            float x = (float)(lstObjects[lstObjects.Count - 1].p1.X + distance * Math.Cos(angle + i * 2 * Math.PI / 5));
                            float y = (float)(lstObjects[lstObjects.Count - 1].p1.Y + distance * Math.Sin(angle + i * 2 * Math.PI / 5));
                            lstObjects[lstObjects.Count - 1].pentagonVertices[i] = new PointF(x, y);
                        }
                    }
                }
                pnl_main.Refresh();
            }
            else if (bMove == true && k != -1)
            {
                lstObjects[k].p1.X = p1_select.X + e.X - pos.X;
                lstObjects[k].p1.Y = p1_select.Y + e.Y - pos.Y;
                lstObjects[k].p2.X = p2_select.X + e.X - pos.X;
                lstObjects[k].p2.Y = p2_select.Y + e.Y - pos.Y;
                if (k_Selects != -1)
                {
                    lstSelects[k_Selects].p1.X = p1_select.X + e.X - pos.X;
                    lstSelects[k_Selects].p1.Y = p1_select.Y + e.Y - pos.Y;
                    lstSelects[k_Selects].p2.X = p2_select.X + e.X - pos.X;
                    lstSelects[k_Selects].p2.Y = p2_select.Y + e.Y - pos.Y;
                }
                pnl_main.Refresh();
            }
            else if (bResize == true && k != -1)
            {
                if (conner == 1)
                {
                    lstObjects[k].p1 = e.Location;
                }
                else if (conner == 4)
                {
                    lstObjects[k].p2 = e.Location;
                }
                else if (conner == 2)
                {
                    lstObjects[k].p2.X = e.Location.X;
                    lstObjects[k].p1.Y = e.Location.Y;
                }
                else if (conner == 3)
                {
                    lstObjects[k].p1.X = e.Location.X;
                    lstObjects[k].p2.Y = e.Location.Y;
                }

                if (k_Selects != -1)
                {
                    if (conner == 1)
                    {
                        lstSelects[k_Selects].p1 = e.Location;
                    }
                    else if (conner == 4)
                    {
                        lstSelects[k_Selects].p2 = e.Location;
                    }
                    else if (conner == 2)
                    {
                        lstSelects[k_Selects].p2.X = e.Location.X;
                        lstSelects[k_Selects].p1.Y = e.Location.Y;
                    }
                    else if (conner == 3)
                    {
                        lstSelects[k_Selects].p1.X = e.Location.X;
                        lstSelects[k_Selects].p2.Y = e.Location.Y;
                    }
                }
                pnl_main.Refresh();
            }
        }
        private void pnl_main_MouseUp(object sender, MouseEventArgs e)
        {
            if (isPress == true)
            {
                if (lstObjects[lstObjects.Count - 1] is clsDrawArc)
                {
                    if (count_Arc == 0)
                    {
                        this.lstObjects[lstObjects.Count - 1].p2 = e.Location;
                        lstObjects[lstObjects.Count - 1].points_Arc[2] = lstObjects[lstObjects.Count - 1].p2;
                        lstObjects[lstObjects.Count - 1].points_Arc[1] = new Point((lstObjects[lstObjects.Count - 1].p1.X + lstObjects[lstObjects.Count - 1].p2.X) / 2,
                            (lstObjects[lstObjects.Count - 1].p1.Y + lstObjects[lstObjects.Count - 1].p2.Y) / 2);
                        count_Arc = 1;
                    }
                    else
                    {
                        lstObjects[lstObjects.Count - 1].points_Arc[1] = e.Location;
                        pnl_main.Refresh();
                        count_Arc = 0;
                    }
                }
                else
                {
                    this.lstObjects[lstObjects.Count - 1].p2 = e.Location;
                    if (lstObjects[lstObjects.Count - 1] is clsDrawPolygon || lstObjects[lstObjects.Count - 1] is clsDrawPolygonFilled)
                    {
                        float distance = (float)Math.Sqrt(Math.Pow(lstObjects[lstObjects.Count - 1].p2.X - lstObjects[lstObjects.Count - 1].p1.X, 2) + 
                            Math.Pow(lstObjects[lstObjects.Count - 1].p2.Y - lstObjects[lstObjects.Count - 1].p1.Y, 2));
                        float angle = (float)Math.Atan2(lstObjects[lstObjects.Count - 1].p2.Y - lstObjects[lstObjects.Count - 1].p1.Y,
                            lstObjects[lstObjects.Count - 1].p2.X - lstObjects[lstObjects.Count - 1].p1.X);
                        for (int i = 0; i < 5; i++)
                        {
                            float x = (float)(lstObjects[lstObjects.Count - 1].p1.X + distance * Math.Cos(angle + i * 2 * Math.PI / 5));
                            float y = (float)(lstObjects[lstObjects.Count - 1].p1.Y + distance * Math.Sin(angle + i * 2 * Math.PI / 5));
                            lstObjects[lstObjects.Count - 1].pentagonVertices[i] = new PointF(x, y);
                        }
                    }
                }
            }
            else if (bMove == true)
            {
                if (k != -1)
                {
                    lstObjects[k].p1.X = p1_select.X + e.X - pos.X;
                    lstObjects[k].p1.Y = p1_select.Y + e.Y - pos.Y;
                    lstObjects[k].p2.X = p2_select.X + e.X - pos.X;
                    lstObjects[k].p2.Y = p2_select.Y + e.Y - pos.Y;
                }
                k = -1;

                if (k_Selects != -1)
                {
                    lstSelects[k_Selects].p1.X = p1_select.X + e.X - pos.X;
                    lstSelects[k_Selects].p1.Y = p1_select.Y + e.Y - pos.Y;
                    lstSelects[k_Selects].p2.X = p2_select.X + e.X - pos.X;
                    lstSelects[k_Selects].p2.Y = p2_select.Y + e.Y - pos.Y;
                }
                k_Selects = -1;
            }
            else if (bResize == true)
            {
                if (k != -1)
                {
                    if (conner == 1)
                    {
                        lstObjects[k].p1 = e.Location;
                    }
                    else if (conner == 4)
                    {
                        lstObjects[k].p2 = e.Location;
                    }
                    else if (conner == 2)
                    {
                        lstObjects[k].p2.X = e.Location.X;
                        lstObjects[k].p1.Y = e.Location.Y;
                    }
                    else if (conner == 3)
                    {
                        lstObjects[k].p1.X = e.Location.X;
                        lstObjects[k].p2.Y = e.Location.Y;
                    }
                }
                k = -1;
                if (k_Selects != -1)
                {
                    if (conner == 1)
                    {
                        lstSelects[k_Selects].p1 = e.Location;
                    }
                    else if (conner == 4)
                    {
                        lstSelects[k_Selects].p2 = e.Location;
                    }
                    else if (conner == 2)
                    {
                        lstSelects[k_Selects].p2.X = e.Location.X;
                        lstSelects[k_Selects].p1.Y = e.Location.Y;
                    }
                    else if (conner == 3)
                    {
                        lstSelects[k_Selects].p1.X = e.Location.X;
                        lstSelects[k_Selects].p2.Y = e.Location.Y;
                    }
                }
                k_Selects = -1;
                pnl_main.Refresh();
            }
            if (bS_Remove == true)
            {
                bSelect = true;
                bS_Remove = false;
                int k = lstObjects.Count - 1;
                bool ok = false; //mac dinh khong chon duoc anh, neu khong thi bo het tat ca
                for (int i = 0; i < k; i++)
                {
                    // kiem tra hinh nam tron trong khung
                    if (lstObjects[i].p1.X >= lstObjects[k].p1.X && lstObjects[i].p1.Y >= lstObjects[k].p1.Y && lstObjects[i].p2.X <= lstObjects[k].p2.X && lstObjects[i].p2.Y <= lstObjects[k].p2.Y)
                    {
                        ok = true;
                        clsDrawObject obj;
                        obj = new clsDrawRecFrameDash();
                        obj.p1 = lstObjects[i].p1;
                        obj.p2 = lstObjects[i].p2;
                        obj.maunet = Color.Black;
                        if (lstObjects[i] is clsDrawRecFrame || lstObjects[i] is clsDrawRec)
                        {
                            obj.maunet = Color.White;
                            obj.maunet = Color.White;
                        }
                        obj.size = Size();
                        obj.index = i;
                        this.lstSelects.Add(obj);
                        /*MessageBox.Show(i.ToString());*/
                    }
                    else if (lstObjects[i].p1.X <= lstObjects[k].p1.X && lstObjects[i].p1.Y <= lstObjects[k].p1.Y
                        && lstObjects[i].p2.X >= lstObjects[k].p2.X && lstObjects[i].p2.Y >= lstObjects[k].p2.Y && lstObjects[k].p1 == lstObjects[k].p2)
                    {
                        ok = true;
                        clsDrawObject obj;
                        obj = new clsDrawRecFrameDash();
                        obj.p1 = lstObjects[i].p1;
                        obj.p2 = lstObjects[i].p2;
                        obj.maunet = Color.Black;
                        if (lstObjects[i] is clsDrawRecFrame || lstObjects[i] is clsDrawRec)
                        {
                            obj.maunet = Color.White;
                            obj.maunet = Color.White;
                        }
                        obj.size = Size();
                        obj.index = i;
                        this.lstSelects.Add(obj);
                    }
                }
                if (ok == false)
                {
                    lstSelects.Clear();
                }
                for (int i = 0; i < lstSelects.Count; i++)
                {
                    /*MessageBox.Show(lstSelects[i].index.ToString());*/
                    /*Console.WriteLine(lstSelects[i].index);*/
                }
                lstObjects.RemoveAt(lstObjects.Count - 1);
                pnl_main.Refresh();
            }
            isPress = false;
            this.Cursor = Cursors.Default;
            /*bSelect = false;*/
        }

    }
}

namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_tool = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ColorPen = new System.Windows.Forms.Button();
            this.btn_ColorBrush = new System.Windows.Forms.Button();
            this.pnl_Tools = new System.Windows.Forms.Panel();
            this.btnS_Remove = new System.Windows.Forms.Button();
            this.btnSelects_Ctrl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_shape = new System.Windows.Forms.Panel();
            this.btn_PolygonFilled = new System.Windows.Forms.Button();
            this.btn_Polygon = new System.Windows.Forms.Button();
            this.btn_Arc = new System.Windows.Forms.Button();
            this.btn_Ellip = new System.Windows.Forms.Button();
            this.btn_Ellipframe = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Rec = new System.Windows.Forms.Button();
            this.btn_Recframe = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_tool.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_Tools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_shape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_tool
            // 
            this.pnl_tool.Controls.Add(this.panel3);
            this.pnl_tool.Controls.Add(this.pnl_Tools);
            this.pnl_tool.Controls.Add(this.panel1);
            this.pnl_tool.Controls.Add(this.pnl_shape);
            this.pnl_tool.Location = new System.Drawing.Point(12, 12);
            this.pnl_tool.Name = "pnl_tool";
            this.pnl_tool.Size = new System.Drawing.Size(1167, 123);
            this.pnl_tool.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btn_ColorPen);
            this.panel3.Controls.Add(this.btn_ColorBrush);
            this.panel3.Location = new System.Drawing.Point(363, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 115);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Color";
            // 
            // btn_ColorPen
            // 
            this.btn_ColorPen.AllowDrop = true;
            this.btn_ColorPen.AutoSize = true;
            this.btn_ColorPen.Image = global::Paint.Properties.Resources.paint_brush;
            this.btn_ColorPen.Location = new System.Drawing.Point(3, 2);
            this.btn_ColorPen.Name = "btn_ColorPen";
            this.btn_ColorPen.Size = new System.Drawing.Size(43, 41);
            this.btn_ColorPen.TabIndex = 6;
            this.btn_ColorPen.UseVisualStyleBackColor = true;
            this.btn_ColorPen.Click += new System.EventHandler(this.btn_ColorPen_Click);
            // 
            // btn_ColorBrush
            // 
            this.btn_ColorBrush.AllowDrop = true;
            this.btn_ColorBrush.AutoSize = true;
            this.btn_ColorBrush.Image = global::Paint.Properties.Resources.paint_bucket;
            this.btn_ColorBrush.Location = new System.Drawing.Point(55, 2);
            this.btn_ColorBrush.Name = "btn_ColorBrush";
            this.btn_ColorBrush.Size = new System.Drawing.Size(43, 41);
            this.btn_ColorBrush.TabIndex = 7;
            this.btn_ColorBrush.UseVisualStyleBackColor = true;
            this.btn_ColorBrush.Click += new System.EventHandler(this.btn_ColorBrush_Click);
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.Controls.Add(this.btnS_Remove);
            this.pnl_Tools.Controls.Add(this.btnSelects_Ctrl);
            this.pnl_Tools.Controls.Add(this.label6);
            this.pnl_Tools.Location = new System.Drawing.Point(259, 3);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(98, 117);
            this.pnl_Tools.TabIndex = 3;
            // 
            // btnS_Remove
            // 
            this.btnS_Remove.Image = global::Paint.Properties.Resources.selection;
            this.btnS_Remove.Location = new System.Drawing.Point(52, 0);
            this.btnS_Remove.Name = "btnS_Remove";
            this.btnS_Remove.Size = new System.Drawing.Size(43, 41);
            this.btnS_Remove.TabIndex = 6;
            this.btnS_Remove.UseVisualStyleBackColor = true;
            this.btnS_Remove.Click += new System.EventHandler(this.btnS_Remove_Click);
            // 
            // btnSelects_Ctrl
            // 
            this.btnSelects_Ctrl.Image = global::Paint.Properties.Resources.selection_tool;
            this.btnSelects_Ctrl.Location = new System.Drawing.Point(3, 0);
            this.btnSelects_Ctrl.Name = "btnSelects_Ctrl";
            this.btnSelects_Ctrl.Size = new System.Drawing.Size(43, 41);
            this.btnSelects_Ctrl.TabIndex = 7;
            this.btnSelects_Ctrl.UseVisualStyleBackColor = true;
            this.btnSelects_Ctrl.Click += new System.EventHandler(this.btnSelects_Ctrl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tool";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_size);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(470, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 117);
            this.panel1.TabIndex = 1;
            // 
            // cmb_size
            // 
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Items.AddRange(new object[] {
            "1 px",
            "3 px",
            "5 px",
            "10 px"});
            this.cmb_size.Location = new System.Drawing.Point(3, 16);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(121, 30);
            this.cmb_size.TabIndex = 0;
            this.cmb_size.Text = "3 px";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size";
            // 
            // pnl_shape
            // 
            this.pnl_shape.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_shape.Controls.Add(this.btn_PolygonFilled);
            this.pnl_shape.Controls.Add(this.btn_Polygon);
            this.pnl_shape.Controls.Add(this.btn_Arc);
            this.pnl_shape.Controls.Add(this.btn_Ellip);
            this.pnl_shape.Controls.Add(this.btn_Ellipframe);
            this.pnl_shape.Controls.Add(this.btn_line);
            this.pnl_shape.Controls.Add(this.label2);
            this.pnl_shape.Controls.Add(this.btn_Rec);
            this.pnl_shape.Controls.Add(this.btn_Recframe);
            this.pnl_shape.Location = new System.Drawing.Point(3, 3);
            this.pnl_shape.Name = "pnl_shape";
            this.pnl_shape.Size = new System.Drawing.Size(250, 117);
            this.pnl_shape.TabIndex = 0;
            // 
            // btn_PolygonFilled
            // 
            this.btn_PolygonFilled.AllowDrop = true;
            this.btn_PolygonFilled.AutoSize = true;
            this.btn_PolygonFilled.Image = global::Paint.Properties.Resources.shape__1_;
            this.btn_PolygonFilled.Location = new System.Drawing.Point(104, 48);
            this.btn_PolygonFilled.Name = "btn_PolygonFilled";
            this.btn_PolygonFilled.Size = new System.Drawing.Size(43, 41);
            this.btn_PolygonFilled.TabIndex = 7;
            this.btn_PolygonFilled.UseVisualStyleBackColor = true;
            this.btn_PolygonFilled.Click += new System.EventHandler(this.btn_PolygonFilled_Click);
            // 
            // btn_Polygon
            // 
            this.btn_Polygon.AllowDrop = true;
            this.btn_Polygon.AutoSize = true;
            this.btn_Polygon.Image = global::Paint.Properties.Resources.shape;
            this.btn_Polygon.Location = new System.Drawing.Point(55, 48);
            this.btn_Polygon.Name = "btn_Polygon";
            this.btn_Polygon.Size = new System.Drawing.Size(43, 41);
            this.btn_Polygon.TabIndex = 6;
            this.btn_Polygon.UseVisualStyleBackColor = true;
            this.btn_Polygon.Click += new System.EventHandler(this.btn_Polygon_Click);
            // 
            // btn_Arc
            // 
            this.btn_Arc.AllowDrop = true;
            this.btn_Arc.AutoSize = true;
            this.btn_Arc.Image = global::Paint.Properties.Resources.arc;
            this.btn_Arc.Location = new System.Drawing.Point(6, 48);
            this.btn_Arc.Name = "btn_Arc";
            this.btn_Arc.Size = new System.Drawing.Size(43, 41);
            this.btn_Arc.TabIndex = 5;
            this.btn_Arc.UseVisualStyleBackColor = true;
            this.btn_Arc.Click += new System.EventHandler(this.btn_Arc_Click);
            // 
            // btn_Ellip
            // 
            this.btn_Ellip.Image = global::Paint.Properties.Resources.create__1_;
            this.btn_Ellip.Location = new System.Drawing.Point(104, 1);
            this.btn_Ellip.Name = "btn_Ellip";
            this.btn_Ellip.Size = new System.Drawing.Size(43, 41);
            this.btn_Ellip.TabIndex = 4;
            this.btn_Ellip.UseVisualStyleBackColor = true;
            this.btn_Ellip.Click += new System.EventHandler(this.btn_Ellip_Click);
            // 
            // btn_Ellipframe
            // 
            this.btn_Ellipframe.Image = global::Paint.Properties.Resources.create;
            this.btn_Ellipframe.Location = new System.Drawing.Point(55, 1);
            this.btn_Ellipframe.Name = "btn_Ellipframe";
            this.btn_Ellipframe.Size = new System.Drawing.Size(43, 41);
            this.btn_Ellipframe.TabIndex = 2;
            this.btn_Ellipframe.UseVisualStyleBackColor = true;
            this.btn_Ellipframe.Click += new System.EventHandler(this.btn_Ellipframe_Click);
            // 
            // btn_line
            // 
            this.btn_line.AllowDrop = true;
            this.btn_line.AutoSize = true;
            this.btn_line.Image = global::Paint.Properties.Resources.line;
            this.btn_line.Location = new System.Drawing.Point(6, 1);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(43, 41);
            this.btn_line.TabIndex = 0;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shape";
            // 
            // btn_Rec
            // 
            this.btn_Rec.Image = global::Paint.Properties.Resources.rectangle__1_;
            this.btn_Rec.Location = new System.Drawing.Point(202, 1);
            this.btn_Rec.Name = "btn_Rec";
            this.btn_Rec.Size = new System.Drawing.Size(43, 41);
            this.btn_Rec.TabIndex = 3;
            this.btn_Rec.UseVisualStyleBackColor = true;
            this.btn_Rec.Click += new System.EventHandler(this.btn_Rec_Click);
            // 
            // btn_Recframe
            // 
            this.btn_Recframe.Image = global::Paint.Properties.Resources.rectangle;
            this.btn_Recframe.Location = new System.Drawing.Point(153, 1);
            this.btn_Recframe.Name = "btn_Recframe";
            this.btn_Recframe.Size = new System.Drawing.Size(43, 41);
            this.btn_Recframe.TabIndex = 1;
            this.btn_Recframe.UseVisualStyleBackColor = true;
            this.btn_Recframe.Click += new System.EventHandler(this.btn_Recframe_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_main.Location = new System.Drawing.Point(11, 153);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1168, 530);
            this.pnl_main.TabIndex = 3;
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_main_Paint);
            this.pnl_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_main_MouseDown);
            this.pnl_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_main_MouseMove);
            this.pnl_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_main_MouseUp);
            this.pnl_main.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pnl_main_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 695);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_tool);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_tool.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_Tools.ResumeLayout(false);
            this.pnl_Tools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_shape.ResumeLayout(false);
            this.pnl_shape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_tool;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ColorPen;
        private System.Windows.Forms.Button btn_ColorBrush;
        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.Button btnS_Remove;
        private System.Windows.Forms.Button btnSelects_Ctrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_shape;
        private System.Windows.Forms.Button btn_PolygonFilled;
        private System.Windows.Forms.Button btn_Polygon;
        private System.Windows.Forms.Button btn_Arc;
        private System.Windows.Forms.Button btn_Ellip;
        private System.Windows.Forms.Button btn_Ellipframe;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Rec;
        private System.Windows.Forms.Button btn_Recframe;
        private System.Windows.Forms.Panel pnl_main;
    }
}


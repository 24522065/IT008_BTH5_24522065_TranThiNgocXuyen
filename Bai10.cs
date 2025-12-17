using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlDrawingArea_Paint(object sender, PaintEventArgs e)
        {
            if (cboWidth.SelectedItem == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; 

            try
            {
                float width = float.Parse(cboWidth.SelectedItem.ToString());
                DashStyle dashStyle = (DashStyle)cboDashStyle.SelectedItem;
                LineJoin lineJoin = (LineJoin)cboLineJoin.SelectedItem;
                DashCap dashCap = (DashCap)cboDashCap.SelectedItem;
                LineCap startCap = (LineCap)cboStartCap.SelectedItem;
                LineCap endCap = (LineCap)cboEndCap.SelectedItem;

                using (Pen p = new Pen(Color.Red, width))
                {
                    p.LineJoin = lineJoin;
                    p.DashCap = dashCap;
                    p.StartCap = startCap;
                    p.EndCap = endCap;

                    p.DashStyle = dashStyle;
                    if (dashStyle == DashStyle.Custom)
                    { 
                        p.DashPattern = new float[] { 4.0F, 2.0F };
                    }

                    int w = pnlDrawingArea.Width;
                    int h = pnlDrawingArea.Height;

                    Point p1 = new Point(50, 50);
                    Point p2 = new Point(w / 2 + 50, h - 100);
                    Point p3 = new Point(w - 50, 150);

                    // Vẽ đường gấp khúc qua 3 điểm
                    g.DrawLines(p, new Point[] { p1, p2, p3 });
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDashStyle.DataSource = Enum.GetValues(typeof(DashStyle));
            cboDashStyle.SelectedItem = DashStyle.DashDot; 

            // Nạp Width (số từ 1 đến 20)
            for (int i = 1; i <= 20; i++) cboWidth.Items.Add(i.ToString());
            cboWidth.SelectedIndex = 8; 

            // Nạp Enum LineJoin
            cboLineJoin.DataSource = Enum.GetValues(typeof(LineJoin));
            cboLineJoin.SelectedItem = LineJoin.Round;

            // Nạp Enum DashCap
            cboDashCap.DataSource = Enum.GetValues(typeof(DashCap));
            cboDashCap.SelectedItem = DashCap.Triangle;

            // Nạp Enum StartCap & EndCap 
            cboStartCap.DataSource = Enum.GetValues(typeof(LineCap));
            cboStartCap.SelectedItem = LineCap.Triangle;

            cboEndCap.DataSource = Enum.GetValues(typeof(LineCap));
            cboEndCap.SelectedItem = LineCap.RoundAnchor;
        }

        private void cboDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrawingArea.Invalidate();
        }

        private void cboWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrawingArea.Invalidate();
        }

        private void cboLineJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrawingArea.Invalidate();
        }

        private void cboDashCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrawingArea.Invalidate();
        }

        private void cboStartCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrawingArea.Invalidate();
        }

        private void cboEndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDrawingArea.Invalidate();
        }
        private void pnlDrawingArea_Resize(object sender, EventArgs e)
        {
            pnlDrawingArea.Invalidate();
        }
    }
}

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

namespace Bai09
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            // Chống nhấp nháy
            this.DoubleBuffered = true;
            shapeComboBox.Text = "Filled Ellipse";
        }
        private void shapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            switch (shapeComboBox.Text)
            {
                case "Circle":
                    DrawEllipse(e.Graphics, 200, 200);
                    break;

                case "Square":
                    DrawRectangle(e.Graphics, 200, 200);
                    break;

                case "Ellipse":
                    DrawEllipse(e.Graphics, 200, 100);
                    break;

                case "Pie":
                    DrawPie(e.Graphics, 200, 200, 300);
                    break;

                case "Filled Circle":
                    DrawFilledEllipse(e.Graphics, 200, 200);
                    break;

                case "Filled Square":
                    DrawFilledRectangle(e.Graphics, 200, 200);
                    break;

                case "Filled Ellipse":
                    DrawFilledEllipse(e.Graphics, 200, 100);
                    break;

                case "Filled Pie":
                    DrawFilledPie(e.Graphics, 200, 200, 300);
                    break;
            }
    }
        private void DrawEllipse(Graphics g, int width, int height)
        {
            using (Pen pen = new Pen(Color.FromArgb(139, 0, 0), 5))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawEllipse(
                    pen,
                    ClientSize.Width / 2 - width / 2,
                    ClientSize.Height / 2 - height / 2,
                    width,
                    height
                );
            }
        }

        private void DrawRectangle(Graphics g, int width, int height)
        {
            using (Pen pen = new Pen(Color.FromArgb(139, 0, 0), 5))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawRectangle(
                    pen,
                    ClientSize.Width / 2 - width / 2,
                    ClientSize.Height / 2 - height / 2,
                    width,
                    height
                );
            }
        }

        private void DrawPie(Graphics g, int width, int height, int angle)
        {
            using (Pen pen = new Pen(Color.FromArgb(139, 0, 0), 5))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawPie(
                    pen,
                    ClientSize.Width / 2 - width / 2,
                    ClientSize.Height / 2 - height / 2,
                    width,
                    height,
                    0,
                    angle
                );
            }
        }

        private void DrawFilledEllipse(Graphics g, int width, int height)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(139, 0, 0)))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillEllipse(
                    brush,
                    ClientSize.Width / 2 - width / 2,
                    ClientSize.Height / 2 - height / 2,
                    width,
                    height
                );
            }
        }

        private void DrawFilledRectangle(Graphics g, int width, int height)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(139, 0, 0)))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillRectangle(
                    brush,
                    ClientSize.Width / 2 - width / 2,
                    ClientSize.Height / 2 - height / 2,
                    width,
                    height
                );
            }
        }

        private void DrawFilledPie(Graphics g, int width, int height, int angle)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(139, 0, 0)))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPie(
                    brush,
                    ClientSize.Width / 2 - width / 2,
                    ClientSize.Height / 2 - height / 2,
                    width,
                    height,
                    0,
                    angle
                );
            }
        }
    }
}


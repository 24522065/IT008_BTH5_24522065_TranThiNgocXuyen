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

namespace Bai08
{
    public partial class Form1 : Form
    {
        private Timer timerClock;
        public Form1()
        {
            InitializeComponent();

            this.Text = "Analog Clock";
            this.Size = new Size(500, 500);
            this.BackColor = Color.Black; 

            this.DoubleBuffered = true;

            // Cài đặt Timer
            timerClock = new Timer();
            timerClock.Interval = 1000; 
            timerClock.Tick += (s, e) => { this.Invalidate(); }; 
            timerClock.Start();

            this.Resize += (s, e) => { this.Invalidate(); };
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            int radius = Math.Min(w, h) / 2 - 50;
            g.TranslateTransform(w / 2, h / 2);

            DrawClockFace(g, radius);

            DateTime now = DateTime.Now;

            DrawHands(g, radius, now);
        }

        private void DrawClockFace(Graphics g, int radius)
        {
            GraphicsState state = g.Save();

            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                for (int i = 0; i < 60; i++)
                {

                    if (i % 5 == 0)
                    {
                        g.FillEllipse(brush, -8, -radius, 16, 16);
                    }
                    else
                    {
                        g.FillEllipse(brush, -3, -radius, 6, 6);
                    }
                    g.RotateTransform(6);
                }
            }
            g.Restore(state);
        }

        private void DrawHands(Graphics g, int radius, DateTime time)
        {
            using (Pen p = new Pen(Color.White, 2))
            {
                // --- VẼ KIM GIỜ ---
                GraphicsState stateHour = g.Save(); 

                float hourAngle = (time.Hour % 12) * 30 + time.Minute * 0.5f;
                g.RotateTransform(hourAngle); 

                Point[] hourPoints = { new Point(0, 20), new Point(-10, 0), new Point(0, -radius + 60), new Point(10, 0) };
                g.DrawPolygon(p, hourPoints);

                g.Restore(stateHour);

                // --- VẼ KIM PHÚT ---
                GraphicsState stateMinute = g.Save(); 

                float minuteAngle = time.Minute * 6 + time.Second * 0.1f;
                g.RotateTransform(minuteAngle);

                Point[] minutePoints = { new Point(0, 20), new Point(-6, 0), new Point(0, -radius + 20), new Point(6, 0) };
                g.DrawPolygon(p, minutePoints);

                g.Restore(stateMinute);

                // --- VẼ KIM GIÂY ---
                GraphicsState stateSecond = g.Save();

                float secondAngle = time.Second * 6;
                g.RotateTransform(secondAngle);
                Point[] secondPoints = { new Point(0, 25), new Point(-2, 0), new Point(0, -radius + 10), new Point(2, 0) };
                g.DrawPolygon(p, secondPoints);

                g.Restore(stateSecond);
            }

            // Vẽ tâm đồng hồ
            g.FillEllipse(Brushes.Black, -5, -5, 10, 10);
            g.DrawEllipse(Pens.White, -5, -5, 10, 10);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}

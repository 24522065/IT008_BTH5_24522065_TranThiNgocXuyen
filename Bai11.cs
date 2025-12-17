using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1: Form
    {
        private Point _startPoint;      
        private Point _currentPoint;    
        private bool _isDrawing = false; 

        private Bitmap _bitmapCanvas;
        private Color _penColor = Color.Black;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bitmapCanvas = new Bitmap(picCanvas.Width, picCanvas.Height);

            using (Graphics g = Graphics.FromImage(_bitmapCanvas))
            {
                g.Clear(Color.White);
            }
            picCanvas.Image = _bitmapCanvas;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _penColor = colorDialog.Color;
                btnColor.BackColor = _penColor; 
            }
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDrawing = true;
                _startPoint = e.Location;
                _currentPoint = e.Location; 
            }
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _currentPoint = e.Location;
                picCanvas.Refresh();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _isDrawing = false;
                _currentPoint = e.Location;

                using (Graphics g = Graphics.FromImage(_bitmapCanvas))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    DoDrawing(g);
                }

                picCanvas.Refresh();
            }
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (_isDrawing)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                DoDrawing(e.Graphics);
            }
        }
        private void DoDrawing(Graphics g)
        {
            float penWidth = 1;
            float.TryParse(txtWidth.Text, out penWidth);

            using (Pen p = new Pen(_penColor, penWidth))
            {
                if (radLine.Checked)
                {
                    g.DrawLine(p, _startPoint, _currentPoint);
                }
                else
                {
                    int x = Math.Min(_startPoint.X, _currentPoint.X);
                    int y = Math.Min(_startPoint.Y, _currentPoint.Y);
                    int width = Math.Abs(_startPoint.X - _currentPoint.X);
                    int height = Math.Abs(_startPoint.Y - _currentPoint.Y);
                    Rectangle rect = new Rectangle(x, y, width, height);

                    if (width == 0 || height == 0) return;

                    Brush brush = null;

                    if (radSolid.Checked)
                    {
                        brush = new SolidBrush(Color.Green);
                    }
                    else if (radHatch.Checked)
                    {
                        brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
                    }
                    else if (radTexture.Checked)
                    {
                        Bitmap textureImg = new Bitmap(20, 20);
                        using (Graphics gt = Graphics.FromImage(textureImg))
                        {
                            gt.Clear(Color.White);
                            gt.FillRectangle(Brushes.Gray, 0, 0, 10, 10); // Tạo họa tiết caro
                            gt.FillRectangle(Brushes.Gray, 10, 10, 10, 10);
                        }
                        brush = new TextureBrush(textureImg);
                    }
                    else if (radGradient.Checked)
                    {
                        brush = new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
                    }

                    if (radRect.Checked)
                    {
                        if (brush != null) g.FillRectangle(brush, rect); 
                    }
                    else if (radEllipse.Checked)
                    {
                        if (brush != null) g.FillEllipse(brush, rect);  
                    }
                    if (brush != null) brush.Dispose();
                }
            }
        }

    }
}

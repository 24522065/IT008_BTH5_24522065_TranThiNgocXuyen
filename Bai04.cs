using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1: Form
    {
        Color textColor;
        string fontName;
        int fontSize;
        FontStyle fontStyle;
        enum textAlign { left, center, right};
        textAlign align;


        public Form1()
        {
            InitializeComponent();

            textColor = Color.Red;
            fontName = "Arial";
            fontSize = 14;
            fontStyle = FontStyle.Regular;
            align = textAlign.center;
        }

        void drawString(Graphics g,Color color, string fontName, int fontSize, FontStyle fontStyle, textAlign align)
        { 
            Font font = new Font(fontName, fontSize, fontStyle);
            Brush brush = new SolidBrush(color);
            SizeF size = g.MeasureString("Hello", font);
            float x;
            switch (align)
            {
                case textAlign.left:
                    x = 0;
                    break;
                case textAlign.right:
                    x = panel1.Width - size.Width;
                    break;
                default:
                    x = (panel1.Width - size.Width) / 2;
                    break;
            }

            float y = (panel1.Height - size.Height) / 2;

            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.DrawString("Hello", font, brush, x, y);
        }
        private void italic_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Italic;
            panel1.Refresh();
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontName=fontComboBox.SelectedItem.ToString();
            panel1.Refresh();
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sizeComboBox.Text.ToString()=="" || sizeComboBox.Text.ToString()=="0")
            {
                fontSize = 1;
            }else fontSize= int.Parse(sizeComboBox.Text.ToString());
            panel1.Refresh();
        }

        private void left_CheckedChanged(object sender, EventArgs e)
        {
            align = textAlign.left;
            panel1.Refresh();
        }

        private void center_CheckedChanged(object sender, EventArgs e)
        {
            align= textAlign.center;
            panel1.Refresh();
        }

        private void right_CheckedChanged(object sender, EventArgs e)
        {
            align=textAlign.right;
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            drawString(e.Graphics, textColor, fontName, fontSize, fontStyle, align);
        }

        private void color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if(colorDlg.ShowDialog() == DialogResult.OK)
            {
                textColor = colorDlg.Color;
                color.BackColor = textColor;
                panel1.Refresh();
            }
        }
        private void underlined_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Underline;
            panel1.Refresh();
        }

        private void bold_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Bold;
            panel1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(FontFamily font in System.Drawing.FontFamily.Families)
            {
                fontComboBox.Items.Add(font.Name);
            }
            for (int i=1; i<99; i++)
            {
                sizeComboBox.Items.Add(i);
            }
            fontComboBox.SelectedItem = "Arial";
            sizeComboBox.Text = "28";
        }
    }
}

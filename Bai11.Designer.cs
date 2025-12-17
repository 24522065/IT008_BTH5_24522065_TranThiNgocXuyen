namespace Bai11
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radGradient = new System.Windows.Forms.RadioButton();
            this.radTexture = new System.Windows.Forms.RadioButton();
            this.radHatch = new System.Windows.Forms.RadioButton();
            this.radSolid = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEllipse = new System.Windows.Forms.RadioButton();
            this.radRect = new System.Windows.Forms.RadioButton();
            this.radLine = new System.Windows.Forms.RadioButton();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Beige;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picCanvas);
            this.splitContainer1.Size = new System.Drawing.Size(1156, 772);
            this.splitContainer1.SplitterDistance = 385;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radGradient);
            this.groupBox3.Controls.Add(this.radTexture);
            this.groupBox3.Controls.Add(this.radHatch);
            this.groupBox3.Controls.Add(this.radSolid);
            this.groupBox3.Location = new System.Drawing.Point(43, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 315);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // radGradient
            // 
            this.radGradient.AutoSize = true;
            this.radGradient.Location = new System.Drawing.Point(31, 248);
            this.radGradient.Name = "radGradient";
            this.radGradient.Size = new System.Drawing.Size(182, 24);
            this.radGradient.TabIndex = 3;
            this.radGradient.Text = "LinearGradientBrush";
            this.radGradient.UseVisualStyleBackColor = true;
            // 
            // radTexture
            // 
            this.radTexture.AutoSize = true;
            this.radTexture.Location = new System.Drawing.Point(31, 184);
            this.radTexture.Name = "radTexture";
            this.radTexture.Size = new System.Drawing.Size(129, 24);
            this.radTexture.TabIndex = 2;
            this.radTexture.Text = "TextureBrush";
            this.radTexture.UseVisualStyleBackColor = true;
            // 
            // radHatch
            // 
            this.radHatch.AutoSize = true;
            this.radHatch.Location = new System.Drawing.Point(31, 112);
            this.radHatch.Name = "radHatch";
            this.radHatch.Size = new System.Drawing.Size(119, 24);
            this.radHatch.TabIndex = 1;
            this.radHatch.Text = "HatchBrush";
            this.radHatch.UseVisualStyleBackColor = true;
            // 
            // radSolid
            // 
            this.radSolid.AutoSize = true;
            this.radSolid.Checked = true;
            this.radSolid.Location = new System.Drawing.Point(31, 43);
            this.radSolid.Name = "radSolid";
            this.radSolid.Size = new System.Drawing.Size(111, 24);
            this.radSolid.TabIndex = 0;
            this.radSolid.TabStop = true;
            this.radSolid.Text = "SolidBrush";
            this.radSolid.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(43, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(65, 74);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(121, 35);
            this.btnColor.TabIndex = 2;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(109, 26);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(121, 26);
            this.txtWidth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEllipse);
            this.groupBox1.Controls.Add(this.radRect);
            this.groupBox1.Controls.Add(this.radLine);
            this.groupBox1.Location = new System.Drawing.Point(43, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // radEllipse
            // 
            this.radEllipse.AutoSize = true;
            this.radEllipse.Location = new System.Drawing.Point(22, 134);
            this.radEllipse.Name = "radEllipse";
            this.radEllipse.Size = new System.Drawing.Size(80, 24);
            this.radEllipse.TabIndex = 2;
            this.radEllipse.TabStop = true;
            this.radEllipse.Text = "Ellipse";
            this.radEllipse.UseVisualStyleBackColor = true;
            // 
            // radRect
            // 
            this.radRect.AutoSize = true;
            this.radRect.Location = new System.Drawing.Point(22, 87);
            this.radRect.Name = "radRect";
            this.radRect.Size = new System.Drawing.Size(107, 24);
            this.radRect.TabIndex = 1;
            this.radRect.TabStop = true;
            this.radRect.Text = "Rectangle";
            this.radRect.UseVisualStyleBackColor = true;
            // 
            // radLine
            // 
            this.radLine.AutoSize = true;
            this.radLine.Location = new System.Drawing.Point(22, 40);
            this.radLine.Name = "radLine";
            this.radLine.Size = new System.Drawing.Size(64, 24);
            this.radLine.TabIndex = 0;
            this.radLine.TabStop = true;
            this.radLine.Text = "Line";
            this.radLine.UseVisualStyleBackColor = true;
            // 
            // picCanvas
            // 
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(767, 772);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 772);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radEllipse;
        private System.Windows.Forms.RadioButton radRect;
        private System.Windows.Forms.RadioButton radLine;
        private System.Windows.Forms.RadioButton radGradient;
        private System.Windows.Forms.RadioButton radTexture;
        private System.Windows.Forms.RadioButton radHatch;
        private System.Windows.Forms.RadioButton radSolid;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}


namespace Bai10
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEndCap = new System.Windows.Forms.ComboBox();
            this.cboStartCap = new System.Windows.Forms.ComboBox();
            this.cboDashCap = new System.Windows.Forms.ComboBox();
            this.cboLineJoin = new System.Windows.Forms.ComboBox();
            this.cboWidth = new System.Windows.Forms.ComboBox();
            this.cboDashStyle = new System.Windows.Forms.ComboBox();
            this.pnlDrawingArea = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboEndCap);
            this.panel1.Controls.Add(this.cboStartCap);
            this.panel1.Controls.Add(this.cboDashCap);
            this.panel1.Controls.Add(this.cboLineJoin);
            this.panel1.Controls.Add(this.cboWidth);
            this.panel1.Controls.Add(this.cboDashStyle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 450);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "End Cap:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start Cap:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dash Cap:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Line Join:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dash Style:";
            // 
            // cboEndCap
            // 
            this.cboEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEndCap.FormattingEnabled = true;
            this.cboEndCap.Location = new System.Drawing.Point(167, 384);
            this.cboEndCap.Name = "cboEndCap";
            this.cboEndCap.Size = new System.Drawing.Size(142, 28);
            this.cboEndCap.TabIndex = 5;
            this.cboEndCap.SelectedIndexChanged += new System.EventHandler(this.cboEndCap_SelectedIndexChanged);
            // 
            // cboStartCap
            // 
            this.cboStartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartCap.FormattingEnabled = true;
            this.cboStartCap.Location = new System.Drawing.Point(167, 308);
            this.cboStartCap.Name = "cboStartCap";
            this.cboStartCap.Size = new System.Drawing.Size(142, 28);
            this.cboStartCap.TabIndex = 4;
            this.cboStartCap.SelectedIndexChanged += new System.EventHandler(this.cboStartCap_SelectedIndexChanged);
            // 
            // cboDashCap
            // 
            this.cboDashCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDashCap.FormattingEnabled = true;
            this.cboDashCap.Location = new System.Drawing.Point(167, 229);
            this.cboDashCap.Name = "cboDashCap";
            this.cboDashCap.Size = new System.Drawing.Size(142, 28);
            this.cboDashCap.TabIndex = 3;
            this.cboDashCap.SelectedIndexChanged += new System.EventHandler(this.cboDashCap_SelectedIndexChanged);
            // 
            // cboLineJoin
            // 
            this.cboLineJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineJoin.FormattingEnabled = true;
            this.cboLineJoin.Location = new System.Drawing.Point(167, 154);
            this.cboLineJoin.Name = "cboLineJoin";
            this.cboLineJoin.Size = new System.Drawing.Size(142, 28);
            this.cboLineJoin.TabIndex = 2;
            this.cboLineJoin.SelectedIndexChanged += new System.EventHandler(this.cboLineJoin_SelectedIndexChanged);
            // 
            // cboWidth
            // 
            this.cboWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWidth.FormattingEnabled = true;
            this.cboWidth.Location = new System.Drawing.Point(167, 83);
            this.cboWidth.Name = "cboWidth";
            this.cboWidth.Size = new System.Drawing.Size(142, 28);
            this.cboWidth.TabIndex = 1;
            this.cboWidth.SelectedIndexChanged += new System.EventHandler(this.cboWidth_SelectedIndexChanged);
            // 
            // cboDashStyle
            // 
            this.cboDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDashStyle.FormattingEnabled = true;
            this.cboDashStyle.Location = new System.Drawing.Point(167, 25);
            this.cboDashStyle.Name = "cboDashStyle";
            this.cboDashStyle.Size = new System.Drawing.Size(142, 28);
            this.cboDashStyle.TabIndex = 0;
            this.cboDashStyle.SelectedIndexChanged += new System.EventHandler(this.cboDashStyle_SelectedIndexChanged);
            // 
            // pnlDrawingArea
            // 
            this.pnlDrawingArea.BackColor = System.Drawing.Color.White;
            this.pnlDrawingArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDrawingArea.Location = new System.Drawing.Point(326, 0);
            this.pnlDrawingArea.Name = "pnlDrawingArea";
            this.pnlDrawingArea.Size = new System.Drawing.Size(474, 450);
            this.pnlDrawingArea.TabIndex = 1;
            this.pnlDrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawingArea_Paint);
            this.pnlDrawingArea.Resize += new System.EventHandler(this.pnlDrawingArea_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDrawingArea);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Pen Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboEndCap;
        private System.Windows.Forms.ComboBox cboStartCap;
        private System.Windows.Forms.ComboBox cboDashCap;
        private System.Windows.Forms.ComboBox cboLineJoin;
        private System.Windows.Forms.ComboBox cboWidth;
        private System.Windows.Forms.ComboBox cboDashStyle;
        private System.Windows.Forms.Panel pnlDrawingArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


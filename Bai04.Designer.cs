namespace Bai04
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
            this.label1 = new System.Windows.Forms.Label();
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.bold = new System.Windows.Forms.CheckBox();
            this.italic = new System.Windows.Forms.CheckBox();
            this.underlined = new System.Windows.Forms.CheckBox();
            this.color = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.right = new System.Windows.Forms.RadioButton();
            this.center = new System.Windows.Forms.RadioButton();
            this.left = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // fontComboBox
            // 
            this.fontComboBox.FormattingEnabled = true;
            this.fontComboBox.Location = new System.Drawing.Point(96, 10);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(121, 28);
            this.fontComboBox.TabIndex = 1;
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(386, 13);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(121, 28);
            this.sizeComboBox.TabIndex = 3;
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
            // 
            // bold
            // 
            this.bold.AutoSize = true;
            this.bold.Location = new System.Drawing.Point(31, 71);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(46, 24);
            this.bold.TabIndex = 4;
            this.bold.Text = "B";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.CheckedChanged += new System.EventHandler(this.bold_CheckedChanged);
            // 
            // italic
            // 
            this.italic.AutoSize = true;
            this.italic.Location = new System.Drawing.Point(96, 71);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(40, 24);
            this.italic.TabIndex = 5;
            this.italic.Text = "I";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.CheckedChanged += new System.EventHandler(this.italic_CheckedChanged);
            // 
            // underlined
            // 
            this.underlined.AutoSize = true;
            this.underlined.Location = new System.Drawing.Point(160, 71);
            this.underlined.Name = "underlined";
            this.underlined.Size = new System.Drawing.Size(47, 24);
            this.underlined.TabIndex = 6;
            this.underlined.Text = "U";
            this.underlined.UseVisualStyleBackColor = true;
            this.underlined.CheckedChanged += new System.EventHandler(this.underlined_CheckedChanged);
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(421, 70);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(33, 23);
            this.color.TabIndex = 7;
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.right);
            this.groupBox1.Controls.Add(this.center);
            this.groupBox1.Controls.Add(this.left);
            this.groupBox1.Location = new System.Drawing.Point(31, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align Text";
            // 
            // right
            // 
            this.right.AutoSize = true;
            this.right.Location = new System.Drawing.Point(7, 119);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(72, 24);
            this.right.TabIndex = 2;
            this.right.TabStop = true;
            this.right.Text = "Right";
            this.right.UseVisualStyleBackColor = true;
            this.right.CheckedChanged += new System.EventHandler(this.right_CheckedChanged);
            // 
            // center
            // 
            this.center.AutoSize = true;
            this.center.Location = new System.Drawing.Point(7, 74);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(82, 24);
            this.center.TabIndex = 1;
            this.center.TabStop = true;
            this.center.Text = "Center";
            this.center.UseVisualStyleBackColor = true;
            this.center.CheckedChanged += new System.EventHandler(this.center_CheckedChanged);
            // 
            // left
            // 
            this.left.AutoSize = true;
            this.left.Location = new System.Drawing.Point(7, 26);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(62, 24);
            this.left.TabIndex = 0;
            this.left.TabStop = true;
            this.left.Text = "Left";
            this.left.UseVisualStyleBackColor = true;
            this.left.CheckedChanged += new System.EventHandler(this.left_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(327, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 250);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.color);
            this.Controls.Add(this.underlined);
            this.Controls.Add(this.italic);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fontComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.CheckBox italic;
        private System.Windows.Forms.CheckBox underlined;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton right;
        private System.Windows.Forms.RadioButton center;
        private System.Windows.Forms.RadioButton left;
        private System.Windows.Forms.Panel panel1;
    }
}


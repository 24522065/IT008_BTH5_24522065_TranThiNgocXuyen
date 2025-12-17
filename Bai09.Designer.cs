namespace Bai09
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
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // shapeComboBox
            // 
            this.shapeComboBox.FormattingEnabled = true;
            this.shapeComboBox.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Ellipse",
            "Pie",
            "Filled Circle",
            "Filled Square",
            "Filled Ellipse",
            "Filled Pie"});
            this.shapeComboBox.Location = new System.Drawing.Point(26, 29);
            this.shapeComboBox.Name = "shapeComboBox";
            this.shapeComboBox.Size = new System.Drawing.Size(196, 28);
            this.shapeComboBox.TabIndex = 0;
            this.shapeComboBox.SelectedIndexChanged += new System.EventHandler(this.shapeComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shapeComboBox);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "ComboBox Test";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox shapeComboBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


namespace Bai06
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
            this.fontTextBox = new System.Windows.Forms.RichTextBox();
            this.loadingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fontTextBox
            // 
            this.fontTextBox.Location = new System.Drawing.Point(0, 0);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.Size = new System.Drawing.Size(800, 450);
            this.fontTextBox.TabIndex = 0;
            this.fontTextBox.Text = "";
            // 
            // loadingButton
            // 
            this.loadingButton.Location = new System.Drawing.Point(697, 12);
            this.loadingButton.Name = "loadingButton";
            this.loadingButton.Size = new System.Drawing.Size(75, 29);
            this.loadingButton.TabIndex = 1;
            this.loadingButton.Text = "Font chữ";
            this.loadingButton.UseVisualStyleBackColor = true;
            this.loadingButton.Click += new System.EventHandler(this.loadingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadingButton);
            this.Controls.Add(this.fontTextBox);
            this.Name = "Form1";
            this.Text = "All Fonts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox fontTextBox;
        private System.Windows.Forms.Button loadingButton;
    }
}


namespace LMS
{
    partial class A_Up_Rule
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
            this.R_ID__label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Feedback_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // R_ID__label
            // 
            this.R_ID__label.AutoSize = true;
            this.R_ID__label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_ID__label.ForeColor = System.Drawing.Color.White;
            this.R_ID__label.Location = new System.Drawing.Point(265, 149);
            this.R_ID__label.Name = "R_ID__label";
            this.R_ID__label.Size = new System.Drawing.Size(90, 23);
            this.R_ID__label.TabIndex = 20;
            this.R_ID__label.Text = "RULE ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(385, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(501, 22);
            this.textBox2.TabIndex = 19;
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.White;
            this.Clear_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.Location = new System.Drawing.Point(600, 492);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(151, 61);
            this.Clear_button.TabIndex = 18;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Feedback_button
            // 
            this.Feedback_button.BackColor = System.Drawing.Color.White;
            this.Feedback_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedback_button.Location = new System.Drawing.Point(804, 492);
            this.Feedback_button.Name = "Feedback_button";
            this.Feedback_button.Size = new System.Drawing.Size(151, 61);
            this.Feedback_button.TabIndex = 17;
            this.Feedback_button.Text = "UPDATE";
            this.Feedback_button.UseVisualStyleBackColor = false;
            this.Feedback_button.Click += new System.EventHandler(this.Feedback_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(269, 212);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(617, 236);
            this.textBox1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Screenshot__24_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // A_Up_Rule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 818);
            this.Controls.Add(this.R_ID__label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Feedback_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_Up_Rule";
            this.Text = "A_Up_Rule";
            this.Load += new System.EventHandler(this.A_Up_Rule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label R_ID__label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Feedback_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
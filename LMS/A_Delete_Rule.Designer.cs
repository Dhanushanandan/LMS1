namespace LMS
{
    partial class A_Delete_Rule
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
            this.Delete_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Deleet_All_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // R_ID__label
            // 
            this.R_ID__label.AutoSize = true;
            this.R_ID__label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_ID__label.ForeColor = System.Drawing.Color.White;
            this.R_ID__label.Location = new System.Drawing.Point(258, 355);
            this.R_ID__label.Name = "R_ID__label";
            this.R_ID__label.Size = new System.Drawing.Size(90, 23);
            this.R_ID__label.TabIndex = 26;
            this.R_ID__label.Text = "RULE ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(378, 357);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(501, 22);
            this.textBox2.TabIndex = 25;
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.White;
            this.Delete_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.Location = new System.Drawing.Point(794, 468);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(151, 61);
            this.Delete_button.TabIndex = 23;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Screenshot__24_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Deleet_All_button
            // 
            this.Deleet_All_button.BackColor = System.Drawing.Color.White;
            this.Deleet_All_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deleet_All_button.Location = new System.Drawing.Point(590, 468);
            this.Deleet_All_button.Name = "Deleet_All_button";
            this.Deleet_All_button.Size = new System.Drawing.Size(151, 61);
            this.Deleet_All_button.TabIndex = 24;
            this.Deleet_All_button.Text = "Delete All Rules";
            this.Deleet_All_button.UseVisualStyleBackColor = false;
            this.Deleet_All_button.Click += new System.EventHandler(this.Deleet_All_button_Click);
            // 
            // A_Delete_Rule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 818);
            this.Controls.Add(this.R_ID__label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Deleet_All_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_Delete_Rule";
            this.Text = "A_Delete_Rule";
            this.Load += new System.EventHandler(this.A_Delete_Rule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label R_ID__label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Deleet_All_button;
    }
}
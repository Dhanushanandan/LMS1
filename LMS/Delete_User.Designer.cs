namespace LMS
{
    partial class Delete_User
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.User_ID_label = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.All_Delete_button = new System.Windows.Forms.Button();
            this.D_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LMS.Properties.Resources.User_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(440, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // User_ID_label
            // 
            this.User_ID_label.AutoSize = true;
            this.User_ID_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_ID_label.ForeColor = System.Drawing.Color.White;
            this.User_ID_label.Location = new System.Drawing.Point(252, 366);
            this.User_ID_label.Name = "User_ID_label";
            this.User_ID_label.Size = new System.Drawing.Size(76, 23);
            this.User_ID_label.TabIndex = 34;
            this.User_ID_label.Text = "User ID";
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.White;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.Location = new System.Drawing.Point(718, 437);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(152, 50);
            this.Delete_button.TabIndex = 33;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(430, 361);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(347, 22);
            this.ID_textBox.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Screenshot__24_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // All_Delete_button
            // 
            this.All_Delete_button.BackColor = System.Drawing.Color.White;
            this.All_Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.All_Delete_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Delete_button.Location = new System.Drawing.Point(718, 621);
            this.All_Delete_button.Name = "All_Delete_button";
            this.All_Delete_button.Size = new System.Drawing.Size(152, 50);
            this.All_Delete_button.TabIndex = 41;
            this.All_Delete_button.Text = "Delete All User";
            this.All_Delete_button.UseVisualStyleBackColor = false;
            this.All_Delete_button.Click += new System.EventHandler(this.All_Delete_button_Click);
            // 
            // D_label
            // 
            this.D_label.AutoSize = true;
            this.D_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_label.ForeColor = System.Drawing.Color.White;
            this.D_label.Location = new System.Drawing.Point(252, 634);
            this.D_label.Name = "D_label";
            this.D_label.Size = new System.Drawing.Size(366, 23);
            this.D_label.TabIndex = 42;
            this.D_label.Text = "IF YOU WANT TO DELETE ALL USERS";
            // 
            // Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 818);
            this.Controls.Add(this.D_label);
            this.Controls.Add(this.All_Delete_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.User_ID_label);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete_User";
            this.Text = "Delete_User";
            this.Load += new System.EventHandler(this.Delete_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label User_ID_label;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button All_Delete_button;
        private System.Windows.Forms.Label D_label;
    }
}
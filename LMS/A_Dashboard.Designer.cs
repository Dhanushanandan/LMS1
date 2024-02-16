namespace LMS
{
    partial class A_Dashboard
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
            this.View_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.User_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.View_button);
            this.panel1.Controls.Add(this.Delete_button);
            this.panel1.Controls.Add(this.Update_button);
            this.panel1.Controls.Add(this.Register_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 818);
            this.panel1.TabIndex = 1;
            // 
            // View_button
            // 
            this.View_button.BackColor = System.Drawing.Color.White;
            this.View_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_button.ForeColor = System.Drawing.Color.Black;
            this.View_button.Location = new System.Drawing.Point(0, 528);
            this.View_button.Name = "View_button";
            this.View_button.Size = new System.Drawing.Size(149, 69);
            this.View_button.TabIndex = 3;
            this.View_button.Text = "VIEW USERS";
            this.View_button.UseVisualStyleBackColor = false;
            this.View_button.Click += new System.EventHandler(this.View_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.White;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.ForeColor = System.Drawing.Color.Black;
            this.Delete_button.Location = new System.Drawing.Point(0, 417);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(149, 69);
            this.Delete_button.TabIndex = 2;
            this.Delete_button.Text = "DELETE A USER";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.White;
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.ForeColor = System.Drawing.Color.Black;
            this.Update_button.Location = new System.Drawing.Point(0, 307);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(149, 69);
            this.Update_button.TabIndex = 1;
            this.Update_button.Text = "UPDATE USER DETAILS";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.White;
            this.Register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_button.ForeColor = System.Drawing.Color.Black;
            this.Register_button.Location = new System.Drawing.Point(0, 202);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(149, 69);
            this.Register_button.TabIndex = 0;
            this.Register_button.Text = "REGISTER A USER";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // User_panel
            // 
            this.User_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_panel.Location = new System.Drawing.Point(149, 0);
            this.User_panel.Name = "User_panel";
            this.User_panel.Size = new System.Drawing.Size(970, 818);
            this.User_panel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Screenshot__24_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // A_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 818);
            this.Controls.Add(this.User_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_Dashboard";
            this.Text = "A_Dashboard";
            this.Load += new System.EventHandler(this.A_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Button View_button;
        private System.Windows.Forms.Panel User_panel;
    }
}
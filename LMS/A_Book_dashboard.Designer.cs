namespace LMS
{
    partial class A_Book_dashboard
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
            this.User_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_V_button = new System.Windows.Forms.Button();
            this.B_D_button = new System.Windows.Forms.Button();
            this.B_New_button = new System.Windows.Forms.Button();
            this.R_V_button = new System.Windows.Forms.Button();
            this.R_D_button = new System.Windows.Forms.Button();
            this.B_UP_button = new System.Windows.Forms.Button();
            this.R_N_button = new System.Windows.Forms.Button();
            this.View_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // User_panel
            // 
            this.User_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_panel.Location = new System.Drawing.Point(149, 0);
            this.User_panel.Name = "User_panel";
            this.User_panel.Size = new System.Drawing.Size(970, 818);
            this.User_panel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.B_V_button);
            this.panel1.Controls.Add(this.B_D_button);
            this.panel1.Controls.Add(this.B_New_button);
            this.panel1.Controls.Add(this.R_V_button);
            this.panel1.Controls.Add(this.R_D_button);
            this.panel1.Controls.Add(this.B_UP_button);
            this.panel1.Controls.Add(this.R_N_button);
            this.panel1.Controls.Add(this.View_button);
            this.panel1.Controls.Add(this.Delete_button);
            this.panel1.Controls.Add(this.Update_button);
            this.panel1.Controls.Add(this.Add_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 818);
            this.panel1.TabIndex = 4;
            // 
            // B_V_button
            // 
            this.B_V_button.BackColor = System.Drawing.Color.White;
            this.B_V_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_V_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_V_button.ForeColor = System.Drawing.Color.Black;
            this.B_V_button.Location = new System.Drawing.Point(0, 512);
            this.B_V_button.Name = "B_V_button";
            this.B_V_button.Size = new System.Drawing.Size(149, 66);
            this.B_V_button.TabIndex = 15;
            this.B_V_button.Text = "VIEW BORROWED BOOKS";
            this.B_V_button.UseVisualStyleBackColor = false;
            this.B_V_button.Click += new System.EventHandler(this.B_V_button_Click);
            // 
            // B_D_button
            // 
            this.B_D_button.BackColor = System.Drawing.Color.White;
            this.B_D_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_D_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_D_button.ForeColor = System.Drawing.Color.Black;
            this.B_D_button.Location = new System.Drawing.Point(0, 454);
            this.B_D_button.Name = "B_D_button";
            this.B_D_button.Size = new System.Drawing.Size(149, 66);
            this.B_D_button.TabIndex = 14;
            this.B_D_button.Text = "DELETE BORROWED BOOK";
            this.B_D_button.UseVisualStyleBackColor = false;
            this.B_D_button.Click += new System.EventHandler(this.B_D_button_Click);
            // 
            // B_New_button
            // 
            this.B_New_button.BackColor = System.Drawing.Color.White;
            this.B_New_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_New_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_New_button.ForeColor = System.Drawing.Color.Black;
            this.B_New_button.Location = new System.Drawing.Point(0, 329);
            this.B_New_button.Name = "B_New_button";
            this.B_New_button.Size = new System.Drawing.Size(149, 66);
            this.B_New_button.TabIndex = 12;
            this.B_New_button.Text = "BORROWED BOOK";
            this.B_New_button.UseVisualStyleBackColor = false;
            this.B_New_button.Click += new System.EventHandler(this.B_New_button_Click);
            // 
            // R_V_button
            // 
            this.R_V_button.BackColor = System.Drawing.Color.White;
            this.R_V_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_V_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_V_button.ForeColor = System.Drawing.Color.Black;
            this.R_V_button.Location = new System.Drawing.Point(0, 740);
            this.R_V_button.Name = "R_V_button";
            this.R_V_button.Size = new System.Drawing.Size(149, 66);
            this.R_V_button.TabIndex = 11;
            this.R_V_button.Text = "VIEW RETURN BOOKS";
            this.R_V_button.UseVisualStyleBackColor = false;
            this.R_V_button.Click += new System.EventHandler(this.R_V_button_Click);
            // 
            // R_D_button
            // 
            this.R_D_button.BackColor = System.Drawing.Color.White;
            this.R_D_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_D_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_D_button.ForeColor = System.Drawing.Color.Black;
            this.R_D_button.Location = new System.Drawing.Point(0, 682);
            this.R_D_button.Name = "R_D_button";
            this.R_D_button.Size = new System.Drawing.Size(149, 66);
            this.R_D_button.TabIndex = 10;
            this.R_D_button.Text = "DELETE RETURN BOOK";
            this.R_D_button.UseVisualStyleBackColor = false;
            this.R_D_button.Click += new System.EventHandler(this.R_D_button_Click);
            // 
            // B_UP_button
            // 
            this.B_UP_button.BackColor = System.Drawing.Color.White;
            this.B_UP_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_UP_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_UP_button.ForeColor = System.Drawing.Color.Black;
            this.B_UP_button.Location = new System.Drawing.Point(0, 392);
            this.B_UP_button.Name = "B_UP_button";
            this.B_UP_button.Size = new System.Drawing.Size(149, 66);
            this.B_UP_button.TabIndex = 9;
            this.B_UP_button.Text = "UPDATE BORROWED BOOK DETAILS";
            this.B_UP_button.UseVisualStyleBackColor = false;
            this.B_UP_button.Click += new System.EventHandler(this.B_UP_button_Click);
            // 
            // R_N_button
            // 
            this.R_N_button.BackColor = System.Drawing.Color.White;
            this.R_N_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_N_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_N_button.ForeColor = System.Drawing.Color.Black;
            this.R_N_button.Location = new System.Drawing.Point(0, 622);
            this.R_N_button.Name = "R_N_button";
            this.R_N_button.Size = new System.Drawing.Size(149, 66);
            this.R_N_button.TabIndex = 8;
            this.R_N_button.Text = "RETURN BOOK";
            this.R_N_button.UseVisualStyleBackColor = false;
            this.R_N_button.Click += new System.EventHandler(this.R_N_button_Click);
            // 
            // View_button
            // 
            this.View_button.BackColor = System.Drawing.Color.White;
            this.View_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_button.ForeColor = System.Drawing.Color.Black;
            this.View_button.Location = new System.Drawing.Point(0, 223);
            this.View_button.Name = "View_button";
            this.View_button.Size = new System.Drawing.Size(149, 66);
            this.View_button.TabIndex = 3;
            this.View_button.Text = "VIEW BOOKS";
            this.View_button.UseVisualStyleBackColor = false;
            this.View_button.Click += new System.EventHandler(this.View_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.White;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.ForeColor = System.Drawing.Color.Black;
            this.Delete_button.Location = new System.Drawing.Point(0, 165);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(149, 66);
            this.Delete_button.TabIndex = 2;
            this.Delete_button.Text = "DELETE A BOOK";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.White;
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.ForeColor = System.Drawing.Color.Black;
            this.Update_button.Location = new System.Drawing.Point(0, 107);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(149, 66);
            this.Update_button.TabIndex = 1;
            this.Update_button.Text = "UPDATE BOOK DETAILS";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.White;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.ForeColor = System.Drawing.Color.Black;
            this.Add_button.Location = new System.Drawing.Point(0, 49);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(149, 66);
            this.Add_button.TabIndex = 0;
            this.Add_button.Text = "NEW BOOK";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Screenshot__24_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // A_Book_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 818);
            this.Controls.Add(this.User_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_Book_dashboard";
            this.Text = "A_Book_dashboard";
            this.Load += new System.EventHandler(this.A_Book_dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel User_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button View_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button R_V_button;
        private System.Windows.Forms.Button R_D_button;
        private System.Windows.Forms.Button B_UP_button;
        private System.Windows.Forms.Button R_N_button;
        private System.Windows.Forms.Button B_V_button;
        private System.Windows.Forms.Button B_D_button;
        private System.Windows.Forms.Button B_New_button;
    }
}
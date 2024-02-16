namespace LMS
{
    partial class Admin_Dashboard
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.income_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.User_DashBoard_panel = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Membership_button = new System.Windows.Forms.Button();
            this.rules_button = new System.Windows.Forms.Button();
            this.FeedBack_button = new System.Windows.Forms.Button();
            this.Book_button = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Dash_Board_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6.SuspendLayout();
            this.User_DashBoard_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.income_label);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.Logout_button);
            this.panel6.Controls.Add(this.Exit_button);
            this.panel6.Location = new System.Drawing.Point(188, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1153, 41);
            this.panel6.TabIndex = 5;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // income_label
            // 
            this.income_label.AutoSize = true;
            this.income_label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_label.ForeColor = System.Drawing.Color.White;
            this.income_label.Location = new System.Drawing.Point(180, 15);
            this.income_label.Name = "income_label";
            this.income_label.Size = new System.Drawing.Size(130, 19);
            this.income_label.TabIndex = 14;
            this.income_label.Text = "Find out income";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(338, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.Color.White;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.ForeColor = System.Drawing.Color.Black;
            this.Logout_button.Location = new System.Drawing.Point(445, 5);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(101, 34);
            this.Logout_button.TabIndex = 10;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Red;
            this.Exit_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exit_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.Color.White;
            this.Exit_button.Location = new System.Drawing.Point(1057, 7);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(35, 31);
            this.Exit_button.TabIndex = 12;
            this.Exit_button.Text = "X";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // User_DashBoard_panel
            // 
            this.User_DashBoard_panel.Controls.Add(this.pictureBox7);
            this.User_DashBoard_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_DashBoard_panel.Location = new System.Drawing.Point(188, 0);
            this.User_DashBoard_panel.Name = "User_DashBoard_panel";
            this.User_DashBoard_panel.Size = new System.Drawing.Size(1119, 818);
            this.User_DashBoard_panel.TabIndex = 4;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Image = global::LMS.Properties.Resources.Screenshot__24_;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1119, 818);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // Membership_button
            // 
            this.Membership_button.BackColor = System.Drawing.Color.White;
            this.Membership_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Membership_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Membership_button.ForeColor = System.Drawing.Color.Black;
            this.Membership_button.Location = new System.Drawing.Point(9, 456);
            this.Membership_button.Name = "Membership_button";
            this.Membership_button.Size = new System.Drawing.Size(176, 50);
            this.Membership_button.TabIndex = 4;
            this.Membership_button.Text = "MEMBERSHIP";
            this.Membership_button.UseVisualStyleBackColor = false;
            this.Membership_button.Click += new System.EventHandler(this.Membership_button_Click);
            // 
            // rules_button
            // 
            this.rules_button.BackColor = System.Drawing.Color.White;
            this.rules_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rules_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rules_button.ForeColor = System.Drawing.Color.Black;
            this.rules_button.Location = new System.Drawing.Point(9, 607);
            this.rules_button.Name = "rules_button";
            this.rules_button.Size = new System.Drawing.Size(173, 46);
            this.rules_button.TabIndex = 5;
            this.rules_button.Text = "RULES && FINE";
            this.rules_button.UseVisualStyleBackColor = false;
            this.rules_button.Click += new System.EventHandler(this.rules_button_Click);
            // 
            // FeedBack_button
            // 
            this.FeedBack_button.BackColor = System.Drawing.Color.White;
            this.FeedBack_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FeedBack_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedBack_button.ForeColor = System.Drawing.Color.Black;
            this.FeedBack_button.Location = new System.Drawing.Point(9, 764);
            this.FeedBack_button.Name = "FeedBack_button";
            this.FeedBack_button.Size = new System.Drawing.Size(173, 42);
            this.FeedBack_button.TabIndex = 6;
            this.FeedBack_button.Text = "FEEDBACK";
            this.FeedBack_button.UseVisualStyleBackColor = false;
            this.FeedBack_button.Click += new System.EventHandler(this.FeedBack_button_Click);
            // 
            // Book_button
            // 
            this.Book_button.BackColor = System.Drawing.Color.White;
            this.Book_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Book_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_button.ForeColor = System.Drawing.Color.Black;
            this.Book_button.Location = new System.Drawing.Point(9, 282);
            this.Book_button.Name = "Book_button";
            this.Book_button.Size = new System.Drawing.Size(173, 49);
            this.Book_button.TabIndex = 3;
            this.Book_button.Text = "BOOK";
            this.Book_button.UseVisualStyleBackColor = false;
            this.Book_button.Click += new System.EventHandler(this.Book_button_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(19, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1112, 16);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(19, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1112, 28);
            this.panel4.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(169, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 818);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 818);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Membership_button);
            this.panel1.Controls.Add(this.rules_button);
            this.panel1.Controls.Add(this.FeedBack_button);
            this.panel1.Controls.Add(this.Book_button);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Dash_Board_button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 818);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::LMS.Properties.Resources.FeedBack;
            this.pictureBox6.Location = new System.Drawing.Point(23, 661);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(137, 97);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::LMS.Properties.Resources.Rules;
            this.pictureBox5.Location = new System.Drawing.Point(23, 512);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(137, 89);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::LMS.Properties.Resources.Membership1;
            this.pictureBox4.Location = new System.Drawing.Point(26, 337);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(137, 115);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::LMS.Properties.Resources.Book;
            this.pictureBox3.Location = new System.Drawing.Point(23, 172);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 104);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(26, 352);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 115);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Dash_Board_button
            // 
            this.Dash_Board_button.BackColor = System.Drawing.Color.White;
            this.Dash_Board_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dash_Board_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dash_Board_button.ForeColor = System.Drawing.Color.Black;
            this.Dash_Board_button.Location = new System.Drawing.Point(9, 119);
            this.Dash_Board_button.Name = "Dash_Board_button";
            this.Dash_Board_button.Size = new System.Drawing.Size(173, 45);
            this.Dash_Board_button.TabIndex = 7;
            this.Dash_Board_button.Text = "DASHBOARD";
            this.Dash_Board_button.UseVisualStyleBackColor = false;
            this.Dash_Board_button.Click += new System.EventHandler(this.Dash_Board_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Admin_Profile;
            this.pictureBox1.Location = new System.Drawing.Point(23, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 818);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.User_DashBoard_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.User_DashBoard_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Panel User_DashBoard_panel;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button Membership_button;
        private System.Windows.Forms.Button rules_button;
        private System.Windows.Forms.Button FeedBack_button;
        private System.Windows.Forms.Button Book_button;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Dash_Board_button;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Label income_label;
        private System.Windows.Forms.Button button1;
    }
}
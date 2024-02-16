namespace LMS
{
    partial class Admin_Login
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
            this.Login_panel = new System.Windows.Forms.Panel();
            this.Show_pass_checkBox = new System.Windows.Forms.CheckBox();
            this.Profile_pictureBox = new System.Windows.Forms.PictureBox();
            this.Forgotten_Pass_linkLabel = new System.Windows.Forms.LinkLabel();
            this.Login_button = new System.Windows.Forms.Button();
            this.txt_Admin_Pass = new System.Windows.Forms.TextBox();
            this.admin_Name = new System.Windows.Forms.TextBox();
            this.UserPass_label = new System.Windows.Forms.Label();
            this.AdminName_label = new System.Windows.Forms.Label();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_panel
            // 
            this.Login_panel.BackColor = System.Drawing.Color.Transparent;
            this.Login_panel.Controls.Add(this.Show_pass_checkBox);
            this.Login_panel.Controls.Add(this.Profile_pictureBox);
            this.Login_panel.Controls.Add(this.Forgotten_Pass_linkLabel);
            this.Login_panel.Controls.Add(this.Login_button);
            this.Login_panel.Controls.Add(this.txt_Admin_Pass);
            this.Login_panel.Controls.Add(this.admin_Name);
            this.Login_panel.Controls.Add(this.UserPass_label);
            this.Login_panel.Controls.Add(this.AdminName_label);
            this.Login_panel.ForeColor = System.Drawing.Color.Black;
            this.Login_panel.Location = new System.Drawing.Point(351, 188);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(597, 538);
            this.Login_panel.TabIndex = 6;
            // 
            // Show_pass_checkBox
            // 
            this.Show_pass_checkBox.AutoSize = true;
            this.Show_pass_checkBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_pass_checkBox.ForeColor = System.Drawing.Color.White;
            this.Show_pass_checkBox.Location = new System.Drawing.Point(438, 345);
            this.Show_pass_checkBox.Name = "Show_pass_checkBox";
            this.Show_pass_checkBox.Size = new System.Drawing.Size(113, 19);
            this.Show_pass_checkBox.TabIndex = 8;
            this.Show_pass_checkBox.Text = "Show Password";
            this.Show_pass_checkBox.UseVisualStyleBackColor = true;
            this.Show_pass_checkBox.CheckedChanged += new System.EventHandler(this.Show_pass_checkBox_CheckedChanged);
            // 
            // Profile_pictureBox
            // 
            this.Profile_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Profile_pictureBox.BackgroundImage = global::LMS.Properties.Resources.Profile_Logo;
            this.Profile_pictureBox.Image = global::LMS.Properties.Resources.Admin_Profile;
            this.Profile_pictureBox.Location = new System.Drawing.Point(243, 13);
            this.Profile_pictureBox.Name = "Profile_pictureBox";
            this.Profile_pictureBox.Size = new System.Drawing.Size(212, 156);
            this.Profile_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Profile_pictureBox.TabIndex = 6;
            this.Profile_pictureBox.TabStop = false;
            // 
            // Forgotten_Pass_linkLabel
            // 
            this.Forgotten_Pass_linkLabel.AutoSize = true;
            this.Forgotten_Pass_linkLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forgotten_Pass_linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Forgotten_Pass_linkLabel.Location = new System.Drawing.Point(263, 382);
            this.Forgotten_Pass_linkLabel.Name = "Forgotten_Pass_linkLabel";
            this.Forgotten_Pass_linkLabel.Size = new System.Drawing.Size(169, 19);
            this.Forgotten_Pass_linkLabel.TabIndex = 5;
            this.Forgotten_Pass_linkLabel.TabStop = true;
            this.Forgotten_Pass_linkLabel.Text = "Forgotten Password?";
            this.Forgotten_Pass_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forgotten_Pass_linkLabel_LinkClicked);
            // 
            // Login_button
            // 
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(384, 460);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(118, 49);
            this.Login_button.TabIndex = 4;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // txt_Admin_Pass
            // 
            this.txt_Admin_Pass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Admin_Pass.Location = new System.Drawing.Point(243, 306);
            this.txt_Admin_Pass.Name = "txt_Admin_Pass";
            this.txt_Admin_Pass.PasswordChar = '*';
            this.txt_Admin_Pass.Size = new System.Drawing.Size(259, 27);
            this.txt_Admin_Pass.TabIndex = 3;
            // 
            // admin_Name
            // 
            this.admin_Name.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_Name.Location = new System.Drawing.Point(243, 229);
            this.admin_Name.Name = "admin_Name";
            this.admin_Name.Size = new System.Drawing.Size(259, 27);
            this.admin_Name.TabIndex = 2;
            // 
            // UserPass_label
            // 
            this.UserPass_label.AutoSize = true;
            this.UserPass_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPass_label.ForeColor = System.Drawing.Color.White;
            this.UserPass_label.Location = new System.Drawing.Point(135, 306);
            this.UserPass_label.Name = "UserPass_label";
            this.UserPass_label.Size = new System.Drawing.Size(90, 23);
            this.UserPass_label.TabIndex = 1;
            this.UserPass_label.Text = "Password";
            // 
            // AdminName_label
            // 
            this.AdminName_label.AutoSize = true;
            this.AdminName_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminName_label.ForeColor = System.Drawing.Color.White;
            this.AdminName_label.Location = new System.Drawing.Point(135, 229);
            this.AdminName_label.Name = "AdminName_label";
            this.AdminName_label.Size = new System.Drawing.Size(90, 23);
            this.AdminName_label.TabIndex = 0;
            this.AdminName_label.Text = "Admin ID";
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.Color.White;
            this.Welcome_label.Location = new System.Drawing.Point(566, 82);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(261, 68);
            this.Welcome_label.TabIndex = 5;
            this.Welcome_label.Text = "Welcome";
            // 
            // Back_button
            // 
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.Color.Transparent;
            this.Back_button.Location = new System.Drawing.Point(1039, 736);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(109, 40);
            this.Back_button.TabIndex = 7;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Screenshot__24_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Red;
            this.Exit_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exit_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.Color.White;
            this.Exit_button.Location = new System.Drawing.Point(1228, 72);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(35, 31);
            this.Exit_button.TabIndex = 11;
            this.Exit_button.Text = "X";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 818);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Login_panel);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login";
            this.Load += new System.EventHandler(this.Admin_Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.Login_panel.ResumeLayout(false);
            this.Login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Login_panel;
        private System.Windows.Forms.PictureBox Profile_pictureBox;
        private System.Windows.Forms.LinkLabel Forgotten_Pass_linkLabel;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox txt_Admin_Pass;
        private System.Windows.Forms.TextBox admin_Name;
        private System.Windows.Forms.Label UserPass_label;
        private System.Windows.Forms.Label AdminName_label;
        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.CheckBox Show_pass_checkBox;
        private System.Windows.Forms.Button Exit_button;
    }
}
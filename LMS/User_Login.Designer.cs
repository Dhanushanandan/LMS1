namespace LMS
{
    partial class User_Login
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
            this.Welcome_label = new System.Windows.Forms.Label();
            this.Login_panel = new System.Windows.Forms.Panel();
            this.Show_pass_checkBox = new System.Windows.Forms.CheckBox();
            this.Profile_pictureBox = new System.Windows.Forms.PictureBox();
            this.Forgotten_Pass_linkLabel = new System.Windows.Forms.LinkLabel();
            this.Login_button = new System.Windows.Forms.Button();
            this.User_Password_textBox = new System.Windows.Forms.TextBox();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.UserPass_label = new System.Windows.Forms.Label();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.Color.White;
            this.Welcome_label.Location = new System.Drawing.Point(566, 82);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(261, 68);
            this.Welcome_label.TabIndex = 1;
            this.Welcome_label.Text = "Welcome";
            // 
            // Login_panel
            // 
            this.Login_panel.BackColor = System.Drawing.Color.Transparent;
            this.Login_panel.Controls.Add(this.Show_pass_checkBox);
            this.Login_panel.Controls.Add(this.Profile_pictureBox);
            this.Login_panel.Controls.Add(this.Forgotten_Pass_linkLabel);
            this.Login_panel.Controls.Add(this.Login_button);
            this.Login_panel.Controls.Add(this.User_Password_textBox);
            this.Login_panel.Controls.Add(this.User_Name);
            this.Login_panel.Controls.Add(this.UserPass_label);
            this.Login_panel.Controls.Add(this.UserName_label);
            this.Login_panel.ForeColor = System.Drawing.Color.Black;
            this.Login_panel.Location = new System.Drawing.Point(351, 188);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(579, 538);
            this.Login_panel.TabIndex = 2;
            // 
            // Show_pass_checkBox
            // 
            this.Show_pass_checkBox.AutoSize = true;
            this.Show_pass_checkBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_pass_checkBox.ForeColor = System.Drawing.Color.White;
            this.Show_pass_checkBox.Location = new System.Drawing.Point(412, 346);
            this.Show_pass_checkBox.Name = "Show_pass_checkBox";
            this.Show_pass_checkBox.Size = new System.Drawing.Size(113, 19);
            this.Show_pass_checkBox.TabIndex = 7;
            this.Show_pass_checkBox.Text = "Show Password";
            this.Show_pass_checkBox.UseVisualStyleBackColor = true;
            this.Show_pass_checkBox.CheckedChanged += new System.EventHandler(this.Show_pass_checkBox_CheckedChanged);
            // 
            // Profile_pictureBox
            // 
            this.Profile_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Profile_pictureBox.BackgroundImage = global::LMS.Properties.Resources.Profile_Logo;
            this.Profile_pictureBox.Image = global::LMS.Properties.Resources.Profile_Logo;
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
            this.Forgotten_Pass_linkLabel.Location = new System.Drawing.Point(286, 386);
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
            // User_Password_textBox
            // 
            this.User_Password_textBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Password_textBox.Location = new System.Drawing.Point(243, 306);
            this.User_Password_textBox.Name = "User_Password_textBox";
            this.User_Password_textBox.PasswordChar = '*';
            this.User_Password_textBox.Size = new System.Drawing.Size(259, 27);
            this.User_Password_textBox.TabIndex = 3;
            // 
            // User_Name
            // 
            this.User_Name.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name.Location = new System.Drawing.Point(243, 229);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(259, 27);
            this.User_Name.TabIndex = 2;
       //     this.User_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.next_text);
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
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_label.ForeColor = System.Drawing.Color.White;
            this.UserName_label.Location = new System.Drawing.Point(135, 229);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(76, 23);
            this.UserName_label.TabIndex = 0;
            this.UserName_label.Text = "User ID";
            // 
            // Back_button
            // 
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.Color.Transparent;
            this.Back_button.Location = new System.Drawing.Point(1039, 736);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(109, 40);
            this.Back_button.TabIndex = 3;
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
            this.pictureBox1.Size = new System.Drawing.Size(1307, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
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
            this.Exit_button.Location = new System.Drawing.Point(1232, 73);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(35, 31);
            this.Exit_button.TabIndex = 10;
            this.Exit_button.Text = "X";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 818);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Login_panel);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Login";
            this.Load += new System.EventHandler(this.User_Login_Load);
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
        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Panel Login_panel;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox User_Password_textBox;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.Label UserPass_label;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.LinkLabel Forgotten_Pass_linkLabel;
        private System.Windows.Forms.PictureBox Profile_pictureBox;
        private System.Windows.Forms.CheckBox Show_pass_checkBox;
        private System.Windows.Forms.Button Exit_button;
    }
}
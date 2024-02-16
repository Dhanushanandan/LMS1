namespace LMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LMSlabel = new System.Windows.Forms.Label();
            this.Paragraphlabel = new System.Windows.Forms.Label();
            this.Adminbutton = new System.Windows.Forms.Button();
            this.User_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.User_pictureBox = new System.Windows.Forms.PictureBox();
            this.Admin_pictureBox = new System.Windows.Forms.PictureBox();
            this.Logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LMSlabel
            // 
            this.LMSlabel.AutoSize = true;
            this.LMSlabel.BackColor = System.Drawing.Color.Transparent;
            this.LMSlabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMSlabel.ForeColor = System.Drawing.Color.White;
            this.LMSlabel.Location = new System.Drawing.Point(255, 240);
            this.LMSlabel.Name = "LMSlabel";
            this.LMSlabel.Size = new System.Drawing.Size(835, 45);
            this.LMSlabel.TabIndex = 2;
            this.LMSlabel.Text = "LIBRARY  MANAGEMENT  SYSTEM [LMS]";
            // 
            // Paragraphlabel
            // 
            this.Paragraphlabel.BackColor = System.Drawing.Color.Transparent;
            this.Paragraphlabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paragraphlabel.ForeColor = System.Drawing.Color.White;
            this.Paragraphlabel.Location = new System.Drawing.Point(308, 328);
            this.Paragraphlabel.Name = "Paragraphlabel";
            this.Paragraphlabel.Size = new System.Drawing.Size(721, 80);
            this.Paragraphlabel.TabIndex = 4;
            this.Paragraphlabel.Text = resources.GetString("Paragraphlabel.Text");
            // 
            // Adminbutton
            // 
            this.Adminbutton.BackColor = System.Drawing.Color.Transparent;
            this.Adminbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Adminbutton.FlatAppearance.BorderSize = 2;
            this.Adminbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adminbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Adminbutton.Location = new System.Drawing.Point(297, 716);
            this.Adminbutton.Name = "Adminbutton";
            this.Adminbutton.Size = new System.Drawing.Size(302, 43);
            this.Adminbutton.TabIndex = 5;
            this.Adminbutton.Text = "Admin";
            this.Adminbutton.UseVisualStyleBackColor = false;
            this.Adminbutton.Click += new System.EventHandler(this.Adminbutton_Click);
            // 
            // User_button
            // 
            this.User_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.User_button.FlatAppearance.BorderSize = 2;
            this.User_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_button.ForeColor = System.Drawing.Color.White;
            this.User_button.Location = new System.Drawing.Point(751, 716);
            this.User_button.Name = "User_button";
            this.User_button.Size = new System.Drawing.Size(302, 43);
            this.User_button.TabIndex = 6;
            this.User_button.Text = "User";
            this.User_button.UseVisualStyleBackColor = true;
            this.User_button.Click += new System.EventHandler(this.User_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Red;
            this.Exit_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exit_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.Color.White;
            this.Exit_button.Location = new System.Drawing.Point(1260, 83);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(35, 31);
            this.Exit_button.TabIndex = 9;
            this.Exit_button.Text = "X";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // User_pictureBox
            // 
            this.User_pictureBox.Image = global::LMS.Properties.Resources.User_Logo;
            this.User_pictureBox.Location = new System.Drawing.Point(751, 452);
            this.User_pictureBox.Name = "User_pictureBox";
            this.User_pictureBox.Size = new System.Drawing.Size(302, 234);
            this.User_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User_pictureBox.TabIndex = 11;
            this.User_pictureBox.TabStop = false;
            // 
            // Admin_pictureBox
            // 
            this.Admin_pictureBox.Image = global::LMS.Properties.Resources.Admin_Logo;
            this.Admin_pictureBox.Location = new System.Drawing.Point(297, 452);
            this.Admin_pictureBox.Name = "Admin_pictureBox";
            this.Admin_pictureBox.Size = new System.Drawing.Size(302, 234);
            this.Admin_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Admin_pictureBox.TabIndex = 10;
            this.Admin_pictureBox.TabStop = false;
            // 
            // Logo_pictureBox
            // 
            this.Logo_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo_pictureBox.Image = global::LMS.Properties.Resources.Logo1;
            this.Logo_pictureBox.Location = new System.Drawing.Point(617, 87);
            this.Logo_pictureBox.Name = "Logo_pictureBox";
            this.Logo_pictureBox.Size = new System.Drawing.Size(153, 141);
            this.Logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_pictureBox.TabIndex = 3;
            this.Logo_pictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Screenshot__24_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1325, 865);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 865);
            this.Controls.Add(this.User_pictureBox);
            this.Controls.Add(this.Admin_pictureBox);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.User_button);
            this.Controls.Add(this.Adminbutton);
            this.Controls.Add(this.Paragraphlabel);
            this.Controls.Add(this.Logo_pictureBox);
            this.Controls.Add(this.LMSlabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LMSlabel;
        private System.Windows.Forms.PictureBox Logo_pictureBox;
        private System.Windows.Forms.Label Paragraphlabel;
        private System.Windows.Forms.Button Adminbutton;
        private System.Windows.Forms.Button User_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.PictureBox Admin_pictureBox;
        private System.Windows.Forms.PictureBox User_pictureBox;
    }
}


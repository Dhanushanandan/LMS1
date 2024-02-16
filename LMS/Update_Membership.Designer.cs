namespace LMS
{
    partial class Update_Membership
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.End_label = new System.Windows.Forms.Label();
            this.Update_label = new System.Windows.Forms.Label();
            this.Membership_comboBox = new System.Windows.Forms.ComboBox();
            this.User_Available_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.ID_label = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(783, 535);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(127, 23);
            this.checkBox2.TabIndex = 78;
            this.checkBox2.Text = "Select to Add";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(783, 449);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 23);
            this.checkBox1.TabIndex = 77;
            this.checkBox1.Text = "Select to Add";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(429, 449);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 27);
            this.dateTimePicker1.TabIndex = 76;
            this.dateTimePicker1.Value = new System.DateTime(2024, 2, 3, 13, 20, 27, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(429, 535);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(347, 27);
            this.dateTimePicker2.TabIndex = 75;
            this.dateTimePicker2.Value = new System.DateTime(2024, 2, 3, 13, 20, 27, 0);
            // 
            // End_label
            // 
            this.End_label.AutoSize = true;
            this.End_label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_label.ForeColor = System.Drawing.Color.White;
            this.End_label.Location = new System.Drawing.Point(168, 536);
            this.End_label.Name = "End_label";
            this.End_label.Size = new System.Drawing.Size(211, 19);
            this.End_label.TabIndex = 74;
            this.End_label.Text = "MEMBERSHIP END DATE";
            // 
            // Update_label
            // 
            this.Update_label.AutoSize = true;
            this.Update_label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_label.ForeColor = System.Drawing.Color.White;
            this.Update_label.Location = new System.Drawing.Point(168, 457);
            this.Update_label.Name = "Update_label";
            this.Update_label.Size = new System.Drawing.Size(242, 19);
            this.Update_label.TabIndex = 73;
            this.Update_label.Text = "MEMBERSHIP UPDATE DATE";
            // 
            // Membership_comboBox
            // 
            this.Membership_comboBox.FormattingEnabled = true;
            this.Membership_comboBox.Items.AddRange(new object[] {
            "Available",
            "Expired"});
            this.Membership_comboBox.Location = new System.Drawing.Point(429, 344);
            this.Membership_comboBox.Name = "Membership_comboBox";
            this.Membership_comboBox.Size = new System.Drawing.Size(347, 24);
            this.Membership_comboBox.TabIndex = 72;
            // 
            // User_Available_label
            // 
            this.User_Available_label.AutoSize = true;
            this.User_Available_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Available_label.ForeColor = System.Drawing.Color.White;
            this.User_Available_label.Location = new System.Drawing.Point(168, 345);
            this.User_Available_label.Name = "User_Available_label";
            this.User_Available_label.Size = new System.Drawing.Size(144, 23);
            this.User_Available_label.TabIndex = 71;
            this.User_Available_label.Text = "MEMBERSHIP";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LMS.Properties.Resources.Book;
            this.pictureBox2.Location = new System.Drawing.Point(458, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.White;
            this.Clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.Location = new System.Drawing.Point(464, 659);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(152, 50);
            this.Clear_button.TabIndex = 69;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.ForeColor = System.Drawing.Color.White;
            this.ID_label.Location = new System.Drawing.Point(168, 267);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(88, 23);
            this.ID_label.TabIndex = 68;
            this.ID_label.Text = "USER ID";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(429, 254);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(347, 22);
            this.ID_textBox.TabIndex = 66;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.White;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.Location = new System.Drawing.Point(769, 659);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(152, 50);
            this.Add_button.TabIndex = 67;
            this.Add_button.Text = "Update";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Screenshot__24_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // Update_Membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 818);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.End_label);
            this.Controls.Add(this.Update_label);
            this.Controls.Add(this.Membership_comboBox);
            this.Controls.Add(this.User_Available_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_Membership";
            this.Text = "Update_Membership";
            this.Load += new System.EventHandler(this.Update_Membership_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label End_label;
        private System.Windows.Forms.Label Update_label;
        private System.Windows.Forms.ComboBox Membership_comboBox;
        private System.Windows.Forms.Label User_Available_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
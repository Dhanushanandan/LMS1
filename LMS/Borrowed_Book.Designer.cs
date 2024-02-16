namespace LMS
{
    partial class Borrowed_Book
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
            this.Clear_button = new System.Windows.Forms.Button();
            this.Row_label = new System.Windows.Forms.Label();
            this.Author_Name_label = new System.Windows.Forms.Label();
            this.Book_Name_label = new System.Windows.Forms.Label();
            this.Book_ID_label = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.Author_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LMS.Properties.Resources.Book;
            this.pictureBox2.Location = new System.Drawing.Point(458, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.White;
            this.Clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.Location = new System.Drawing.Point(496, 569);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(152, 50);
            this.Clear_button.TabIndex = 43;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Row_label
            // 
            this.Row_label.AutoSize = true;
            this.Row_label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row_label.ForeColor = System.Drawing.Color.White;
            this.Row_label.Location = new System.Drawing.Point(286, 464);
            this.Row_label.Name = "Row_label";
            this.Row_label.Size = new System.Drawing.Size(212, 19);
            this.Row_label.TabIndex = 41;
            this.Row_label.Text = "BOOK BOOROWED DATE";
            // 
            // Author_Name_label
            // 
            this.Author_Name_label.AutoSize = true;
            this.Author_Name_label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_Name_label.ForeColor = System.Drawing.Color.White;
            this.Author_Name_label.Location = new System.Drawing.Point(286, 395);
            this.Author_Name_label.Name = "Author_Name_label";
            this.Author_Name_label.Size = new System.Drawing.Size(113, 19);
            this.Author_Name_label.TabIndex = 40;
            this.Author_Name_label.Text = "BOOK NAME";
            // 
            // Book_Name_label
            // 
            this.Book_Name_label.AutoSize = true;
            this.Book_Name_label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Name_label.ForeColor = System.Drawing.Color.White;
            this.Book_Name_label.Location = new System.Drawing.Point(283, 339);
            this.Book_Name_label.Name = "Book_Name_label";
            this.Book_Name_label.Size = new System.Drawing.Size(81, 19);
            this.Book_Name_label.TabIndex = 39;
            this.Book_Name_label.Text = "BOOK ID";
            // 
            // Book_ID_label
            // 
            this.Book_ID_label.AutoSize = true;
            this.Book_ID_label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_ID_label.ForeColor = System.Drawing.Color.White;
            this.Book_ID_label.Location = new System.Drawing.Point(280, 269);
            this.Book_ID_label.Name = "Book_ID_label";
            this.Book_ID_label.Size = new System.Drawing.Size(75, 19);
            this.Book_ID_label.TabIndex = 38;
            this.Book_ID_label.Text = "USER ID";
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.White;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.Location = new System.Drawing.Point(801, 569);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(152, 50);
            this.Add_button.TabIndex = 37;
            this.Add_button.Text = "ADD";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Author_textBox
            // 
            this.Author_textBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_textBox.Location = new System.Drawing.Point(519, 390);
            this.Author_textBox.Name = "Author_textBox";
            this.Author_textBox.Size = new System.Drawing.Size(347, 27);
            this.Author_textBox.TabIndex = 34;
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(519, 329);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(347, 27);
            this.name_textBox.TabIndex = 33;
            // 
            // ID_textBox
            // 
            this.ID_textBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_textBox.Location = new System.Drawing.Point(519, 259);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(347, 27);
            this.ID_textBox.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Screenshot__24_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(519, 464);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 27);
            this.dateTimePicker1.TabIndex = 45;
            this.dateTimePicker1.Value = new System.DateTime(2024, 2, 3, 13, 20, 27, 0);
            // 
            // Borrowed_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 818);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Row_label);
            this.Controls.Add(this.Author_Name_label);
            this.Controls.Add(this.Book_Name_label);
            this.Controls.Add(this.Book_ID_label);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Author_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrowed_Book";
            this.Text = "Borrowed_Book";
            this.Load += new System.EventHandler(this.Borrowed_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Label Row_label;
        private System.Windows.Forms.Label Author_Name_label;
        private System.Windows.Forms.Label Book_Name_label;
        private System.Windows.Forms.Label Book_ID_label;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TextBox Author_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
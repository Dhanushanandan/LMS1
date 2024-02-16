namespace LMS
{
    partial class Delete_Book
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
            this.Book_ID_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ad_button = new System.Windows.Forms.Button();
            this.D_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LMS.Properties.Resources.Book;
            this.pictureBox2.Location = new System.Drawing.Point(463, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // Book_ID_label
            // 
            this.Book_ID_label.AutoSize = true;
            this.Book_ID_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_ID_label.ForeColor = System.Drawing.Color.White;
            this.Book_ID_label.Location = new System.Drawing.Point(338, 388);
            this.Book_ID_label.Name = "Book_ID_label";
            this.Book_ID_label.Size = new System.Drawing.Size(80, 23);
            this.Book_ID_label.TabIndex = 38;
            this.Book_ID_label.Text = "Book ID";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.White;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(792, 492);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(152, 50);
            this.delete_button.TabIndex = 37;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(517, 389);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(347, 22);
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
            // Ad_button
            // 
            this.Ad_button.BackColor = System.Drawing.Color.White;
            this.Ad_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ad_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ad_button.Location = new System.Drawing.Point(792, 607);
            this.Ad_button.Name = "Ad_button";
            this.Ad_button.Size = new System.Drawing.Size(152, 50);
            this.Ad_button.TabIndex = 45;
            this.Ad_button.Text = "DELETE ALL BOOKS";
            this.Ad_button.UseVisualStyleBackColor = false;
            this.Ad_button.Click += new System.EventHandler(this.Ad_button_Click);
            // 
            // D_label
            // 
            this.D_label.AutoSize = true;
            this.D_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_label.ForeColor = System.Drawing.Color.White;
            this.D_label.Location = new System.Drawing.Point(266, 620);
            this.D_label.Name = "D_label";
            this.D_label.Size = new System.Drawing.Size(373, 23);
            this.D_label.TabIndex = 46;
            this.D_label.Text = "IF YOU WANT TO DELETE ALL BOOKS";
            // 
            // Delete_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 818);
            this.Controls.Add(this.D_label);
            this.Controls.Add(this.Ad_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Book_ID_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete_Book";
            this.Text = "Delete_Book";
            this.Load += new System.EventHandler(this.Delete_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Book_ID_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Ad_button;
        private System.Windows.Forms.Label D_label;
    }
}
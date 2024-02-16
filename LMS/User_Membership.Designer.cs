namespace LMS
{
    partial class User_Membership
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Membership_payment_button = new System.Windows.Forms.Button();
            this.Menbership_Detail_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Screenshot__24_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1112, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 474);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(27, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 474);
            this.panel1.TabIndex = 2;
            // 
            // Membership_payment_button
            // 
            this.Membership_payment_button.BackColor = System.Drawing.Color.White;
            this.Membership_payment_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Membership_payment_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Membership_payment_button.Location = new System.Drawing.Point(812, 149);
            this.Membership_payment_button.Name = "Membership_payment_button";
            this.Membership_payment_button.Size = new System.Drawing.Size(199, 68);
            this.Membership_payment_button.TabIndex = 8;
            this.Membership_payment_button.Text = "MEMBERSHIP PAYMENTS";
            this.Membership_payment_button.UseVisualStyleBackColor = false;
            this.Membership_payment_button.Click += new System.EventHandler(this.Membership_payment_button_Click);
            // 
            // Menbership_Detail_button
            // 
            this.Menbership_Detail_button.BackColor = System.Drawing.Color.White;
            this.Menbership_Detail_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menbership_Detail_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menbership_Detail_button.Location = new System.Drawing.Point(140, 149);
            this.Menbership_Detail_button.Name = "Menbership_Detail_button";
            this.Menbership_Detail_button.Size = new System.Drawing.Size(199, 68);
            this.Menbership_Detail_button.TabIndex = 9;
            this.Menbership_Detail_button.Text = "MEMBERSHIP DETAILS";
            this.Menbership_Detail_button.UseVisualStyleBackColor = false;
            this.Menbership_Detail_button.Click += new System.EventHandler(this.Menbership_Detail_button_Click);
            // 
            // User_Membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 818);
            this.Controls.Add(this.Menbership_Detail_button);
            this.Controls.Add(this.Membership_payment_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Membership";
            this.Text = "User_Membership";
            this.Load += new System.EventHandler(this.User_Membership_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Membership_payment_button;
        private System.Windows.Forms.Button Menbership_Detail_button;
    }
}
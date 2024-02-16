using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Admin_Reset_Pass : Form
    {
        public Admin_Reset_Pass()
        {
            InitializeComponent();
            Region =
           System.Drawing.Region.FromHrgn(CreateRoundRectRgn(50, 50, Width, Height, 90, 90));
        }

        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect(); 
        public Point mouseLocation;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, //x-coordinate of upper-left corner

            int nTopRect, // y-coordinate of upper-left corner

            int nRightRect, // x-coordinate of lower-right corner

            int nBottomRect, // y-coordinate of lower-right corner

            int nWidthEllipse, // height of ellipse

            int nHeightEllipse // width of ellipse

            );
        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);

        }
        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }


        private void Admin_Reset_Pass_Load(object sender, EventArgs e)
        {
            Reset_label.BackColor = Color.Transparent;
            Reset_label.Parent = pictureBox1;

            Id_label.BackColor = Color.Transparent;
            Id_label.Parent = pictureBox1;

            New_Pass_label.BackColor = Color.Transparent;
            New_Pass_label.Parent = pictureBox1;

            Con_Pass_label.BackColor = Color.Transparent;
            Con_Pass_label.Parent = pictureBox1;

            Reset_label.BackColor = Color.Transparent;
            Reset_button.Parent = pictureBox1;

            Back_button.BackColor = Color.Transparent;
            Back_button.Parent = pictureBox1;

            Show_pass_checkBox.BackColor = Color.Transparent;
            Show_pass_checkBox.Parent = pictureBox1;

            Clear_button.BackColor = Color.Transparent;
            Clear_button.Parent = pictureBox1;

            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;

            pictureBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox2.Width, pictureBox2.Height, 30, 30));

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Show_pass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Show_pass_checkBox.Checked)
                {
                    New_Pass_textBox.PasswordChar = '\0';
                    Con_Pass_textBox.PasswordChar = '\0';
                }
                else
                {
                    New_Pass_textBox.PasswordChar = '*';
                    Con_Pass_textBox.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to clear?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Id_textBox.Clear();
                New_Pass_textBox.Clear();
                Con_Pass_textBox.Clear();
                Id_textBox.Focus();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {

            try
            {
                if (Id_textBox.Text == "" || New_Pass_textBox.Text == "" || Con_Pass_textBox.Text == "")
                {
                    MessageBox.Show("Inputs Cannot be Null", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Id_textBox.Clear();
                    New_Pass_textBox.Clear();
                    Con_Pass_textBox.Clear();
                    Id_textBox.Focus();
                }
                else if (New_Pass_textBox.Text == Con_Pass_textBox.Text)
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Select * from Admin_Details Where Admin_ID=@Admin_ID", conn);
                    cmd.Parameters.AddWithValue("@Admin_ID", int.Parse(Id_textBox.Text));
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        SqlCommand cmd1 = new SqlCommand("Update Admin_Details set Admin_password=@Admin_password where Admin_ID=@Admin_ID", conn);
                        cmd1.Parameters.AddWithValue("@Admin_ID", Id_textBox.Text);
                        cmd1.Parameters.AddWithValue("@Admin_password", Con_Pass_textBox.Text);
                        cmd1.ExecuteNonQuery();
                        
                        MessageBox.Show("Detail Update");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Admin_ID", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Id_textBox.Clear();
                        New_Pass_textBox.Clear();
                        Con_Pass_textBox.Clear();
                        Id_textBox.Focus();
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Admin_ID Or Password", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Id_textBox.Clear();
                    New_Pass_textBox.Clear();
                    Con_Pass_textBox.Clear();
                    Id_textBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do You Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

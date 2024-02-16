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
    public partial class Admin_Login : Form
    {
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
        public Admin_Login()
        {
            InitializeComponent();
            Region =

            System.Drawing.Region.FromHrgn(CreateRoundRectRgn(50, 50, Width, Height, 90, 90));
        }

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

        private void Admin_Login_Load(object sender, EventArgs e)
        {
            Welcome_label.BackColor = Color.Transparent;
            Welcome_label.Parent = pictureBox1;

            Login_panel.BackColor = Color.Transparent;
            Login_panel.Parent = pictureBox1;

            Back_button.BackColor = Color.Transparent;
            Back_button.Parent = pictureBox1;

            Profile_pictureBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Profile_pictureBox.Width, Profile_pictureBox.Height, 30, 30));
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
               if(admin_Name.Text =="" || txt_Admin_Pass.Text == "")
                {
                    MessageBox.Show("Admin_ID OR Password Cannot be null", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Admin_Details where Admin_ID=@Admin_ID And Admin_password=@Admin_password", conn);
                    cmd.Parameters.AddWithValue("@Admin_ID", admin_Name.Text);
                    cmd.Parameters.AddWithValue("@Admin_password", txt_Admin_Pass.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt1 = new DataTable();
                    adapter.Fill(dt1);
                    cmd.ExecuteNonQuery();
                    if (dt1.Rows.Count > 0)
                    {
                        Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
                        this.Hide();
                        admin_Dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        admin_Name.Clear();
                        txt_Admin_Pass.Clear();
                        admin_Name.Focus();
                    }
                    conn.Close();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Show_pass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Show_pass_checkBox.Checked)
                {
                    txt_Admin_Pass.PasswordChar = '\0';
                }
                else
                {
                    txt_Admin_Pass.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Forgotten_Pass_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_Reset_Pass admin_Reset_Pass = new Admin_Reset_Pass();
            admin_Reset_Pass.Show();
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
    }
}

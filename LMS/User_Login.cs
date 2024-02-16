using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Configuration;

namespace LMS
{
    public partial class User_Login : Form
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
        public User_Login()
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

        private void User_Login_Load(object sender, EventArgs e)
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
                if (User_Name.Text == "" || User_Password_textBox.Text == "")
                {
                    MessageBox.Show("User Name or Password cannot be null", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from User_Details where User_ID=@User_ID And User_password=@User_password", conn);
                    cmd.Parameters.AddWithValue("@User_ID", User_Name.Text);
                    cmd.Parameters.AddWithValue("@User_password", User_Password_textBox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cmd.ExecuteNonQuery();
                    if (dt.Rows.Count > 0)
                    {
                        User_DashBoard user_DashBoard = new User_DashBoard(User_Name.Text);
                        user_DashBoard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        User_Name.Clear();
                        User_Password_textBox.Clear();
                        User_Name.Focus();
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:"+ex.Message,"Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Show_pass_checkBox_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (Show_pass_checkBox.Checked)
                {
                    User_Password_textBox.PasswordChar = '\0';
                }
                else
                {
                    User_Password_textBox.PasswordChar = '*';
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
            Reset_Password reset_Password = new Reset_Password();
            reset_Password.Show();
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

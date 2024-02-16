using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LMS
{
    public partial class Form1 : Form
    {
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
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            LMSlabel.BackColor = Color.Transparent;
            LMSlabel.Parent = pictureBox1;
            Paragraphlabel.BackColor = Color.Transparent;
            Paragraphlabel.Parent = pictureBox1;

            Adminbutton.BackColor = Color.Transparent;
            Adminbutton.Parent = pictureBox1;

            User_button.BackColor = Color.Transparent;
            User_button.Parent = pictureBox1;

           // Adminbutton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,Adminbutton.Width,Adminbutton.Height, 30, 30));
          //  User_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, User_button.Width, User_button.Height, 30, 30));
           // Exit_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Exit_button.Width, Exit_button.Height, 30, 30));

            User_pictureBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, User_pictureBox.Width,User_pictureBox.Height, 30, 30));
            Admin_pictureBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Admin_pictureBox.Width, Admin_pictureBox.Height, 30, 30));
            Logo_pictureBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Logo_pictureBox.Width, Logo_pictureBox.Height, 30, 30));
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Do You Want to Exit?","Exit",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result== DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                DialogResult = DialogResult.No;
            }
            
        }

        private void Adminbutton_Click(object sender, EventArgs e)
        {
            Admin_Login admin_Login = new Admin_Login();
            this.Hide();
            admin_Login.Show();
        }

        private void User_button_Click(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();
            this.Hide();
            user_Login.Show();
        }
    }
}

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

namespace LMS
{
    public partial class User_DashBoard : Form
    {
        String Id;
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
        public User_DashBoard(String id)
        {
            InitializeComponent();
            System.Drawing.Region.FromHrgn(CreateRoundRectRgn(50, 50, Width, Height, 90, 90));
            Id= id;
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

        private void User_DashBoard_Load(object sender, EventArgs e)
        {
           Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            DashBoard dashBoard = new DashBoard() { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(dashBoard);
            dashBoard.Show();
            dashBoard.BringToFront();
        }

        private void Book_button_Click(object sender, EventArgs e)
        {
            Book_DashBoard Books = new Book_DashBoard(Id) { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(Books);
            Books.Show();
            Books.BringToFront();
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

        private void Dash_Board_button_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard() { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(dashBoard);
            dashBoard.Show();
            dashBoard.BringToFront();
        }

        private void Membership_button_Click(object sender, EventArgs e)
        {
            User_Membership user_Membership=new User_Membership(Id) { TopLevel =false, TopMost=true };
            User_DashBoard_panel.Controls.Add(user_Membership);
            user_Membership.Show();
            user_Membership.BringToFront();

        }

        private void rules_button_Click(object sender, EventArgs e)
        {
            Rules rule = new Rules(Id) { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(rule);
            rule.Show();
            rule.BringToFront();
        }

        private void FeedBack_button_Click(object sender, EventArgs e)
        {
            User_FeedBack feed = new User_FeedBack() { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(feed);
            feed.Show();
            feed.BringToFront();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Logout?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
           
        }
    }
}

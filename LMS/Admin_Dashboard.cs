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
    public partial class Admin_Dashboard : Form
    {
        //the form making a move without toolbar
        public Point mouseLocation;
        //import a package to make the windows form corners round
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //variables for the form corners
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, //x-coordinate of upper-left corner

            int nTopRect, // y-coordinate of upper-left corner

            int nRightRect, // x-coordinate of lower-right corner

            int nBottomRect, // y-coordinate of lower-right corner

            int nWidthEllipse, // height of ellipse

            int nHeightEllipse // width of ellipse

            );
        public Admin_Dashboard()
        {
            InitializeComponent();
            System.Drawing.Region.FromHrgn(CreateRoundRectRgn(50, 50, Width, Height, 90, 90));
        }

        //mouse curser movement detect down 
        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);

        }
        //mouse movement detect move
        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }


        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
             Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            A_Dashboard dashBoard = new A_Dashboard() { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(dashBoard);
            dashBoard.Show();
            dashBoard.BringToFront();
           
        }

        private void Dash_Board_button_Click(object sender, EventArgs e)
        {
            A_Dashboard dashBoard = new A_Dashboard() { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(dashBoard);
            dashBoard.Show();
            dashBoard.BringToFront();
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

        private void Book_button_Click(object sender, EventArgs e)
        {
            A_Book_dashboard dashBoard = new A_Book_dashboard() { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(dashBoard);
            dashBoard.Show();
            dashBoard.BringToFront();
        }

        private void Membership_button_Click(object sender, EventArgs e)
        {
            A_Membership_Dash dashBoard = new A_Membership_Dash() { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(dashBoard);
            dashBoard.Show();
            dashBoard.BringToFront();
        }

        private void FeedBack_button_Click(object sender, EventArgs e)
        {
            A_Feedback dashBoard = new A_Feedback() { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(dashBoard);
            dashBoard.Show();
            dashBoard.BringToFront();
        }

        private void rules_button_Click(object sender, EventArgs e)
        {
            A_Rule_fine dashBoard = new A_Rule_fine() { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(dashBoard);
            dashBoard.Show();
            dashBoard.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Income dashBoard = new Income() { TopLevel = false, TopMost = true };
            User_DashBoard_panel.Controls.Add(dashBoard);
            dashBoard.Show();
            dashBoard.BringToFront();
        }
    }
}

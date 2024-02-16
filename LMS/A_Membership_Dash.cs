using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class A_Membership_Dash : Form
    {
        public A_Membership_Dash()
        {
            InitializeComponent();
        }

        private void A_Membership_Dash_Load(object sender, EventArgs e)
        {
            User_panel.BackColor = Color.Transparent;
            User_panel.Parent = pictureBox1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Add_Membership New = new Add_Membership() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            Update_Membership New = new Update_Membership() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Delete_Membership New = new Delete_Membership() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void View_button_Click(object sender, EventArgs e)
        {
            View_Membership New = new View_Membership() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void M_A_Payment_button_Click(object sender, EventArgs e)
        {
            New_M_payment New = new New_M_payment() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void M_U_payment_button_Click(object sender, EventArgs e)
        {
            Update_M_payment New = new Update_M_payment() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void M_D_payment_button_Click(object sender, EventArgs e)
        {
            Delete_M_payement New = new Delete_M_payement() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void M_V_payment_button_Click(object sender, EventArgs e)
        {
            View_M_payment New = new View_M_payment() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }
    }
}

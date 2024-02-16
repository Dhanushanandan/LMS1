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
    public partial class A_Dashboard : Form
    {
        //invoking all forms inside a single form
        public A_Dashboard()
        {
            InitializeComponent();
        }

        private void A_Dashboard_Load(object sender, EventArgs e)
        {
            User_panel.BackColor = Color.Transparent;
            User_panel.Parent = pictureBox1;
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            Register regi = new Register() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(regi);
            regi.Show();
            regi.BringToFront();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {

            Update_User up = new Update_User() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(up);
            up.Show();
            up.BringToFront();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Delete_User de = new Delete_User() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(de);
            de.Show();
            de.BringToFront();
        }

        private void View_button_Click(object sender, EventArgs e)
        {
            View_User view = new View_User() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(view);
            view.Show();
            view.BringToFront();
        }
    }
}

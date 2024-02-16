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
    public partial class A_Book_dashboard : Form
    {
        //Calling needed forms using button fuctions.Display in one form to view.
        public A_Book_dashboard()
        {
            InitializeComponent();
        }

        private void A_Book_dashboard_Load(object sender, EventArgs e)
        {
            //making pannel transperent
            User_panel.BackColor = Color.Transparent;
            User_panel.Parent = pictureBox1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            //calling other form inside a main form 
            New_Book New = new New_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            Update_Book up = new Update_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(up);
            up.Show();
            up.BringToFront();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Delete_Book del = new Delete_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(del);
            del.Show();
            del.BringToFront();
        }

        private void View_button_Click(object sender, EventArgs e)
        {
            View_Book view = new View_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(view);
            view.Show();
            view.BringToFront();
        }

        private void R_N_button_Click(object sender, EventArgs e)
        {
            Return_Book b = new Return_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(b);
            b.Show();
            b.BringToFront();
        }
        private void R_D_button_Click(object sender, EventArgs e)
        {
            R_D_Book del = new R_D_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(del);
            del.Show();
            del.BringToFront();
        }

        private void R_V_button_Click(object sender, EventArgs e)
        {
            R_V_Book view = new R_V_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(view);
            view.Show();
            view.BringToFront();
        }

        private void B_New_button_Click(object sender, EventArgs e)
        {
            Borrowed_Book b = new Borrowed_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(b);
            b.Show();
            b.BringToFront();
        }

       /* private void B_U_button_Click(object sender, EventArgs e)
        {
            U_Borrowed_Book u = new U_Borrowed_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(u);
            u.Show();
            u.BringToFront();
        }*/

        private void B_D_button_Click(object sender, EventArgs e)
        {
            Delete_Borrowed_Book del = new Delete_Borrowed_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(del);
            del.Show();
            del.BringToFront();
        }

        private void B_V_button_Click(object sender, EventArgs e)
        {
            View_Borrowed_Book view = new View_Borrowed_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(view);
            view.Show();
            view.BringToFront();
        }

        private void B_UP_button_Click(object sender, EventArgs e)
        {
           
            U_Borrowed_Book u = new U_Borrowed_Book() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(u);
            u.Show();
            u.BringToFront();
        }
    }
}

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
    public partial class A_Rule_fine : Form
    {
        public A_Rule_fine()
        {
            InitializeComponent();
        }

        private void A_Rule_fine_Load(object sender, EventArgs e)
        {
            User_panel.BackColor = Color.Transparent;
            User_panel.Parent = pictureBox1;
            
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            A_New_Rule New = new A_New_Rule() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            A_Up_Rule New = new A_Up_Rule() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            A_Delete_Rule New = new A_Delete_Rule() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void View_button_Click(object sender, EventArgs e)
        {
            A_View_Rule New = new A_View_Rule() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void D_button_Click(object sender, EventArgs e)
        {
            A_D_New_fine New = new A_D_New_fine() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void D_UP_button_Click(object sender, EventArgs e)
        {
            A_D_UP_Fine New = new A_D_UP_Fine() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void D_D_button_Click(object sender, EventArgs e)
        {
            A_D_Delete_fine New = new A_D_Delete_fine() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void D_V_button_Click(object sender, EventArgs e)
        {
            A_D_View_fine New = new A_D_View_fine() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void B_New_button_Click(object sender, EventArgs e)
        {

            A_Delay_New_Fine New = new A_Delay_New_Fine() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void B_UP_button_Click(object sender, EventArgs e)
        {
            A_Delay_UP_Fine New = new A_Delay_UP_Fine() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void B_D_button_Click(object sender, EventArgs e)
        {
            A_Delay_Delete_Fine New = new A_Delay_Delete_Fine() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void B_V_button_Click(object sender, EventArgs e)
        {
            A_Delay_view_Fine New = new A_Delay_view_Fine() { TopLevel = false, TopMost = true };
            User_panel.Controls.Add(New);
            New.Show();
            New.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

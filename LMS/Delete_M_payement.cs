using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Delete_M_payement : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public Delete_M_payement()
        {
            InitializeComponent();
        }

        private void Delete_M_payement_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
           
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "" )
                {
                    MessageBox.Show("Details Cannot be null", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conn.Open();
                        SqlCommand cmd = new SqlCommand("Delete from Membership_Payment where Membership_ID=@Membership_ID", conn);
                        cmd.Parameters.AddWithValue("@Membership_ID", textBox1.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Membership Payment Delete Completed", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox1.Clear();
                    textBox1.Focus();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Membership_Payment", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membership Payment Delete Completed", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox1.Focus();
                    conn.Close();
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS
{
    public partial class A_D_Delete_fine : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();

        public A_D_Delete_fine()
        {
            InitializeComponent();
        }

        private void A_D_Delete_fine_Load(object sender, EventArgs e)
        {
            //label transperent code
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Damaged_Book", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Damaged Fine Details Delete Completed", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
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

        private void Add_button_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Values cannot be null", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    DialogResult result = MessageBox.Show("Do You Want to Submit?", "SUBMIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Delete from Damaged_Book Where Damaged_ID=@Damaged_ID", conn);
                        cmd.Parameters.AddWithValue("@Damaged_ID", textBox1.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Delete Successful", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}

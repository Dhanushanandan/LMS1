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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS
{
    public partial class A_Delay_Delete_Fine : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public A_Delay_Delete_Fine()
        {
            InitializeComponent();
        }

        private void A_Delay_Delete_Fine_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
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
                    conn.Open();
                    DialogResult result = MessageBox.Show("Do You Want to Submit?", "SUBMIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            SqlCommand cmd = new SqlCommand("Delete from Fine_Payment Where Fine__ID=@Fine__ID", conn);
                            cmd.Parameters.AddWithValue("@Fine__ID", textBox1.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Delete Successful", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                        else
                        {
                            DialogResult = DialogResult.Cancel;
                        }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Fine_Payment", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fine_Payment Details Delete Completed", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

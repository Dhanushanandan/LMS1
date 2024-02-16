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
    public partial class A_Delete_Rule : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public A_Delete_Rule()
        {
            InitializeComponent();
        }

        private void A_Delete_Rule_Load(object sender, EventArgs e)
        {
            R_ID__label.BackColor = Color.Transparent;
            R_ID__label.Parent = pictureBox1;
        }

        private void Deleet_All_button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Rules", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rules Details Delete Completed", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Clear();
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

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("ID Cannot be null", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * from Rules where Rules_ID=@Rules_ID", conn);
                    cmd1.Parameters.AddWithValue("@Rules_ID", int.Parse(textBox2.Text));
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cmd1.ExecuteNonQuery();
                    if (dt.Rows.Count > 0)
                    {
                        SqlCommand cmd = new SqlCommand("Delete from Rules Where Rules_ID=@Rules_ID", conn);
                        cmd.Parameters.AddWithValue("@Rules_ID", int.Parse(textBox2.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Delete Completed", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox2.Clear();
                        textBox2.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Rule ID NOT Found", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

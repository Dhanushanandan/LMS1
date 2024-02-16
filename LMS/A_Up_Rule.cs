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
    public partial class A_Up_Rule : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public A_Up_Rule()
        {
            InitializeComponent();
        }

        private void A_Up_Rule_Load(object sender, EventArgs e)
        {
            R_ID__label.BackColor = Color.Transparent;
            R_ID__label.Parent = pictureBox1;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to clear?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox2.Focus();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void Feedback_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Values cannot be null", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        DialogResult result = MessageBox.Show("Do You Want to Submit?", "SUBMIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            SqlCommand cmd = new SqlCommand("Update Rules set Rules=@Rules Where Rules_ID=@Rules_ID", conn);
                            cmd.Parameters.AddWithValue("@Rules_ID", int.Parse(textBox2.Text));
                            cmd.Parameters.AddWithValue("@Rules", textBox1.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Update Successful", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox2.Focus();
                        }
                        else
                        {
                            DialogResult = DialogResult.Cancel;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rule ID NOT Found", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Clear();
                        textBox1.Clear();
                        textBox2.Focus();
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
    }
}

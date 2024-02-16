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
    public partial class User_FeedBack : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public User_FeedBack()
        {
            InitializeComponent();
        }

        private void Feedback_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Feedback Cannot be null", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do You Want to Submit?", "SUBMIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into FeedBack values(@FeedBack)", conn);
                    cmd.Parameters.AddWithValue("@FeedBack", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Subbmisson Successful", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to clear?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}

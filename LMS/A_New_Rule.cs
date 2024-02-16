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
    public partial class A_New_Rule : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public A_New_Rule()
        {
            InitializeComponent();
        }

        private void A_New_Rule_Load(object sender, EventArgs e)
        {
            R_ID__label.BackColor = Color.Transparent;
            R_ID__label.Parent = pictureBox1;
        }

        private void Feedback_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text=="" || textBox2.Text =="")
                {
                    MessageBox.Show("Values cannot be null", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do You Want to Submit?", "SUBMIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into Rules values(@Rules_ID,@Rules)", conn);
                        cmd.Parameters.AddWithValue("@Rules_ID", int.Parse(textBox2.Text));
                        cmd.Parameters.AddWithValue("@Rules", textBox1.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Subbmisson Successful", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox2.Focus();
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
    }
}

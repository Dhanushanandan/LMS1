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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LMS
{
    public partial class New_M_payment : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public New_M_payment()
        {
            InitializeComponent();
        }

        private void New_M_payment_Load(object sender, EventArgs e)
        {
            ID_label.BackColor = Color.Transparent;
            ID_label.Parent = pictureBox1;
            Payment_label.BackColor = Color.Transparent;
            Payment_label.Parent = pictureBox1;
            Date_label.BackColor = Color.Transparent;
            Date_label.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do You Want to clear?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ID_textBox.Clear();
                    Amount_textBox.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                String date1;
                if (checkBox1.Checked)
                {
                    date1 = dateTimePicker1.Value.ToString();
                }
                else
                {
                    date1 = "";
                }
         
                if (ID_textBox.Text == "" || date1 == "" || Amount_textBox.Text=="" || textBox1.Text=="")
                {
                    MessageBox.Show("Details Cannot be null", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * from User_Details where User_ID=@User_ID", conn);
                    cmd1.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cmd1.ExecuteNonQuery();
                    if (dt.Rows.Count > 0)
                    {
                        SqlCommand cmd = new SqlCommand("insert into Membership_Payment values(@Membership_ID,@User_ID,@Payment_Amount,@Payment_Date)", conn);
                        cmd.Parameters.AddWithValue("@Membership_ID", textBox1.Text);
                        cmd.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                        cmd.Parameters.AddWithValue("@Payment_Amount", Amount_textBox.Text);
                        cmd.Parameters.AddWithValue("@Payment_Date", date1);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Membership Payment Add Completed", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ID_textBox.Clear();
                        Amount_textBox.Text = string.Empty;
                        dateTimePicker1.Value = DateTime.Now;
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("User NOT Found", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ID_textBox.Clear();
                        Amount_textBox.Text = string.Empty;
                        dateTimePicker1.Value = DateTime.Now;
                        textBox1.Clear();
                        textBox1.Focus();

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}
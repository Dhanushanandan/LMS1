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
    public partial class Delete_Membership : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public Delete_Membership()
        {
            InitializeComponent();
        }

        private void Delete_Membership_Load(object sender, EventArgs e)
        {

            ID_label.BackColor = Color.Transparent;
            ID_label.Parent = pictureBox1;
            Update_label.BackColor = Color.Transparent;
            Update_label.Parent = pictureBox1;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                String date1, date2;
                if (checkBox1.Checked)
                {
                    date1 = dateTimePicker1.Value.ToString();
                }
                else
                {
                    date1 = "";
                }

                if (ID_textBox.Text == "" || date1 == "")
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

                        SqlCommand cmd = new SqlCommand("Delete from Membership_details Where User_ID=@User_ID AND Updated_Date=@Updated_Date", conn);
                        cmd.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                        cmd.Parameters.AddWithValue("@Updated_Date", date1);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Membership Delete Completed", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ID_textBox.Clear();

                        dateTimePicker1.Value = DateTime.Now;


                        ID_textBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show("User NOT Found", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ID_textBox.Clear();
                      
                        dateTimePicker1.Value = DateTime.Now;
                       

                        ID_textBox.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Membership_details", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membership Delete Completed", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ID_textBox.Clear();
                   
                    dateTimePicker1.Value = DateTime.Now;
                   

                    ID_textBox.Focus();
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

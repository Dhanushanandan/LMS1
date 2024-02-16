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
    public partial class Add_Membership : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public Add_Membership()
        {
            InitializeComponent();
        }

        private void Add_Membership_Load(object sender, EventArgs e)
        {
            ID_label.BackColor = Color.Transparent;
            ID_label.Parent = pictureBox1;
            User_Available_label.BackColor = Color.Transparent;
            User_Available_label.Parent = pictureBox1;
            Update_label.BackColor = Color.Transparent;
            Update_label.Parent = pictureBox1;
            End_label.BackColor = Color.Transparent;
            End_label.Parent = pictureBox1;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {


            try
            {
                DialogResult result = MessageBox.Show("Do You Want to clear?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ID_textBox.Clear();
                    Membership_comboBox.Text = string.Empty;
                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;
                   
                    ID_textBox.Focus();
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
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
                if (checkBox2.Checked)
                {
                    date2 = dateTimePicker2.Value.ToString();
                }
                else
                {
                    date2 = "";
                }
                String Membership = Membership_comboBox.Text;

                if (ID_textBox.Text == "" || Membership == "" || date1 == "" || date2 == "")
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
                        SqlCommand cmd = new SqlCommand("insert into Membership_details values(@User_ID,@Membership,@Updated_Date,@End_Date)", conn);
                        
                        cmd.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                        cmd.Parameters.AddWithValue("@Membership", Membership);
                        cmd.Parameters.AddWithValue("@Updated_Date", date1);
                        cmd.Parameters.AddWithValue("@End_Date", date2);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Membership Add Completed", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ID_textBox.Clear();
                        Membership_comboBox.Text = string.Empty;
                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker2.Value = DateTime.Now;
                       
                        ID_textBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show("User NOT Found", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ID_textBox.Clear();
                        Membership_comboBox.Text = string.Empty;
                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker2.Value = DateTime.Now;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

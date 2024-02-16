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
    public partial class A_Delay_UP_Fine : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public A_Delay_UP_Fine()
        {
            InitializeComponent();
        }

        private void A_Delay_UP_Fine_Load(object sender, EventArgs e)
        {
            Book_ID_label.BackColor = Color.Transparent;
            Book_ID_label.Parent = pictureBox1;
            Book_Name_label.BackColor = Color.Transparent;
            Book_Name_label.Parent = pictureBox1;
            Damaged_label.BackColor = Color.Transparent;
            Damaged_label.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to clear?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ID_textBox.Clear();
                name_textBox.Clear();
                Damaged_textBox.Clear();
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID_textBox.Text == "" || name_textBox.Text == "" || Damaged_textBox.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Values cannot be null", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        DialogResult result = MessageBox.Show("Do You Want to Submit?", "SUBMIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {

                            SqlCommand cmd = new SqlCommand("Update Fine_Payment set Fine_Amount=@Fine_Amount,User_ID=@User_ID,Delay_Duration=@Delay_Duration Where Fine__ID=@Fine__ID", conn);
                            cmd.Parameters.AddWithValue("@Fine__ID", textBox1.Text);
                            cmd.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                            cmd.Parameters.AddWithValue("@Fine_Amount", float.Parse(name_textBox.Text));
                            cmd.Parameters.AddWithValue("@Delay_Duration", int.Parse(Damaged_textBox.Text));
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Update Successful", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ID_textBox.Clear();
                            name_textBox.Clear();
                            Damaged_textBox.Clear();
                            textBox1.Clear();
                            textBox1.Focus();
                            conn.Close();
                        }
                        else
                        {
                            DialogResult = DialogResult.Cancel;
                        }
                    }
                    else
                    {
                        MessageBox.Show("User NOT Found", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ID_textBox.Clear();
                        name_textBox.Clear();
                        Damaged_textBox.Clear();
                        textBox1.Clear();
                        textBox1.Focus();
                        conn.Close();
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

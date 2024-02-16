using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LMS
{
    public partial class Register : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            User_ID_label.BackColor = Color.Transparent;
            User_ID_label.Parent = pictureBox1;
            User_Name_label.BackColor = Color.Transparent;
            User_Name_label.Parent = pictureBox1;
            Pass_label.BackColor = Color.Transparent;
            Pass_label.Parent = pictureBox1;
            Mobile_label.BackColor = Color.Transparent;
            Mobile_label.Parent = pictureBox1;
            Address_label.BackColor = Color.Transparent;
            Address_label.Parent = pictureBox1;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to clear?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ID_textBox.Clear();
                name_textBox.Clear();
                Add_textBox.Clear();
                Mobile_textBox.Clear();
                paas_textBox.Clear();
                ID_textBox.Focus();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID_textBox.Text == "" || name_textBox.Text == "" || Add_textBox.Text== "" || paas_textBox.Text == "")
                {
                    MessageBox.Show("Details Cannot be null", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (Mobile_textBox.Text.Length == 10)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into User_Details values(@User_ID,@User_Name,@User_Address,@User_Mobile,@User_Password)", conn);
                        cmd.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                        cmd.Parameters.AddWithValue("@User_Name", name_textBox.Text);
                        cmd.Parameters.AddWithValue("@User_Address", Add_textBox.Text);
                        cmd.Parameters.AddWithValue("@User_Mobile", Mobile_textBox.Text);
                        cmd.Parameters.AddWithValue("@User_Password", paas_textBox.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Register Completed", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ID_textBox.Clear();
                        name_textBox.Clear();
                        Add_textBox.Clear();
                        Mobile_textBox.Clear();
                        paas_textBox.Clear();
                        ID_textBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Mobile number must be 10 numbers", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close() ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}

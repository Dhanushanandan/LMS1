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
    public partial class Update_User : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public Update_User()
        {
            InitializeComponent();
        }

        private void Update_User_Load(object sender, EventArgs e)
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

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {

                if (ID_textBox.Text == "" || name_textBox.Text == "" || Add_textBox.Text == "" || paas_textBox.Text == "" || ID_textBox.Text == "")
                {
                    MessageBox.Show("Details Cannot be null", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (Mobile_textBox.Text.Length == 10)
                    {
                        conn.Open();
                        SqlCommand cmd1 = new SqlCommand("Select * from User_Details Where User_ID=@User_ID", conn);
                        cmd1.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                        DataTable dataTable1 = new DataTable();
                        adapter1.Fill(dataTable1);
                        if (dataTable1.Rows.Count > 0)
                        {
                            SqlCommand cmd = new SqlCommand("Update User_Details set User_Name=@User_Name,User_Address=@User_Address,User_Mobile=@User_Mobile,User_Password=@User_Password Where User_ID=@User_ID", conn);
                            cmd.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                            cmd.Parameters.AddWithValue("@User_Name", name_textBox.Text);
                            cmd.Parameters.AddWithValue("@User_Address", Add_textBox.Text);
                            cmd.Parameters.AddWithValue("@User_Mobile", Mobile_textBox.Text);
                            cmd.Parameters.AddWithValue("@User_Password", paas_textBox.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Update Completed", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ID_textBox.Clear();
                            name_textBox.Clear();
                            Add_textBox.Clear();
                            Mobile_textBox.Clear();
                            paas_textBox.Clear();
                            ID_textBox.Focus();
                        }
                        else
                        {
                            MessageBox.Show("User not Found", "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ID_textBox.Clear();
                            name_textBox.Clear();
                            Add_textBox.Clear();
                            Mobile_textBox.Clear();
                            paas_textBox.Clear();
                            ID_textBox.Focus();
                        }
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mobile number must be 10 numbers", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

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
    public partial class Delete_User : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public Delete_User()
        {
            InitializeComponent();
        }

        private void All_Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("TRUNCATE TABLE User_Details", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Delete All Users Completed", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Delete_User_Load(object sender, EventArgs e)
        {
            User_ID_label.BackColor = Color.Transparent;
            User_ID_label.Parent = pictureBox1;
            D_label.BackColor = Color.Transparent;
            D_label.Parent = pictureBox1;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID_textBox.Text == "")
                {
                    MessageBox.Show("Details Cannot be null", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * from User_Details Where User_ID=@User_ID", conn);
                    cmd1.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                    DataTable dataTable1 = new DataTable();
                    adapter1.Fill(dataTable1);
                    if (dataTable1.Rows.Count > 0)
                    {

                        DialogResult result = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            SqlCommand cmd = new SqlCommand("Delete from User_Details Where User_ID=@User_ID", conn);
                            cmd.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Delete Completed", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ID_textBox.Clear();
                            ID_textBox.Focus();
                        }
                        else
                        {
                            DialogResult = DialogResult.Cancel;
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not Found", "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ID_textBox.Clear();
                        ID_textBox.Focus();
                    }
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}

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
    public partial class Delete_Book : Form
    {

        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public Delete_Book()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Select * from Book_Details Where Book_ID=@Book_ID", conn);
                cmd1.Parameters.AddWithValue("@Book_ID", ID_textBox.Text);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                if (dataTable1.Rows.Count > 0)
                {

                    DialogResult result = MessageBox.Show("Do You Want to Delete?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        if (ID_textBox.Text == "")
                        {
                            MessageBox.Show("Book id Cannot be null", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                           
                            SqlCommand cmd = new SqlCommand("Delete from Book_Details Where Book_ID=@Book_ID", conn);
                            cmd.Parameters.AddWithValue("@Book_ID", ID_textBox.Text);
                            cmd.ExecuteNonQuery();
                         
                            MessageBox.Show("Book Delete Completed", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ID_textBox.Clear();
                            ID_textBox.Focus();
                        }
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                }
                else
                {
                    MessageBox.Show("Book not Found", "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ID_textBox.Clear();
                    ID_textBox.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void Delete_Book_Load(object sender, EventArgs e)
        {
            Book_ID_label.BackColor = Color.Transparent;
            Book_ID_label.Parent = pictureBox1;
            D_label.BackColor = Color.Transparent;
            D_label.Parent = pictureBox1;
        }

        private void Ad_button_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("Do You Want to clear?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Book_Details", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Book Delete Completed", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
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

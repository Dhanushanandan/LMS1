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
    public partial class R_V_Book : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public R_V_Book()
        {
            InitializeComponent();
        }

        private void R_V_Book_Load(object sender, EventArgs e)
        {

        }

        private void All_View_button_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Select * from Return_Book_Details", conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                dataGridView1.DataSource = dataTable1;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found" + ex, "button", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {


            try
            {
                dataGridView1.Refresh();

                if (Search_textBox.Text == "")
                {
                    MessageBox.Show("Invalid Input!!!! \n", "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Search_textBox.Clear();
                    Search_textBox.Focus();
                    return;
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * from Return_Book_Details Where Book_ID=@Book_ID OR User_ID=@User_ID", conn);
                    cmd1.Parameters.AddWithValue("@Book_ID", Search_textBox.Text);
                    cmd1.Parameters.AddWithValue("@User_ID", Search_textBox.Text);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                    DataTable dataTable1 = new DataTable();
                    adapter1.Fill(dataTable1);
                    if (dataTable1.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable1;
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Result Found", "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Search_textBox.Clear();
                        Search_textBox.Focus();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found" + ex, "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}

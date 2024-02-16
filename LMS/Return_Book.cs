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
    public partial class Return_Book : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public Return_Book()
        {
            InitializeComponent();
        }

        private void Return_Book_Load(object sender, EventArgs e)
        {
            Book_ID_label.BackColor = Color.Transparent;
            Book_ID_label.Parent = pictureBox1;
            Book_Name_label.BackColor = Color.Transparent;
            Book_Name_label.Parent = pictureBox1;
            Row_label.BackColor = Color.Transparent;
            Row_label.Parent = pictureBox1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Refresh();

                if (ID_textBox.Text == "" || name_textBox.Text == "")
                {
                    MessageBox.Show("Invalid Input!!!! \n", "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ID_textBox.Clear();
                    name_textBox.Clear() ;
                    ID_textBox.Focus();
                    return;
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * from Borrowed_Book Where Book_ID=@Book_ID AND User_ID=@User_ID", conn);
                    cmd1.Parameters.AddWithValue("@Book_ID", name_textBox.Text);
                    cmd1.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
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
                        ID_textBox.Clear();
                        name_textBox.Clear();
                        ID_textBox.Focus();
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

        private void Add_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ID_textBox.Text == "" || name_textBox.Text == "")
                {
                    MessageBox.Show("Details Cannot be null", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Return_Book_Details values(@User_ID,@Book_Id,@Return_Date)", conn);
                    cmd.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                    cmd.Parameters.AddWithValue("@Book_ID", name_textBox.Text);
                    cmd.Parameters.AddWithValue("@Return_Date", dateTimePicker1.Value.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Return Add Completed", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ID_textBox.Clear();
                    name_textBox.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                    dataGridView1.ClearSelection();
                    ID_textBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

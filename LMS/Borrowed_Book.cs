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
    public partial class Borrowed_Book : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public Borrowed_Book()
        {
            InitializeComponent();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do You Want to clear?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ID_textBox.Clear();
                name_textBox.Clear();
                Author_textBox.Clear();
                dateTimePicker1.Value = DateTime.Now;
                ID_textBox.Focus();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void Borrowed_Book_Load(object sender, EventArgs e)
        {

            Book_ID_label.BackColor = Color.Transparent;
            Book_ID_label.Parent = pictureBox1;
            Book_Name_label.BackColor = Color.Transparent;
            Book_Name_label.Parent = pictureBox1;
            Author_Name_label.BackColor = Color.Transparent;
            Author_Name_label.Parent = pictureBox1;
            Row_label.BackColor = Color.Transparent;
            Row_label.Parent = pictureBox1;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {

            try
            {
                if (ID_textBox.Text == "" || name_textBox.Text == "" || Author_textBox.Text == "")
                {
                    MessageBox.Show("Details Cannot be null", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        SqlCommand cmd2 = new SqlCommand("Select * from Book_Details Where Book_ID=@Book_ID", conn);
                        cmd2.Parameters.AddWithValue("@Book_ID", name_textBox.Text);
                        SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                        DataTable dataTable2 = new DataTable();
                        adapter2.Fill(dataTable2);
                        if (dataTable2.Rows.Count > 0)
                        {
                            SqlCommand cmd = new SqlCommand("insert into Borrowed_Book values(@User_ID,@Book_ID,@Book_Name,@Book_Borrowed_Date)", conn);
                            cmd.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                            cmd.Parameters.AddWithValue("@Book_ID", name_textBox.Text);
                            cmd.Parameters.AddWithValue("@Book_Name", Author_textBox.Text);
                            cmd.Parameters.AddWithValue("@Book_Borrowed_Date", dateTimePicker1.Value.ToString());
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Borrowed Book Add Completed", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ID_textBox.Clear();
                            name_textBox.Clear();
                            Author_textBox.Clear();
                            dateTimePicker1.Value = DateTime.Now;
                            ID_textBox.Focus();

                        }
                        else
                        {
                            MessageBox.Show("Book not Found", "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ID_textBox.Clear();
                            name_textBox.Clear();
                            Author_textBox.Clear();
                            dateTimePicker1.Value = DateTime.Now;
                            ID_textBox.Focus();
                        }
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("User not Found", "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ID_textBox.Clear();
                        name_textBox.Clear();
                        Author_textBox.Clear();
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
    }
}

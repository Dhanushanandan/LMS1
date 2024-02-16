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
    public partial class Update_Book : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public Update_Book()
        {
            InitializeComponent();
        }

        private void Update_Book_Load(object sender, EventArgs e)
        {

            Book_ID_label.BackColor = Color.Transparent;
            Book_ID_label.Parent = pictureBox1;
            Book_Name_label.BackColor = Color.Transparent;
            Book_Name_label.Parent = pictureBox1;
            Author_Name_label.BackColor = Color.Transparent;
            Author_Name_label.Parent = pictureBox1;
            Rack_label.BackColor = Color.Transparent;
            Rack_label.Parent = pictureBox1;
            Row_label.BackColor = Color.Transparent;
            Row_label.Parent = pictureBox1;
            Book_Available_label.BackColor = Color.Transparent;
            Book_Available_label.Parent = pictureBox1;
        }

        private void Update_button_Click(object sender, EventArgs e)
        {


            try
            {
                if (ID_textBox.Text == "" || name_textBox.Text == "" || Author_textBox.Text == "" || Rack_textBox.Text == "" || Row_textBox.Text == "" || Available_comboBox.Text == "")
                {
                    MessageBox.Show("Details Cannot be null", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * from Book_Details Where Book_ID=@Book_ID", conn);
                    cmd1.Parameters.AddWithValue("@Book_ID", ID_textBox.Text);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                    DataTable dataTable1 = new DataTable();
                    adapter1.Fill(dataTable1);
                    if (dataTable1.Rows.Count > 0)
                    {

                        DialogResult result = MessageBox.Show("Do You Want to Update?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                           
                            SqlCommand cmd = new SqlCommand("Update Book_Details set Book_Name=@Book_Name,Book_Author=@Book_Author,Book_Row=@Book_Row,Book_Rack=@Book_Rack,Book_Availability=@Book_Availability Where Book_ID=@Book_ID", conn);
                            cmd.Parameters.AddWithValue("@Book_ID", ID_textBox.Text);
                            cmd.Parameters.AddWithValue("@Book_Name", name_textBox.Text);
                            cmd.Parameters.AddWithValue("@Book_Author", Author_textBox.Text);
                            cmd.Parameters.AddWithValue("@Book_Row", Rack_textBox.Text);
                            cmd.Parameters.AddWithValue("@Book_Rack", Row_textBox.Text);
                            cmd.Parameters.AddWithValue("@Book_Availability", Available_comboBox.Text);
                            cmd.ExecuteNonQuery();
                         
                            MessageBox.Show("Book Update Completed", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ID_textBox.Clear();
                            name_textBox.Clear();
                            Author_textBox.Clear();
                            Rack_textBox.Clear();
                            Row_textBox.Clear();
                            Available_comboBox.Text = string.Empty;
                            ID_textBox.Focus();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do You Want to clear?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ID_textBox.Clear();
                name_textBox.Clear();
                Author_textBox.Clear();
                Rack_textBox.Clear();
                Row_textBox.Clear();
                Available_comboBox.Text = string.Empty;
                ID_textBox.Focus();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}

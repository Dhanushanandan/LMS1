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
    public partial class Rules : Form
    {
        String id;
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect(); 
        public Rules(String Id)
        {
            InitializeComponent();
            id = Id;
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Rules", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void Fine_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Fine_Payment Where User_ID=@User_ID", conn);
            cmd.Parameters.AddWithValue("@User_ID", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void Damage_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Damaged_Book Where User_ID=@User_ID", conn);
                cmd.Parameters.AddWithValue("@User_ID", id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(""+ex);
                return;
            }
           
        }
    }
}

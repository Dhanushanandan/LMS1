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
    public partial class User_Membership : Form
    {
        String id;
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public User_Membership(String Id)
        {
            InitializeComponent();
            id=Id;
        }

        private void User_Membership_Load(object sender, EventArgs e)
        {
           
        }

        private void Menbership_Detail_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Membership_details Where User_ID=@User_ID", conn);
            cmd.Parameters.AddWithValue("@User_ID", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void Membership_payment_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Membership_Payment Where User_ID=@User_ID", conn);
            cmd.Parameters.AddWithValue("@User_ID", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }
    }
}

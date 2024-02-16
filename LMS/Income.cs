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
    public partial class Income : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect(); 
        //calculation variables
        double tfine = 0.00, tmem = 0.00, tdam = 0.00, total = 0.00;
        public Income()
        {
            InitializeComponent();
        }

        private void Income_Load(object sender, EventArgs e)
        {

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tmem = 0.00;
                tdam = 0.00;
                tfine = 0.00;
                total = 0.00;

                SqlCommand cmd1 = new SqlCommand("Select * from Membership_Payment", conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                dataGridView1.DataSource = dataTable1;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    tmem += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
               
                SqlCommand cmd2 = new SqlCommand("Select * from Fine_Payment", conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);
                dataGridView1.DataSource = dataTable2;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    tfine += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
                
                SqlCommand cmd3 = new SqlCommand("Select * from Damaged_Book", conn);
                SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
                DataTable dataTable3 = new DataTable();
                adapter3.Fill(dataTable3);
                dataGridView1.DataSource = dataTable3;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    tdam += double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                }
                conn.Close();
                total = tfine + tmem + tdam;
                textBox4.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found" + ex, "button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tfine = 0.00;
                SqlCommand cmd1 = new SqlCommand("Select * from Fine_Payment", conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                dataGridView1.DataSource = dataTable1;
                for(int i = 0; i < dataGridView1.Rows.Count -1 ; i++)
                {
                    tfine += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
                conn.Close();
                textBox1.Text= tfine.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found" + ex, "button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tmem = 0.00;
                SqlCommand cmd1 = new SqlCommand("Select * from Membership_Payment", conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                dataGridView1.DataSource = dataTable1;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    tmem += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
                conn.Close();
                textBox3.Text = tmem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found" + ex, "button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tdam = 0.00;
                SqlCommand cmd1 = new SqlCommand("Select * from Damaged_Book", conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                dataGridView1.DataSource = dataTable1;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    tdam += double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                }
                conn.Close();
                textBox2.Text = tdam.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found" + ex, "button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}

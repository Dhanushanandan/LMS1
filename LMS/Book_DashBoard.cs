using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS
{
    public partial class Book_DashBoard : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect(); 
        //detect user id and global the variable
        String Id;
        Boolean ViewButton=false,BorrowedButton= false,Return=false;

        public Point mouseLocation;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, //x-coordinate of upper-left corner

            int nTopRect, // y-coordinate of upper-left corner

            int nRightRect, // x-coordinate of lower-right corner

            int nBottomRect, // y-coordinate of lower-right corner

            int nWidthEllipse, // height of ellipse

            int nHeightEllipse // width of ellipse

            );
        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);

        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                mouseLocation = mousePose;
            }
        }
        public Book_DashBoard(string id)
        {
            InitializeComponent();
            Id = id;
        }
        private void Book_DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void View_Book_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Book_Details", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
            ViewButton = true;
            BorrowedButton = false;
            Return = false;
        }

        private void Borrowed_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Borrowed_Book Where User_ID=@User_ID", conn);
            cmd.Parameters.AddWithValue("@User_ID",Id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
            BorrowedButton = true;
            ViewButton = false;
            Return = false;
        }

        private void Retun_Book_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Return_Book_Details Where Book_ID=@Book_ID", conn);
            cmd.Parameters.AddWithValue("@Book_ID",Id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
            BorrowedButton = false;
            ViewButton = false;
            Return = true;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            
            if (Search_textBox.Text == "")
            {
                MessageBox.Show("Enter a Valid Input!!!! \n", "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Search_textBox.Clear();
                Search_textBox.Focus();
                return;
            }
            else if(ViewButton == false && BorrowedButton == false && Return==false)
            {
                conn.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * from Book_Details Where Book_ID=@Book_ID OR Book_Name=@Book_Name OR Book_Author=@Book_Author", conn);
                    cmd1.Parameters.AddWithValue("@Book_ID", Search_textBox.Text);
                    cmd1.Parameters.AddWithValue("@Book_Name", Search_textBox.Text);
                    cmd1.Parameters.AddWithValue("@Book_Author", Search_textBox.Text);
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
            else
            {
                if (ViewButton == true)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Book_Details Where Book_ID=@Book_ID OR Book_Name=@Book_Name OR Book_Author=@Book_Author", conn);
                    cmd.Parameters.AddWithValue("@Book_ID", Search_textBox.Text);
                    cmd.Parameters.AddWithValue("@Book_Name", Search_textBox.Text);
                    cmd.Parameters.AddWithValue("@Book_Author", Search_textBox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable;
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
                else if (BorrowedButton = true)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Borrowed_Book Where Book_ID=@Book_ID OR Book_Name=@Book_Name", conn);
                    cmd.Parameters.AddWithValue("@Book_ID", Search_textBox.Text);
                    cmd.Parameters.AddWithValue("@Book_Name", Search_textBox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable;
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Result Found", "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Search_textBox.Clear();
                        Search_textBox.Focus();
                        conn.Close();
                    }
                }else if(Return == true)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Return_Book_Details Where Book_ID=@Book_ID", conn);
                    cmd.Parameters.AddWithValue("@Book_ID", Search_textBox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable;
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
            
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Do You Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS
{
    public partial class A_D_UP_Fine : Form
    {
        //invoking the database connecting using a seperate class with creating an object
        SqlConnection conn = new Database().DBConnect();
        public A_D_UP_Fine()
        {
            InitializeComponent();
        }

        private void A_D_UP_Fine_Load(object sender, EventArgs e)
        {
            Book_ID_label.BackColor = Color.Transparent;
            Book_ID_label.Parent = pictureBox1;
            Book_Name_label.BackColor = Color.Transparent;
            Book_Name_label.Parent = pictureBox1;
            Damaged_label.BackColor = Color.Transparent;
            Damaged_label.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to clear?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ID_textBox.Clear();
                name_textBox.Clear();
                textBox1.Clear();
                Damaged_textBox.Clear();
                ID_textBox.Focus();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID_textBox.Text == "" || name_textBox.Text == "" || Damaged_textBox.Text == "" || textBox1.Text=="")
                {
                    MessageBox.Show("Values cannot be null", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    DialogResult result = MessageBox.Show("Do You Want to Submit?", "SUBMIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Update Damaged_Book set Damaged_Fine=@Damaged_Fine,User_ID=@User_ID,Book_ID=@Book_ID Where Damaged_ID=@Damaged_ID", conn);
                        cmd.Parameters.AddWithValue("@Damaged_ID", textBox1.Text);
                        cmd.Parameters.AddWithValue("@User_ID", ID_textBox.Text);
                        cmd.Parameters.AddWithValue("@Book_ID", name_textBox.Text);
                        cmd.Parameters.AddWithValue("@Damaged_Fine", float.Parse(Damaged_textBox.Text));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Update Successful", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ID_textBox.Clear();
                        name_textBox.Clear();
                        Damaged_textBox.Clear();
                        ID_textBox.Focus();
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}

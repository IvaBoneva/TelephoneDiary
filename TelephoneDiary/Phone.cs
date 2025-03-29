using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TelephoneDiary
{
    public partial class Phone : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Phone;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public Phone()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Phone_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxFName.Clear();
            txtBoxLName.Clear();
            txtBoxMobile.Clear();
            txtBoxEmail.Clear();
            comboBoxCategory.SelectedIndex = -1;
            txtBoxFName.Focus();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Mobiles (First, Last, Mobile, Email, Category) 
VALUES (@First, @Last, @Mobile, @Email, @Category)", con))
            {
                cmd.Parameters.AddWithValue("@First", txtBoxFName.Text);
                cmd.Parameters.AddWithValue("@Last", txtBoxLName.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtBoxMobile.Text);
                cmd.Parameters.AddWithValue("@Email", txtBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Category", comboBoxCategory.Text);

                cmd.ExecuteNonQuery();  // Изпълнява SQL командата
            }


            con.Close();
            MessageBox.Show("Successfully saved...!");
            Display();
        }

        void Display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Mobiles", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxFName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtBoxLName.Text = dataGridView1.SelectedRows[1].Cells[1].Value.ToString();
            txtBoxMobile.Text = dataGridView1.SelectedRows[2].Cells[2].Value.ToString();
            txtBoxEmail.Text = dataGridView1.SelectedRows[3].Cells[3].Value.ToString();
            comboBoxCategory.Text = dataGridView1.SelectedRows[4].Cells[4].Value.ToString();
        }
    }
}

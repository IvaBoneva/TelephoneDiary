using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void btnNew_Click(object sender, EventArgs e)
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
            if (dataGridView1.SelectedRows.Count > 0) // Проверка дали има избран ред
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0]; // Вземаме първия избран ред

                txtBoxFName.Text = row.Cells[0].Value?.ToString();
                txtBoxLName.Text = row.Cells[1].Value?.ToString();
                txtBoxMobile.Text = row.Cells[2].Value?.ToString();
                txtBoxEmail.Text = row.Cells[3].Value?.ToString();
                comboBoxCategory.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand(@"DELETE FROM Mobiles 
WHERE (Mobile = @Mobile)", con))
            {
                cmd.Parameters.AddWithValue("@Mobile", txtBoxMobile.Text);
                cmd.ExecuteNonQuery();  // Изпълнява SQL командата
            }


            con.Close();
            MessageBox.Show("Successfully deleted...!");
            Display();
            txtBoxFName.Clear();
            txtBoxLName.Clear();
            txtBoxMobile.Clear();
            txtBoxEmail.Clear();
            comboBoxCategory.SelectedIndex = -1;
            txtBoxFName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand(@"UPDATE Mobiles 
SET First = @First, Last = @Last, Mobile = @Mobile, Email = @Email, Category = @Category
WHERE (Mobile = @Mobile)", con))
            {
                cmd.Parameters.AddWithValue("@First", txtBoxFName.Text);
                cmd.Parameters.AddWithValue("@Last", txtBoxLName.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtBoxMobile.Text);
                cmd.Parameters.AddWithValue("@Email", txtBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Category", comboBoxCategory.Text);

                cmd.ExecuteNonQuery();  // Изпълнява SQL командата
                con.Close();
                MessageBox.Show("Successfully updated...!");
                Display();
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Mobiles Where (Mobile like '%" + txtBoxSearch.Text + "%') or (First like '%" + txtBoxSearch.Text + "%') or (Last like '%" + txtBoxSearch.Text + "%')", con);
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
    }
}

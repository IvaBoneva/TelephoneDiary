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

namespace TelephoneDiary
{
    public partial class Phone : Form
    {
        public Phone()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Phone_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxFName.Clear();
            txtBoxLName.Clear();
            txtBoxMobile.Clear();
            txtBoxEmail.Clear();
            comboBoxCatagory.SelectedIndex = -1;
            txtBoxFName.Focus();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}

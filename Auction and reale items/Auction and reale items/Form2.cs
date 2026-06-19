using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Auction_and_reale_items
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            Form1.savedUsername = txtNewUsername.Text;
            Form1.savedPassword = txtNewPassword.Text;

            Form3.userWallets[txtNewUsername.Text] = 1000;

            MessageBox.Show("Account Created Successfully!");

            Form1 login = new Form1();

            login.Show();

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();

            login.Show();

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

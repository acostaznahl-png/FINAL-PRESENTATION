using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Auction_and_reale_items
{
    public partial class Form1 : Form
    {
        public static string savedUsername = "";
        public static string savedPassword = "";

        private const string ADMIN_USERNAME = "admin";
        private const string ADMIN_PASSWORD = "admin123";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("User");

            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string role = cmbRole.Text;

            if (role == "Admin")
            {
                if (txtUsername.Text == ADMIN_USERNAME &&
                    txtPassword.Text == ADMIN_PASSWORD)
                {
                    Form3.currentUser = "admin";
                    Form3 dashboard = new Form3();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Admin Credentials!");
                }
            }
            else if (role == "User")
            {
                if (txtUsername.Text == savedUsername &&
                    txtPassword.Text == savedPassword)
                {
                    Form3.currentUser = savedUsername;
                    Form3 dashboard = new Form3();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User Credentials!");
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Form2 signup = new Form2();

            signup.Show();

            this.Hide();
        }
    }
}

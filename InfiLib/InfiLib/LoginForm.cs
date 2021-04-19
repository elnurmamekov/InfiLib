using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InfiLib
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,20,20));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "your_user_name" && txtPassword.Text == "your_password")
            {
                new Menu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or Password you entered is incorrect, please, Try again!");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

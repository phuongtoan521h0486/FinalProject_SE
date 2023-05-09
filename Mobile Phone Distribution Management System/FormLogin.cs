using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Mobile_Phone_Distribution_Management_System
{
    public partial class FormLogin : Form
    {
        public static string fullName;
        public static bool isAdmin;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            pictureBoxNotEye.Visible = false;
            pictureBoxEye.Visible = false;
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            pictureBoxEye.Visible = true;
        }

        private void pictureBoxEye_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = false;
            pictureBoxNotEye.Visible = true;
            pictureBoxEye.Visible = false;
        }

        private void pictureBoxEye_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
            pictureBoxNotEye.Visible = false;
            pictureBoxEye.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
            {
                labelErrorUser.Visible = true;
                labelErrorMessage.Text = "Please enter your username";
                textBoxUser.Focus();
                pictureBoxNotEye.Visible = false;
                pictureBoxEye.Visible = false;
                return;
            }
            else
            {
                labelErrorUser.Visible = false;
                
            }
            if (textBoxPass.Text == "")
            {
                labelErrorPass.Visible = true;
                labelErrorMessage.Text = "Please enter your password";
                textBoxPass.Focus();
                pictureBoxEye.Visible = true;
                return;
            }
            else
            {
                labelErrorPass.Visible = false;

            }
            if (checkLoginAccountant(textBoxUser.Text, textBoxPass.Text).Rows.Count > 0)
            {
                labelErrorMessage.Text = "";
                labelErrorUser.Visible = false;
                labelErrorPass.Visible = false;
                var table = checkLoginAccountant(textBoxUser.Text, textBoxPass.Text);
                fullName = table.Rows[0][0].ToString();
                isAdmin = true;
                this.Hide();
            }
            else if (checkLoginReseller(textBoxUser.Text, textBoxPass.Text).Rows.Count > 0)
            {
                labelErrorMessage.Text = "";
                labelErrorUser.Visible = false;
                labelErrorPass.Visible = false;
                var table = checkLoginReseller(textBoxUser.Text, textBoxPass.Text);
                fullName = table.Rows[0][0].ToString();
                isAdmin = false;
                this.Hide();
            }
            else
            {
                labelErrorMessage.Text = "Invalid username or password";
            }
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonLogin.PerformClick();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxUser.Text = "";
            textBoxPass.Text = "";
        }

        private DataTable checkLoginReseller(string username,string password)
        {
            var reseller = new BUS_Reseller("resellerID", "resellerName", "contactInfo", username, password, "paymentMethod");
            return reseller.checkLogin();
        }

        private DataTable checkLoginAccountant(string username, string password)
        {
            var accountant = new BUS_Accountant("accountantID", "accountantName", "contactInfo", username, password);
            return accountant.checkLogin();
        }
    }
}

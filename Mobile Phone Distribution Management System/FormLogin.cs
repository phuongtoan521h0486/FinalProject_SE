using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Phone_Distribution_Management_System
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (textBoxUser.Text == "admin" && textBoxPass.Text == "123456")
            {
                labelErrorMessage.Text = "";
                labelErrorUser.Visible = false;
                labelErrorPass.Visible = false;
                this.Close();
            }
            else
            {
                labelErrorMessage.Text = "Invalid username or password";
            }
        }

    }
}

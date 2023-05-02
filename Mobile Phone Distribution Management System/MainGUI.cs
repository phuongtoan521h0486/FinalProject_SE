using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Mobile_Phone_Distribution_Management_System
{
    public partial class MainGUI : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        Form currentForm;
        public MainGUI()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            Form formLogin = new FormLogin();
            Form formDashboard = new FormDashboard();
            Form formImportGoods = new FormImportGoods();
            //formImportGoods.ShowDialog();
            //formLogin.ShowDialog();
            //labelFullName.Text = FormLogin.fullName;
        }
        private void hideSubMenu()
        {
            if (panelSubOrders.Visible == true) { panelSubOrders.Visible = false; }
            if (panelSubProducts.Visible == true) { panelSubProducts.Visible = false; }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else { subMenu.Visible = false; }
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubProducts);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // code here
            hideSubMenu();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubOrders);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            //panelMenu.Width = (panelMenu.Width == panelMenu.MinimumSize.Width) ? panelMenu.MaximumSize.Width : panelMenu.MinimumSize.Width;
            

            if (panelMenu.Width == panelMenu.MinimumSize.Width)
            {
                panelMenu.Width = panelMenu.MaximumSize.Width;

                buttonDashBoard.Text = "Dashboard";
                buttonMenu.Text = "Menu";
                buttonProducts.Text = "Products";
                buttonOrders.Text = "Orders";
                buttonSetting.Text = "Setting";
                buttonHelp.Text = "Help";
            }
            else
            {
                panelMenu.Width = panelMenu.MinimumSize.Width;

                buttonDashBoard.Text = string.Empty;
                buttonMenu.Text = string.Empty;
                buttonProducts.Text = string.Empty;
                buttonOrders.Text = string.Empty;
                buttonSetting.Text = string.Empty;
                buttonHelp.Text = string.Empty;
            }
        }

        private void loadForm(object Form)
        {
            if (currentForm != null) currentForm.Close();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            currentForm = f;
            f.Show();
        }

        private void buttonDashBoard_Click(object sender, EventArgs e)
        {
            loadForm(new FormDashboard());
            labelNameOfForm.Text = "Dashboard";
            labelNameOfForm.Visible = true;
            buttonCloseCurrentForm.Visible = true;
        }

        private void buttonCloseCurrentForm_Click(object sender, EventArgs e)
        {
            if (currentForm != null) currentForm.Close();
            labelNameOfForm.Visible = false;
            buttonCloseCurrentForm.Visible = false;
        }
    }
}

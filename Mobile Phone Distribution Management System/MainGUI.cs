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
    public partial class MainGUI : Form
    {
        bool isExpand;
        public MainGUI()
        {
            InitializeComponent();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            Form fromLogin = new FormLogin();
            //fromLogin.ShowDialog();
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
    }
}

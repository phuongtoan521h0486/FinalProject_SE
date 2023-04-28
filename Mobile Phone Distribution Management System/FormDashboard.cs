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
    public partial class FormDashboard : Form
    {
        private BUS_Dashboard dashboard;
        private Button currentButton;
        public FormDashboard()
        {
            InitializeComponent();
            dateTimePickerStartDate.Value = DateTime.Today.AddDays(-7);
            dateTimePickerEndDate.Value = DateTime.Now;
            buttonLast7Days.Select();
            SetDateMenuButtonsUI(buttonLast7Days);
            dashboard = new BUS_Dashboard();
            LoadData();
        }

        private void LoadData()
        {
            var refreshData = dashboard.loadData(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
            if (refreshData == true)
            {
                labelNumberOrders.Text = dashboard.NumOrders.ToString();
                labelTotalRevenue.Text = "$" + dashboard.TotalRevenue.ToString();
                labelTotalProfit.Text = "$" + dashboard.TotalProfit.ToString();
                labelNumberResellers.Text = dashboard.NumResellers.ToString();
                labelNumberSuppliers.Text = dashboard.NumSuppliers.ToString();
                labelNumberProducts.Text = dashboard.NumProducts.ToString();
                chartGrossRevenue.DataSource = dashboard.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenue.DataBind();
                chartTopProduct.DataSource = dashboard.TopProductsList;
                chartTopProduct.Series[0].XValueMember = "Key";
                chartTopProduct.Series[0].YValueMembers = "Value";
                chartTopProduct.DataBind();
            }
        }

        private void SetDateMenuButtonsUI(object button)
        {
            var btn = (Button)button;
            btn.BackColor = buttonLast30Days.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            if (currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = Color.FromArgb(35, 40, 45);
                currentButton.ForeColor = Color.FromArgb(124, 141, 181);
            }
            currentButton = btn;

            if (btn==buttonCustomDate)
            {
                dateTimePickerStartDate.Enabled = true;
                dateTimePickerEndDate.Enabled = true;
                buttonOK.Visible = true;
                labelStartDate.Cursor = Cursors.Hand;
                labelEndDate.Cursor = Cursors.Hand;
            }
            else
            {
                dateTimePickerStartDate.Enabled = false;
                dateTimePickerEndDate.Enabled = false;
                buttonOK.Visible = false;
                labelStartDate.Cursor = Cursors.Default;
                labelEndDate.Cursor = Cursors.Default;
            }
            
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Value = DateTime.Today;
            dateTimePickerEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void buttonLast7Days_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Value = DateTime.Today.AddDays(-7);
            dateTimePickerEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void buttonLast30Days_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Value = DateTime.Today.AddDays(-30);
            dateTimePickerEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void buttonThisMonth_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dateTimePickerEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void buttonCustomDate_Click(object sender, EventArgs e)
        {
            
            SetDateMenuButtonsUI(sender);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void labelStartDate_Click(object sender, EventArgs e)
        {
            if (currentButton == buttonCustomDate)
            {
                dateTimePickerStartDate.Select();
                SendKeys.Send("%{DOWN}");

            }
        }

        private void labelEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == buttonCustomDate)
            {
                dateTimePickerEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            labelStartDate.Text = dateTimePickerStartDate.Text;
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            labelEndDate.Text = dateTimePickerEndDate.Text;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            labelStartDate.Text = dateTimePickerStartDate.Text;
            labelEndDate.Text = dateTimePickerEndDate.Text;
        }
    }
}
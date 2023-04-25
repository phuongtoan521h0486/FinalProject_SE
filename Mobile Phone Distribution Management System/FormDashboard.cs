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
        public FormDashboard()
        {
            InitializeComponent();
            dateTimePickerStartDate.Value = DateTime.Today.AddDays(-7);
            dateTimePickerEndDate.Value = DateTime.Now;
            buttonLast7Days.Select();
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

        private void DisableCustomDates()
        {
            dateTimePickerStartDate.Enabled = false;
            dateTimePickerEndDate.Enabled = false;
            buttonOK.Visible = false;
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Value = DateTime.Today;
            dateTimePickerEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void buttonLast7Days_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Value = DateTime.Today.AddDays(-7);
            dateTimePickerEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void buttonLast30Days_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Value = DateTime.Today.AddDays(-30);
            dateTimePickerEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void buttonThisMonth_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dateTimePickerEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void buttonCustomDate_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Enabled = true;
            dateTimePickerEndDate.Enabled = true;
            buttonOK.Visible = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

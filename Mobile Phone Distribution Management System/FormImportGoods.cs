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
    public partial class FormImportGoods : Form
    {
        private static BUS_ImportGoods importGoods = new BUS_ImportGoods();
        public List<cart> listInCart = new List<cart>();
        
        public struct cart
        {
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
        public FormImportGoods()
        {
            InitializeComponent();
            importGoods.loadData();
        }

        private void loadSupplierList()
        {
            if (importGoods.listSuppliers != null)
            {
                comboBoxSupplierList.DataSource = importGoods.listSuppliers;
                comboBoxSupplierList.DisplayMember = "SupplierName";
                comboBoxSupplierList.ValueMember = "SupplierID";
            }
        }
        private void loadProductList(string supplierID)
        {
            dataGridViewShopping.DataSource = null;

            if (dataGridViewShopping.Columns.Count > 0)
            {
                dataGridViewShopping.Columns.RemoveAt(dataGridViewShopping.Columns.Count - 1);
                foreach (DataGridViewColumn col in dataGridViewShopping.Columns)
                {
                    if (col.HeaderText == "Quantity")
                    {
                        dataGridViewShopping.Columns.Remove(col);
                        break;
                    }
                }
            }
            importGoods.LoadListProducts(supplierID);
            dataGridViewShopping.DataSource = importGoods.listProducts;

            if (!dataGridViewShopping.Columns.Contains("Quantity"))
            {
                dataGridViewShopping.Columns.Add("Quantity", "Quantity");
                dataGridViewShopping.Columns["Quantity"].ValueType = typeof(int);
            }

            if (!dataGridViewShopping.Columns.Contains("ButtonColumn"))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "ButtonColumn";
                buttonColumn.HeaderText = "Add to cart";
                buttonColumn.UseColumnTextForButtonValue = true;
                buttonColumn.Text = "Add";

                dataGridViewShopping.Columns.Add(buttonColumn);
                dataGridViewShopping.AllowUserToAddRows = false;
            }
        }
        private void FormImportGoods_Load(object sender, EventArgs e)
        {
            loadSupplierList();
            loadProductList("SP000");
            
            timerClock.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timerclock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timerClock.Start();
        }

        private void comboBoxSupplierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSupplierList.SelectedValue.ToString().Contains("SP00")) {
                loadProductList(comboBoxSupplierList.SelectedValue.ToString());
            }          
        }

        private void dataGridViewShopping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewShopping.Columns["ButtonColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewShopping.Rows[e.RowIndex];
                if (row.Cells["Quantity"].Value == null || row.Cells["Quantity"].Value.ToString() == "0")
                {
                    row.Cells["Quantity"].Value = 0;
                    labelInform.Visible = true;
                    labelInform.ForeColor = Color.Red;
                    labelInform.Text = "Please Enter Quantity";
                }
                else
                {
                    labelInform.Visible = true;
                    labelInform.ForeColor = Color.Lime;
                    labelInform.Text = string.Format("Add success {0} x {1} to cart", row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());

                    addToCart(row.Cells["ProductName"].Value.ToString(), (decimal)row.Cells["Price"].Value, (int)row.Cells["Quantity"].Value);

                    row.Cells["Quantity"].Value = 0;
                }
                
            }
        }

        private void addToCart(string name, decimal price, int quantity)
        {
            dataGridViewCart.DataSource = null;
            if (dataGridViewCart.Columns.Count > 0)
            {
                dataGridViewCart.Columns.RemoveAt(dataGridViewCart.Columns.Count - 1);
                foreach (DataGridViewColumn col in dataGridViewCart.Columns)
                {
                    if (col.HeaderText == "TotalPrice")
                    {
                        dataGridViewCart.Columns.Remove(col);
                        break;
                    }
                }
            }
            var newItem = new cart
            {
                ProductName = name,
                Price = price,
                Quantity = quantity
            };

            var existingItem = listInCart.FirstOrDefault(item => item.ProductName == newItem.ProductName);

            if (existingItem.ProductName != null)
            {
                listInCart.Remove(existingItem);
                existingItem.Quantity += newItem.Quantity;
                listInCart.Add(existingItem);
            }
            else
            {
                listInCart.Add(newItem);
            }


            dataGridViewCart.DataSource = listInCart;
            if (!dataGridViewCart.Columns.Contains("ColumnTotalPrice"))
            {
                dataGridViewCart.Columns.Add("TotalPrice", "TotalPrice");
                dataGridViewCart.Columns["TotalPrice"].ValueType = typeof(decimal);
            }
            if (!dataGridViewCart.Columns.Contains("ButtonColumn"))
            {
                DataGridViewButtonColumn buttonDelete = new DataGridViewButtonColumn();
                buttonDelete.Name = "ButtonColumn";
                buttonDelete.HeaderText = "Remove";
                buttonDelete.UseColumnTextForButtonValue = true;
                buttonDelete.Text = "Delete";

                dataGridViewCart.Columns.Add(buttonDelete);
                dataGridViewCart.AllowUserToAddRows = false;
            }

            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                row.Cells[3].Value = (decimal)row.Cells[1].Value * (int)row.Cells[2].Value;
            }

        }

        private void dataGridViewShopping_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewShopping.Columns[e.ColumnIndex].Name == "Quantity")
            {
                if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    e.Value = "0";
                    e.FormattingApplied = true;
                }
            }
        }

        private void dataGridViewShopping_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewShopping.CurrentCell.ColumnIndex == dataGridViewShopping.Columns["Quantity"].Index)
            {
                DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;

                tb.KeyPress += new KeyPressEventHandler(dataGridViewShopping_KeyPress);
            }
        }

        private void dataGridViewShopping_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCart.Columns["ButtonColumn"].Index && e.RowIndex >= 0)
            {
                var productName = dataGridViewCart.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                var itemToRemove = listInCart.FirstOrDefault(item => item.ProductName == productName);

                if (itemToRemove.ProductName != null)
                {
                    listInCart.Remove(itemToRemove);

                    dataGridViewCart.DataSource = null;
                    dataGridViewCart.Columns.RemoveAt(0);
                    dataGridViewCart.Columns.RemoveAt(0);

                    dataGridViewCart.DataSource = listInCart;
                    if (!dataGridViewCart.Columns.Contains("TotalPrice"))
                    {
                        dataGridViewCart.Columns.Add("TotalPrice", "TotalPrice");
                        dataGridViewCart.Columns["TotalPrice"].ValueType = typeof(decimal);
                    }
                    if (!dataGridViewCart.Columns.Contains("ButtonColumn"))
                    {
                        DataGridViewButtonColumn buttonDelete = new DataGridViewButtonColumn();
                        buttonDelete.Name = "ButtonColumn";
                        buttonDelete.HeaderText = "Remove";
                        buttonDelete.UseColumnTextForButtonValue = true;
                        buttonDelete.Text = "Delete";

                        dataGridViewCart.Columns.Add(buttonDelete);
                        dataGridViewCart.AllowUserToAddRows = false;
                    }
                    foreach (DataGridViewRow row in dataGridViewCart.Rows)
                    {
                        row.Cells[3].Value = (decimal)row.Cells[1].Value * (int)row.Cells[2].Value;
                    }

                    labelInform.Visible = true;
                    labelInform.ForeColor = Color.Lime;
                    labelInform.Text = string.Format("Remove success {0} x {1}", itemToRemove.ProductName, itemToRemove.Quantity);
                }
            }
        }
        private decimal calculateMoney()
        {
            decimal sum = 0;

            if (dataGridViewCart.Columns.Count < 4)
            {
                return 0;
            }
            int columnIndex = dataGridViewCart.Columns[3].Index;

            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                sum += Convert.ToDecimal(row.Cells[columnIndex].Value);
            }

            return sum;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    labelTotalMoney.Visible = false;
                    break;
                case 1:
                    labelTotalMoney.Visible = true;
                    labelTotalMoney.Text = "Total Money: $" + calculateMoney().ToString();
                    break;
            }
        }

        private void buttonCreateGoodsReceived_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn col in dataGridViewCart.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dataGridViewCart.Rows)
                {
                    DataRow dr = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dr[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dr);
                }
                decimal sum = 0;
                foreach (DataGridViewRow r in dataGridViewCart.Rows)
                {
                    sum += (decimal)r.Cells["TotalPrice"].Value;
                }

                DataColumn totalMoney = new DataColumn("TotalMoney", typeof(decimal));
                totalMoney.DefaultValue = sum;
                dt.Columns.Add(totalMoney);

                BUS_Warehouse warehouse = new BUS_Warehouse();
                DataColumn warehouseReceiptNumber = new DataColumn("WarehouseReceiptNumber", typeof(string));
                string warehouseReceipt = warehouse.generateNewWarehouseReceiptNumber();
                warehouseReceiptNumber.DefaultValue = warehouseReceipt;
                dt.Columns.Add(warehouseReceiptNumber);

                CrystalReportWarehouseReceipt report = new CrystalReportWarehouseReceipt();
                report.SetDataSource(dt);

                FormWarehouseReceipt f = new FormWarehouseReceipt();
                f.crystalReportViewer1.ReportSource = report;
                f.ShowDialog();

                saveReport(warehouseReceipt, dt);
            }
            else
            {
                MessageBox.Show("Your Cart is Empty !");
            }
            
        }

        private void saveReport(string warehouseReceiptNumber, DataTable table) 
        {
            List<string> productName = new List<string>();
            List<string> productID = new List<string>();
            List<int> productQuantity = new List<int>();
            int numProduct = table.Rows.Count;
            foreach (DataRow row in table.Rows)
            {
                productName.Add((string)row["ProductName"]);
                productQuantity.Add(Convert.ToInt32(row["Quantity"].ToString()));
            }

            BUS_Product product = new BUS_Product();
            foreach(string name in productName)
            {
                productID.Add((string)product.getIdByProductName(name).Rows[0][0]);
            }

            for (int i = 0; i< numProduct; ++i)
            {
                var warehouse = new BUS_Warehouse(warehouseReceiptNumber, DateTime.Now, productID[i], productQuantity[i]);
                warehouse.add();
            }

            MessageBox.Show("Imports goods successful");
            listInCart.Clear();
            dataGridViewCart.DataSource = null;
        }
    }
}

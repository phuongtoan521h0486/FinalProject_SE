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
using System.Data;

namespace Mobile_Phone_Distribution_Management_System
{
    public partial class FormDelivery : Form
    {
        public FormDelivery()
        {
            InitializeComponent();
            
        }

        private void FormDelivery_Load(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            BUS_Delivery loadData = new BUS_Delivery();
            BUS_Product product = new BUS_Product();
            loadData.loadListOrder();
            loadData.loadListOrderItem();
            DataTable orderTable = loadData.listOrder;
            DataTable orderItemTable = loadData.ListOrderItem;
            DataTable productTable = product.select();

           

        }
    }
}

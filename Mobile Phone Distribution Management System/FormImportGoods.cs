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
    public partial class FormImportGoods : Form
    {
        public FormImportGoods()
        {
            InitializeComponent();
        }

        private void FormImportGoods_Load(object sender, EventArgs e)
        {
            timerClock.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timerclock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timerClock.Start();
        }
    }
}
